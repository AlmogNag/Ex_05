using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Ex05
{
    public partial class MainForm : Form
    {
        private readonly int r_NumOfGuesses;
        private readonly GameLogic m_GameLogic;
        private readonly List<GuessRow> m_GuessRows = new List<GuessRow>();
        private readonly Button[] m_TopSecretButtons = new Button[4];

        public MainForm(int i_NumOfGuesses)
        {
            InitializeComponent();
            r_NumOfGuesses = i_NumOfGuesses;
            m_GameLogic = new GameLogic();
            InitializeGameBoard();
        }

        private void InitializeGameBoard()
        {
            // Top secret buttons (black until revealed)
            for (int i = 0; i < 4; i++)
            {
                Button secretBtn = new Button
                {
                    Width = 45,
                    Height = 45,
                    BackColor = Color.Black,
                    Enabled = false,
                    Margin = new Padding(5)
                };
                flowLayoutPanelTopRow.Controls.Add(secretBtn);
                m_TopSecretButtons[i] = secretBtn;
            }

            // Guess rows
            for (int i = 0; i < r_NumOfGuesses; i++)
            {
                GuessRow row = new GuessRow(i, onColorClick, onSubmitClick);
                m_GuessRows.Add(row);
                flowLayoutPanelGuessRows.Controls.Add(row.RowPanel);

                if (i == 0)
                {
                    row.Enable();
                }
            }
        }

        private void onColorClick(object sender, EventArgs e)
        {
            Button clickedBtn = sender as Button;
            GuessRow activeRow = m_GuessRows.First(r => r.ColorButtons.Contains(clickedBtn));

            List<Color> usedColors = activeRow.ColorButtons
                .Where(b => b.BackColor != Color.Black)
                .Select(b => b.BackColor)
                .ToList();

            using (ColorPickerForm picker = new ColorPickerForm(usedColors))
            {
                picker.StartPosition = FormStartPosition.Manual;
                picker.Location = new Point(
                    this.Location.X + (this.Width - picker.Width) / 2,
                    this.Location.Y + (this.Height - picker.Height) / 2
                );

                if (picker.ShowDialog() == DialogResult.OK)
                {
                    clickedBtn.BackColor = picker.SelectedColor;
                }
            }

            activeRow.SubmitButton.Enabled = activeRow.IsComplete;
        }

        private void onSubmitClick(object sender, EventArgs e)
        {
            GuessRow currentRow = m_GuessRows.First(r => r.SubmitButton == sender);
            List<Color> guess = currentRow.ColorButtons.Select(b => b.BackColor).ToList();

            List<Color> feedback = m_GameLogic.GetFeedback(guess);
            for (int i = 0; i < 4; i++)
            {
                currentRow.FeedbackBoxes[i].BackColor = feedback[i];
            }

            currentRow.Disable();

            if (m_GameLogic.IsWin(guess))
            {
                revealAnswer();
                MessageBox.Show("You won!", "Game Over");
                return;
            }

            int index = m_GuessRows.IndexOf(currentRow);
            if (index + 1 < m_GuessRows.Count)
            {
                m_GuessRows[index + 1].Enable();
            }
            else
            {
                revealAnswer();
                MessageBox.Show("You lost!", "Game Over");
            }
        }

        private void revealAnswer()
        {
            List<Color> target = m_GameLogic.TargetColors;
            for (int i = 0; i < 4; i++)
            {
                m_TopSecretButtons[i].BackColor = target[i];
            }
        }
    }
}

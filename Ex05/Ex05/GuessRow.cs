using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Ex05
{
    internal class GuessRow
    {
        public FlowLayoutPanel RowPanel { get; } = new FlowLayoutPanel();
        public Button[] ColorButtons { get; } = new Button[4];
        public Button SubmitButton { get; } = new Button();
        public Label[] FeedbackBoxes { get; } = new Label[4];
        private TableLayoutPanel m_FeedbackPanel = new TableLayoutPanel();

        public GuessRow(int rowIndex, EventHandler colorClickHandler, EventHandler submitClickHandler)
        {
            RowPanel.Height = 55;
            RowPanel.Dock = DockStyle.Top;
            RowPanel.Padding = new Padding(0);
            RowPanel.Margin = new Padding(0);
            RowPanel.WrapContents = false;
            RowPanel.AutoSize = true;
            RowPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            // Color buttons
            for (int button = 0; button < 4; button++)
            {
                var colorBtn = new Button
                {
                    Width = 45,
                    Height = 45,
                    BackColor = Color.Gray,
                    Margin = new Padding(5),
                    Enabled = false,
                    Tag = button
                };
                colorBtn.Click += colorClickHandler;
                ColorButtons[button] = colorBtn;
                RowPanel.Controls.Add(colorBtn);
            }

            // Submit button 
            SubmitButton.Text = "->";
            SubmitButton.Width = 45;
            SubmitButton.Height = 45;
            SubmitButton.Enabled = false;
            SubmitButton.Click += submitClickHandler;
            SubmitButton.Margin = new Padding(10, 5, 10, 5);
            RowPanel.Controls.Add(SubmitButton);

            // Feedback panel (2x2)
            m_FeedbackPanel.RowCount = 2;
            m_FeedbackPanel.ColumnCount = 2;
            m_FeedbackPanel.Width = 40;
            m_FeedbackPanel.Height = 40;
            m_FeedbackPanel.Margin = new Padding(10, 8, 10, 5);

            for (int row = 0; row < 2; row++)
            {
                m_FeedbackPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            }
            for (int col = 0; col < 2; col++)
            {
                m_FeedbackPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            }

            // Add feedback boxes
            for (int i = 0; i < 4; i++)
            {
                var feedback = new Label
                {
                    Width = 15,
                    Height = 15,
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.LightGray,
                    Margin = new Padding(2)
                };
                FeedbackBoxes[i] = feedback;

                // add 2x2 table
                int row = i / 2;
                int col = i % 2;
                m_FeedbackPanel.Controls.Add(feedback, col, row);
            }
            RowPanel.Controls.Add(m_FeedbackPanel);
        }

        public void Enable()
        {
            foreach (Button btn in ColorButtons)
            {
                btn.Enabled = true;
            }
        }

        public void Disable()
        {
            foreach (Button btn in ColorButtons)
            {
                btn.Enabled = false;
            }

            SubmitButton.Enabled = false;
        }

        public bool IsComplete =>
            ColorButtons.All(btn => btn.BackColor != Color.Gray);
    }
}

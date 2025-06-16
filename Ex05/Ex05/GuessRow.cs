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
            for (int i = 0; i < 4; i++)
            {
                var colorBtn = new Button
                {
                    Width = 45,
                    Height = 45,
                    BackColor = Color.Gray,
                    Margin = new Padding(5),
                    Enabled = false,
                    Tag = i
                };
                colorBtn.Click += colorClickHandler;
                ColorButtons[i] = colorBtn;
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

            // Feedback labels (color squares)
            for (int i = 0; i < 4; i++)
            {
                var feedback = new Label
                {
                    Width = 15,
                    Height = 15,
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.LightGray,
                    Margin = new Padding(3, 15,3 ,3)
                };
                FeedbackBoxes[i] = feedback;
                RowPanel.Controls.Add(feedback);
            }
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

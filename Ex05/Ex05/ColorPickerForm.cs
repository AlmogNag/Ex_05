using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Ex05
{
    public partial class ColorPickerForm : Form
    {
        public Color SelectedColor { get; private set; }

        private readonly List<Button> m_ColorButtons;

        public ColorPickerForm(List<Color> usedColors)
        {
            InitializeComponent();

            m_ColorButtons = new List<Button>
            {
                buttonBlue, buttonRed, buttonYellow, buttonGreen,
                buttonPurple, buttonCyan, buttonOrange, buttonFuchsia
            };

            disableUsedColors(usedColors);
        }

        private void disableUsedColors(List<Color> usedColors)
        {
            foreach (Button btn in m_ColorButtons)
            {
                if (usedColors.Contains(btn.BackColor))
                {
                    btn.Enabled = false;
                }
            }
        }

        private void handleColorSelection(Color selected)
        {
            SelectedColor = selected;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            handleColorSelection(Color.Blue);
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            handleColorSelection(Color.Red);
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            handleColorSelection(Color.Yellow);
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            handleColorSelection(Color.Green);
        }

        private void buttonPurple_Click(object sender, EventArgs e)
        {
            handleColorSelection(Color.Purple);
        }

        private void buttonCyan_Click(object sender, EventArgs e)
        {
            handleColorSelection(Color.Cyan);
        }

        private void buttonOrange_Click(object sender, EventArgs e)
        {
            handleColorSelection(Color.Orange);
        }

        private void buttonFuchsia_Click(object sender, EventArgs e)
        {
            handleColorSelection(Color.Fuchsia);
        }
    }
}
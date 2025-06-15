using System;
using System.Windows.Forms;

namespace Ex05
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Test with hardcoded value or launch input form
            Application.Run(new MainForm(6)); // Example: 6 guesses
        }
    }
}

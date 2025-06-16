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
            GameRun();
        }

        static void GameRun()
        {
            Application.Run(new NumberOfChancesForm()); // Example: 6 guesses
        }
    }
}

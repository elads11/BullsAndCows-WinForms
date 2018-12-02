using System;

namespace Ex05.BullsAndCows
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            GuessForm Form = new GuessForm();

            Form.ShowDialog();
        }
    }
}

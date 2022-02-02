using GrayHack.assets.scripts;
using System;

using System.Windows.Forms;

namespace GrayHack
{
    internal static class Program
    {
        public static SettingsWindows Settings = new SettingsWindows();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginMenu());
        }
    }
}

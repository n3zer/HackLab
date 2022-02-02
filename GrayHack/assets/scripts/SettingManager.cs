using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrayHack.assets.scripts
{
    public static class SettingManager
    {
       
        //full screen
        public static void GoFullScreen(this Form form) { GoFullScreen(form, false); }


        public static void GoFullScreen(this Form form, bool isFullScreen)
        {
            
            if (!isFullScreen)
            {
                Program.Settings._isFullScreen = false;
                form.WindowState = FormWindowState.Normal;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                Program.Settings._isFullScreen = true;
                form.WindowState = FormWindowState.Maximized;
                form.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        



    }
    internal class SettingsWindows
    {
        private string _settingsFileName = "setting.cfg";

        public bool _isFullScreen = false;


        private List<string> _settings = new List<string>();

        //private Dictionary<int, Action> _keys = new Dictionary<int, Action>()
        //{
        //    {0, () => _isFullScreen  = false},


        //};


        public void SaveSettings()
        {
            using (StreamWriter sw = new StreamWriter(FileManager.GameFilePath + "\\" + _settingsFileName))
            {
                sw.Write($"{_isFullScreen} \n");
                sw.Dispose();
            }
        }

        public void LoadSettings()
        {

            _settings = File.ReadLines(FileManager.GameFilePath + "\\" + _settingsFileName).ToList();
        }
    }
}

using System.Windows.Forms;

namespace GrayHack.assets.scripts
{
    public static class Extensions
    {
        private static bool _isFullScreen = false;

        public static void GoFullscreen(this LoginMenu form)
        {
            if (!_isFullScreen)
            {
                _isFullScreen = true;
                form.WindowState = FormWindowState.Normal;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                _isFullScreen = false;
                form.WindowState = FormWindowState.Maximized;
                form.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace GrayHack.assets.scripts
{
    public static class Extensions
    {

        public static ToolStripLabel SetDate(this ToolStripLabel label)
        {
            label.Text = $"{DateTime.Now.DayOfWeek} {DateTime.Now.ToString("HH:mm")}";
            return label;
        }
    }
}

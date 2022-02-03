using System;
using System.Drawing;
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

        public static Control SetRoundedShape(this Control control, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddLine(radius, 0, control.Width - radius, 0);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddLine(control.Width, radius, control.Width, control.Height - radius);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddLine(control.Width - radius, control.Height, radius, control.Height);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.AddLine(0, control.Height - radius, 0, radius);
            path.AddArc(0, 0, radius, radius, 180, 90);
            control.Region = new Region(path);

            return control;
        }
    }
}

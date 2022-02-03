using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using GrayHack.Properties;

namespace GrayHack.assets.scripts
{
    internal class IconDesktop
    {
        private Image _icon;
        public Form _programForm;

        private static int _size = 120;
        public Button button = new Button();

        public IconDesktop(Bitmap icon, Form programForm)
        {
            _programForm = programForm;
            _icon = icon;

            Typesetting();
        }

        
        private void Typesetting()
        {
            button.BackgroundImage = _icon;
            button.BackgroundImageLayout = ImageLayout.Zoom;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button.BackColor = Color.Transparent;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(63)))));
            button.Size = new Size(_size, _size);
            
            button.Click += (s, a) => { _programForm.Show(); };
            button.MouseEnter += (s, a) =>
            {
                button.FlatAppearance.BorderSize = 2;
            };
            button.MouseLeave += (s, a) => { button.FlatAppearance.BorderSize = 0; };
        }


        

        



    }
}

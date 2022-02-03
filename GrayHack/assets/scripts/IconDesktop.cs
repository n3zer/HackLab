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
            button.Size = new Size(90, 90);


            button.Click += (s, a) => { _programForm.Show(); };
        }





        public Image ConvertByteToImage(byte img)
        {
            using (var ms = new MemoryStream(img))
            {
                return Image.FromStream(ms);
            }
        }
        


    }
}

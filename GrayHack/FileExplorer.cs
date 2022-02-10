using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrayHack.assets.scripts;

namespace GrayHack
{
    public partial class FileExplorer : Form
    {
        string _path;


        // moving setting 
        const int WM_NCLBUTTONDOWN = 0x00A1;
        const int HTCAPTION = 2;

        public FileExplorer(string path)
        {
            InitializeComponent();
            _path = FileManager.pathToPlayerPc + path;
            pathLabel.Text = GetPath(path);
            closeButton.Click += (s, a) => { this.Hide(); };

        }

        // remove url trash 
        private string GetPath(string path)
        {
            return path.Replace(FileManager.pathToPlayerPc, "");
        }

        private void MovingWindow(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                toolStrip1.Capture = false;
                Message msg =
                    Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }

        
    }
}

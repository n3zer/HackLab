using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrayHack
{
    public partial class MessageGame : Form
    {
        private string _title = "Message";
        private string _text;

        public bool result = false;


        // moving setting 
        const int WM_NCLBUTTONDOWN = 0x00A1;
        const int HTCAPTION = 2;

        public MessageGame(string text)
        {
            InitializeComponent();
            _text = text;
        }

        public MessageGame(string text, string title)
        {
            InitializeComponent();
            _text=text;
            _title = title;

        }

        private void Message_Load(object sender, EventArgs e)
        {
            titleLabel.Text = _title;
            textLabel.Text = _text;

            

            closeButton.Click += (s, a) => { this.Hide(); };
            OkButton.Click += (s, a) => { result = true; this.Hide(); };
            CancelButton.Click += (s, a) => { this.Hide(); };

            
            
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

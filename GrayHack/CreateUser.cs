using System;
using GrayHack.assets.scripts;
using System.Windows.Forms;
using System.IO;
using GrayHack.Properties;

namespace GrayHack
{
    public partial class CreateUser : Form
    {
        public bool result = false;

        // moving setting 
        const int WM_NCLBUTTONDOWN = 0x00A1;
        const int HTCAPTION = 2;


        public CreateUser()
        {
            InitializeComponent();
            closeButton.Click += (s, a) => { this.Close(); };
        }

        private void MovingWindow(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                TopMenu.Capture = false;
                Message msg =
                    Message.Create(this.Handle, WM_NCLBUTTONDOWN,
                        new IntPtr(HTCAPTION), IntPtr.Zero);
                this.DefWndProc(ref msg);
            }
        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists($@"{FileManager.GameFilePath}\computers\computer"))
                ZipManager.ExtractFile($@"{FileManager.GameFilePath}\computers", "computer", Resources.computer);

            MessageBox.Show(string.Join("\n",Directory.GetDirectories($@"{FileManager.pathToPlayerPc}\home\")));

            if (!File.Exists($@"{FileManager.pathToPlayerPc}\home\{LoginTextBox.Text}.txt") && LoginTextBox.Text != "" && PasswordTextBox.Text != "")
            {
                ZipManager.ExtractFile($@"{FileManager.pathToPlayerPc}\home\{LoginTextBox.Text}",LoginTextBox.Text, Resources.user);

                using (StreamWriter fs = new StreamWriter($@"{FileManager.pathToPlayerPc}\etc\passwd"))
                {
                    fs.WriteLine(LoginTextBox.Text + ":" + PasswordTextBox.Text);
                    fs.Dispose();
                }
                this.Close();
            }
            else
            {
                MessageGame message = new MessageGame("Данные введены неправильно");
                message.ShowDialog();
            }
        }
    }
}

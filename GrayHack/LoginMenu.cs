using GrayHack.assets.scripts;
using GrayHack.Properties;
using System;
using System.Windows.Forms;
using System.IO;


namespace GrayHack
{
    public partial class LoginMenu : Form
    {
        public LoginMenu()
        {
            InitializeComponent();
            Typesetting();
        }

        private bool _isFullScreen = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Resize += (s, a) => { Typesetting(); };

            ShutdownButton.Click += (s, a) => { CloseGame(); };

            FullScreenCheckBox.Click += (s, a) => { GoFullscreen(_isFullScreen); };

            CreateUserButton.Click += (s, a) => {
                this.Enabled = false;
                CreateUser createUser = new CreateUser();
                createUser.ShowDialog();
                this.Enabled = true;
                };
        }

        private void GoFullscreen(bool fullscreen)
        {
            if (!fullscreen)
            {
                _isFullScreen = true;
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                _isFullScreen = false;
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        private void CloseGame()
        {
            MessageGame message = new MessageGame("Вы уверены что хотите выключить компьютер?", "Shutdown");
            message.ShowDialog();
            if (message.result)
            {
                message = null;
                this.Close();
            }
            
        }

        private void SigninButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists($@"{FileManager.GameFilePath}\computers\computer\home\{LoginTextBox.Text}"))
            {
                MessageBox.Show("a");
            }
        }
    }
}

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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Resize += (s, a) => { Typesetting(); };

            ShutdownButton.Click += (s, a) => { CloseGame(); };

            FullScreenCheckBox.Click += (s, a) => { this.GoFullScreen(); };

            CreateUserButton.Click += (s, a) => {
                this.Enabled = false;
                CreateUser createUser = new CreateUser();
                createUser.ShowDialog();
                this.Enabled = true;
                };

            this.FormClosed += (s, a) => { Program.Settings.SaveSettings(); };
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
            if (File.Exists($@"{FileManager.GameFilePath}\computers\computer\etc\passwd"))
            {
                using (StreamReader sr = new StreamReader($@"{FileManager.GameFilePath}\computers\computer\etc\passwd"))
                {
                    string[] UserInfo = sr.ReadLine().Split(':');
                    if (UserInfo[0] == LoginTextBox.Text && UserInfo[1].Decrypt() == PasswordTextBox.Text)
                    {
                        User user = new User(LoginTextBox.Text, $@"{FileManager.pathToPlayerPc}\home\{LoginTextBox.Text}", $@"{FileManager.GameFilePath}\computers\computer\", 0);
                        Desktop desktop = new Desktop(user);
                        desktop.Show();
                       
                        this.Enabled = false;
                        this.Hide();
                    }

                }
            }
        }

        private void ShutdownButton_Click(object sender, EventArgs e)
        {

        }
    }
}

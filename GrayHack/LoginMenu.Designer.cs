using System;
using System.Drawing;
using System.Windows.Forms;

namespace GrayHack
{
    partial class LoginMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.CreateUserButton = new System.Windows.Forms.Button();
            this.SigninButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.FullScreenCheckBox = new System.Windows.Forms.CheckBox();
            this.ShutdownButton = new System.Windows.Forms.Button();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.LoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(36)))));
            this.LoginPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginPanel.Controls.Add(this.CreateUserButton);
            this.LoginPanel.Controls.Add(this.SigninButton);
            this.LoginPanel.Controls.Add(this.passwordLabel);
            this.LoginPanel.Controls.Add(this.LoginLabel);
            this.LoginPanel.Controls.Add(this.PasswordTextBox);
            this.LoginPanel.Controls.Add(this.LoginTextBox);
            this.LoginPanel.Location = new System.Drawing.Point(514, 124);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(382, 454);
            this.LoginPanel.TabIndex = 0;
            // 
            // CreateUserButton
            // 
            this.CreateUserButton.Location = new System.Drawing.Point(307, 427);
            this.CreateUserButton.Name = "CreateUserButton";
            this.CreateUserButton.Size = new System.Drawing.Size(72, 24);
            this.CreateUserButton.TabIndex = 3;
            this.CreateUserButton.Text = "Create user";
            this.CreateUserButton.UseVisualStyleBackColor = true;
            // 
            // SigninButton
            // 
            this.SigninButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SigninButton.Location = new System.Drawing.Point(90, 282);
            this.SigninButton.Name = "SigninButton";
            this.SigninButton.Size = new System.Drawing.Size(201, 45);
            this.SigninButton.TabIndex = 2;
            this.SigninButton.Text = "Sign in";
            this.SigninButton.UseVisualStyleBackColor = true;
            this.SigninButton.Click += new System.EventHandler(this.SigninButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(114, 173);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(142, 31);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password:";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LoginLabel.ForeColor = System.Drawing.Color.White;
            this.LoginLabel.Location = new System.Drawing.Point(114, 91);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(88, 31);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "Login:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.PasswordTextBox.Location = new System.Drawing.Point(90, 209);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(201, 45);
            this.PasswordTextBox.TabIndex = 0;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.LoginTextBox.Location = new System.Drawing.Point(90, 125);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(201, 45);
            this.LoginTextBox.TabIndex = 0;
            // 
            // FullScreenCheckBox
            // 
            this.FullScreenCheckBox.AutoSize = true;
            this.FullScreenCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.FullScreenCheckBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FullScreenCheckBox.Location = new System.Drawing.Point(12, 12);
            this.FullScreenCheckBox.Name = "FullScreenCheckBox";
            this.FullScreenCheckBox.Size = new System.Drawing.Size(79, 17);
            this.FullScreenCheckBox.TabIndex = 2;
            this.FullScreenCheckBox.Text = "Full Screen";
            this.FullScreenCheckBox.UseVisualStyleBackColor = false;
            // 
            // ShutdownButton
            // 
            this.ShutdownButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShutdownButton.BackColor = System.Drawing.Color.Transparent;
            this.ShutdownButton.BackgroundImage = global::GrayHack.Properties.Resources.Shutdown;
            this.ShutdownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShutdownButton.FlatAppearance.BorderSize = 0;
            this.ShutdownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShutdownButton.Location = new System.Drawing.Point(1308, 638);
            this.ShutdownButton.Name = "ShutdownButton";
            this.ShutdownButton.Size = new System.Drawing.Size(37, 37);
            this.ShutdownButton.TabIndex = 1;
            this.ShutdownButton.TabStop = false;
            this.ShutdownButton.UseVisualStyleBackColor = false;
            // 
            // LoginMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::GrayHack.Properties.Resources.LoginMenuBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1357, 687);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.FullScreenCheckBox);
            this.Controls.Add(this.ShutdownButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LoginMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Typesetting()
        {
            LoginPanel.Location = new Point((this.ClientSize.Width - LoginPanel.Width) / 2,
                (this.ClientSize.Height - LoginPanel.Height) / 2);

            LoginTextBox.Location = new Point((LoginPanel.ClientSize.Width - LoginTextBox.Width) / 2,
                (LoginPanel.ClientSize.Height - LoginTextBox.Height) / 2 - 50);

            PasswordTextBox.Location = new Point((LoginPanel.ClientSize.Width - PasswordTextBox.Width) / 2,
                (LoginPanel.ClientSize.Height - PasswordTextBox.Height) / 2 + 50);

            LoginLabel.Location = new Point((LoginPanel.ClientSize.Width - LoginLabel.Width) / 2,
                (LoginPanel.ClientSize.Height - LoginLabel.Height) / 2 - 100);

            passwordLabel.Location = new Point((LoginPanel.ClientSize.Width - passwordLabel.Width) / 2,
                (LoginPanel.ClientSize.Height - passwordLabel.Height) / 2);

            SigninButton.Location = new Point((LoginPanel.ClientSize.Width - LoginTextBox.Width) / 2,
                (LoginPanel.ClientSize.Height - LoginTextBox.Height) / 2 + 100);

            ShutdownButton.Location = new Point(this.ClientSize.Width - ShutdownButton.Width - 10, this.ClientSize.Height - ShutdownButton.Height - 10);


            SetRoundedShape(this.LoginPanel, 15);
        }


        void SetRoundedShape(Control control, int radius)
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
        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button SigninButton;
        private System.Windows.Forms.Button ShutdownButton;
        private System.Windows.Forms.CheckBox FullScreenCheckBox;
        private System.Windows.Forms.Button CreateUserButton;
    }
}


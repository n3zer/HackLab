using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace GrayHack
{
    partial class Desktop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TopMenu = new System.Windows.Forms.ToolStrip();
            this.MenuButton = new System.Windows.Forms.ToolStripButton();
            this.dateLabel = new System.Windows.Forms.ToolStripLabel();
            this.UserProfileButton = new System.Windows.Forms.ToolStripButton();
            this.WifiButton = new System.Windows.Forms.ToolStripButton();
            this.dateTimer = new System.Windows.Forms.Timer(this.components);
            this.BottomMenu = new System.Windows.Forms.ToolStrip();
            this.DesktopFilesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DesktopContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartMenuPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ShutdownButton = new System.Windows.Forms.Button();
            this.TopMenu.SuspendLayout();
            this.DesktopContextMenuStrip.SuspendLayout();
            this.StartMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopMenu
            // 
            this.TopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuButton,
            this.dateLabel,
            this.UserProfileButton,
            this.WifiButton});
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(1130, 25);
            this.TopMenu.TabIndex = 0;
            this.TopMenu.Text = "toolStrip1";
            // 
            // MenuButton
            // 
            this.MenuButton.BackgroundImage = global::GrayHack.Properties.Resources.Menu;
            this.MenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(23, 22);
            this.MenuButton.Text = "Menu";
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(0, 22);
            // 
            // UserProfileButton
            // 
            this.UserProfileButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.UserProfileButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UserProfileButton.Image = global::GrayHack.Properties.Resources.UserProfile;
            this.UserProfileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UserProfileButton.Name = "UserProfileButton";
            this.UserProfileButton.Size = new System.Drawing.Size(83, 22);
            this.UserProfileButton.Text = "User name";
            // 
            // WifiButton
            // 
            this.WifiButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.WifiButton.BackgroundImage = global::GrayHack.Properties.Resources.wifi;
            this.WifiButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WifiButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.WifiButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.WifiButton.Name = "WifiButton";
            this.WifiButton.Size = new System.Drawing.Size(23, 22);
            this.WifiButton.Text = "wifi";
            // 
            // dateTimer
            // 
            this.dateTimer.Interval = 2000;
            // 
            // BottomMenu
            // 
            this.BottomMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.BottomMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomMenu.Location = new System.Drawing.Point(0, 570);
            this.BottomMenu.Name = "BottomMenu";
            this.BottomMenu.Size = new System.Drawing.Size(1130, 25);
            this.BottomMenu.TabIndex = 1;
            this.BottomMenu.Text = "toolStrip1";
            // 
            // DesktopFilesPanel
            // 
            this.DesktopFilesPanel.BackColor = System.Drawing.Color.Transparent;
            this.DesktopFilesPanel.ContextMenuStrip = this.DesktopContextMenuStrip;
            this.DesktopFilesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesktopFilesPanel.Location = new System.Drawing.Point(0, 25);
            this.DesktopFilesPanel.Name = "DesktopFilesPanel";
            this.DesktopFilesPanel.Size = new System.Drawing.Size(1130, 545);
            this.DesktopFilesPanel.TabIndex = 2;
            // 
            // DesktopContextMenuStrip
            // 
            this.DesktopContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.DesktopContextMenuStrip.Name = "DesktopContextMenuStrip1";
            this.DesktopContextMenuStrip.Size = new System.Drawing.Size(97, 26);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderToolStripMenuItem,
            this.txtDocToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.folderToolStripMenuItem.Text = "Folder";
            // 
            // txtDocToolStripMenuItem
            // 
            this.txtDocToolStripMenuItem.Name = "txtDocToolStripMenuItem";
            this.txtDocToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.txtDocToolStripMenuItem.Text = ".txt document";
            // 
            // StartMenuPanel
            // 
            this.StartMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.StartMenuPanel.Controls.Add(this.button2);
            this.StartMenuPanel.Controls.Add(this.button1);
            this.StartMenuPanel.Controls.Add(this.ShutdownButton);
            this.StartMenuPanel.Location = new System.Drawing.Point(0, 25);
            this.StartMenuPanel.Name = "StartMenuPanel";
            this.StartMenuPanel.Size = new System.Drawing.Size(163, 255);
            this.StartMenuPanel.TabIndex = 0;
            this.StartMenuPanel.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Properties";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "help";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ShutdownButton
            // 
            this.ShutdownButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ShutdownButton.BackColor = System.Drawing.Color.Transparent;
            this.ShutdownButton.BackgroundImage = global::GrayHack.Properties.Resources.Shutdown;
            this.ShutdownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShutdownButton.FlatAppearance.BorderSize = 0;
            this.ShutdownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShutdownButton.Location = new System.Drawing.Point(123, 215);
            this.ShutdownButton.Name = "ShutdownButton";
            this.ShutdownButton.Size = new System.Drawing.Size(37, 37);
            this.ShutdownButton.TabIndex = 2;
            this.ShutdownButton.TabStop = false;
            this.ShutdownButton.UseVisualStyleBackColor = false;
            // 
            // Desktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.BackgroundImage = global::GrayHack.Properties.Resources.HackLabBg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 595);
            this.Controls.Add(this.StartMenuPanel);
            this.Controls.Add(this.DesktopFilesPanel);
            this.Controls.Add(this.BottomMenu);
            this.Controls.Add(this.TopMenu);
            this.DoubleBuffered = true;
            this.Name = "Desktop";
            this.Text = "Desktop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Desktop_FormClosing);
            this.Load += new System.EventHandler(this.Desktop_Load);
            this.TopMenu.ResumeLayout(false);
            this.TopMenu.PerformLayout();
            this.DesktopContextMenuStrip.ResumeLayout(false);
            this.StartMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ToolStrip TopMenu;
        private System.Windows.Forms.ToolStripButton MenuButton;
        private System.Windows.Forms.ToolStripLabel dateLabel;
        private System.Windows.Forms.Timer dateTimer;
        private System.Windows.Forms.ToolStripButton UserProfileButton;
        private System.Windows.Forms.ToolStripButton WifiButton;
        private System.Windows.Forms.ToolStrip BottomMenu;
        public FlowLayoutPanel DesktopFilesPanel;
        private Panel StartMenuPanel;
        private Button ShutdownButton;
        private Button button2;
        private Button button1;
        private ContextMenuStrip DesktopContextMenuStrip;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem folderToolStripMenuItem;
        private ToolStripMenuItem txtDocToolStripMenuItem;
    }
}
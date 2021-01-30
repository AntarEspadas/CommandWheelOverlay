
namespace CommandWheelForms
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayIconStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SettingsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseButton = new System.Windows.Forms.ToolStripMenuItem();
            this.editElementsButton = new System.Windows.Forms.Button();
            this.editSettingsButton = new System.Windows.Forms.Button();
            this.trayIconStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayIconStrip;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Command Wheel";
            this.trayIcon.Visible = true;
            this.trayIcon.DoubleClick += new System.EventHandler(this.trayIcon_DoubleClick);
            // 
            // trayIconStrip
            // 
            this.trayIconStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.trayIconStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsButton,
            this.toolStripSeparator1,
            this.CloseButton});
            this.trayIconStrip.Name = "trayIconStrip";
            this.trayIconStrip.Size = new System.Drawing.Size(132, 58);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(131, 24);
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.Click += new System.EventHandler(this.Settings_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(128, 6);
            // 
            // CloseButton
            // 
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(131, 24);
            this.CloseButton.Text = "Close";
            this.CloseButton.Click += new System.EventHandler(this.Close_Click);
            // 
            // editElementsButton
            // 
            this.editElementsButton.Location = new System.Drawing.Point(12, 12);
            this.editElementsButton.Name = "editElementsButton";
            this.editElementsButton.Size = new System.Drawing.Size(271, 41);
            this.editElementsButton.TabIndex = 1;
            this.editElementsButton.Text = "Edit Elements";
            this.editElementsButton.UseVisualStyleBackColor = true;
            this.editElementsButton.Click += new System.EventHandler(this.editElementsButton_Click);
            // 
            // editSettingsButton
            // 
            this.editSettingsButton.Location = new System.Drawing.Point(12, 59);
            this.editSettingsButton.Name = "editSettingsButton";
            this.editSettingsButton.Size = new System.Drawing.Size(271, 42);
            this.editSettingsButton.TabIndex = 2;
            this.editSettingsButton.Text = "Edit Settings";
            this.editSettingsButton.UseVisualStyleBackColor = true;
            this.editSettingsButton.Click += new System.EventHandler(this.editSettingsButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 485);
            this.Controls.Add(this.editSettingsButton);
            this.Controls.Add(this.editElementsButton);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.trayIconStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayIconStrip;
        private System.Windows.Forms.ToolStripMenuItem SettingsButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem CloseButton;
        private System.Windows.Forms.Button editElementsButton;
        private System.Windows.Forms.Button editSettingsButton;
    }
}
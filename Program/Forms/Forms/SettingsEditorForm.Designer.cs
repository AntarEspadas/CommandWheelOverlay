
namespace CommandWheelForms.Forms
{
    partial class SettingsEditorForm
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.showHotkeyLabel = new System.Windows.Forms.Label();
            this.showHotkeyTextbox = new System.Windows.Forms.TextBox();
            this.ShowHotkeyButton = new System.Windows.Forms.Button();
            this.buttonLayout1 = new CommandWheelForms.Controls.ButtonLayout();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(34, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(309, 17);
            this.infoLabel.TabIndex = 1;
            this.infoLabel.Text = "Key binds will not work while this window is open";
            // 
            // showHotkeyLabel
            // 
            this.showHotkeyLabel.AutoSize = true;
            this.showHotkeyLabel.Location = new System.Drawing.Point(12, 51);
            this.showHotkeyLabel.Name = "showHotkeyLabel";
            this.showHotkeyLabel.Size = new System.Drawing.Size(92, 17);
            this.showHotkeyLabel.TabIndex = 2;
            this.showHotkeyLabel.Text = "Show overlay";
            // 
            // showHotkeyTextbox
            // 
            this.showHotkeyTextbox.Location = new System.Drawing.Point(15, 71);
            this.showHotkeyTextbox.Name = "showHotkeyTextbox";
            this.showHotkeyTextbox.ReadOnly = true;
            this.showHotkeyTextbox.Size = new System.Drawing.Size(197, 22);
            this.showHotkeyTextbox.TabIndex = 3;
            // 
            // ShowHotkeyButton
            // 
            this.ShowHotkeyButton.Location = new System.Drawing.Point(228, 67);
            this.ShowHotkeyButton.Name = "ShowHotkeyButton";
            this.ShowHotkeyButton.Size = new System.Drawing.Size(75, 30);
            this.ShowHotkeyButton.TabIndex = 4;
            this.ShowHotkeyButton.Text = "Record";
            this.ShowHotkeyButton.UseVisualStyleBackColor = true;
            this.ShowHotkeyButton.Click += new System.EventHandler(this.ShowKeybindButton_Click);
            // 
            // buttonLayout1
            // 
            this.buttonLayout1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLayout1.Location = new System.Drawing.Point(0, 339);
            this.buttonLayout1.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLayout1.Name = "buttonLayout1";
            this.buttonLayout1.Size = new System.Drawing.Size(390, 40);
            this.buttonLayout1.TabIndex = 0;
            // 
            // SettingsEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 379);
            this.Controls.Add(this.ShowHotkeyButton);
            this.Controls.Add(this.showHotkeyTextbox);
            this.Controls.Add(this.showHotkeyLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.buttonLayout1);
            this.Name = "SettingsEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SettingsEditorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ButtonLayout buttonLayout1;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label showHotkeyLabel;
        private System.Windows.Forms.TextBox showHotkeyTextbox;
        private System.Windows.Forms.Button ShowHotkeyButton;
    }
}
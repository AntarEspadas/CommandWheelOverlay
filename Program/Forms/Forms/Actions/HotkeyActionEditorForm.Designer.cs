
namespace CommandWheelForms.Forms.Actions
{
    partial class HotkeyActionEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotkeyActionEditorForm));
            this.hotkeyTextBox = new System.Windows.Forms.TextBox();
            this.buttonLayout1 = new CommandWheelForms.Controls.ButtonLayout();
            this.hotkeyLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // hotkeyTextBox
            // 
            this.hotkeyTextBox.Location = new System.Drawing.Point(15, 103);
            this.hotkeyTextBox.Name = "hotkeyTextBox";
            this.hotkeyTextBox.Size = new System.Drawing.Size(330, 22);
            this.hotkeyTextBox.TabIndex = 2;
            // 
            // buttonLayout1
            // 
            this.buttonLayout1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLayout1.Location = new System.Drawing.Point(0, 143);
            this.buttonLayout1.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLayout1.Name = "buttonLayout1";
            this.buttonLayout1.Size = new System.Drawing.Size(357, 40);
            this.buttonLayout1.TabIndex = 3;
            // 
            // hotkeyLinkLabel
            // 
            this.hotkeyLinkLabel.AutoSize = true;
            this.hotkeyLinkLabel.LinkArea = new System.Windows.Forms.LinkArea(117, 15);
            this.hotkeyLinkLabel.Location = new System.Drawing.Point(12, 9);
            this.hotkeyLinkLabel.Name = "hotkeyLinkLabel";
            this.hotkeyLinkLabel.Size = new System.Drawing.Size(293, 79);
            this.hotkeyLinkLabel.TabIndex = 4;
            this.hotkeyLinkLabel.TabStop = true;
            this.hotkeyLinkLabel.Text = "Enter a space separated list of keys. Examples:\r\nCtrl Z\r\nAlt Tab\r\nCtrl Shift Esc\r" +
    "\nFor a full list of keys, visit the Autohotkey docs\r\n";
            this.hotkeyLinkLabel.UseCompatibleTextRendering = true;
            this.hotkeyLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HotkeyLinkLabel_LinkClicked);
            // 
            // HotkeyActionEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 183);
            this.Controls.Add(this.hotkeyLinkLabel);
            this.Controls.Add(this.buttonLayout1);
            this.Controls.Add(this.hotkeyTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HotkeyActionEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HotkeyActionEditorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox hotkeyTextBox;
        private Controls.ButtonLayout buttonLayout1;
        private System.Windows.Forms.LinkLabel hotkeyLinkLabel;
    }
}
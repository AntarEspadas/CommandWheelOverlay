
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
            this.hotkeyLabel = new System.Windows.Forms.Label();
            this.autohotkeyLinkLabel = new System.Windows.Forms.LinkLabel();
            this.hotkeyTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // hotkeyLabel
            // 
            this.hotkeyLabel.AutoSize = true;
            this.hotkeyLabel.Location = new System.Drawing.Point(12, 9);
            this.hotkeyLabel.Name = "hotkeyLabel";
            this.hotkeyLabel.Size = new System.Drawing.Size(306, 85);
            this.hotkeyLabel.TabIndex = 0;
            this.hotkeyLabel.Text = "Enter a space separated list of keys. Examples:\r\nCtrl Z\r\nAlt Tab\r\nCtrl Shift Esc\r" +
    "\nFor a full list of keys, visit the Autohotkey docs";
            // 
            // autohotkeyLinkLabel
            // 
            this.autohotkeyLinkLabel.AutoSize = true;
            this.autohotkeyLinkLabel.Location = new System.Drawing.Point(12, 94);
            this.autohotkeyLinkLabel.Name = "autohotkeyLinkLabel";
            this.autohotkeyLinkLabel.Size = new System.Drawing.Size(293, 17);
            this.autohotkeyLinkLabel.TabIndex = 1;
            this.autohotkeyLinkLabel.TabStop = true;
            this.autohotkeyLinkLabel.Text = "https://www.autohotkey.com/docs/KeyList.htm";
            // 
            // hotkeyTextBox
            // 
            this.hotkeyTextBox.Location = new System.Drawing.Point(15, 129);
            this.hotkeyTextBox.Name = "hotkeyTextBox";
            this.hotkeyTextBox.Size = new System.Drawing.Size(330, 22);
            this.hotkeyTextBox.TabIndex = 2;
            // 
            // HotkeyActionEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 173);
            this.Controls.Add(this.hotkeyTextBox);
            this.Controls.Add(this.autohotkeyLinkLabel);
            this.Controls.Add(this.hotkeyLabel);
            this.Name = "HotkeyActionEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HotkeyActionEditorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hotkeyLabel;
        private System.Windows.Forms.LinkLabel autohotkeyLinkLabel;
        private System.Windows.Forms.TextBox hotkeyTextBox;
    }
}
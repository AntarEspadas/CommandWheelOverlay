
namespace CommandWheelForms.Forms.Actions
{
    partial class OpenWebsiteActionEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenWebsiteActionEditorForm));
            this.buttonLayout = new CommandWheelForms.Controls.ButtonLayout();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.urlErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLayout
            // 
            this.buttonLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLayout.Location = new System.Drawing.Point(0, 62);
            this.buttonLayout.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLayout.Name = "buttonLayout";
            this.buttonLayout.Size = new System.Drawing.Size(341, 40);
            this.buttonLayout.TabIndex = 0;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(12, 29);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(317, 22);
            this.urlTextBox.TabIndex = 1;
            this.urlTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.UrlTextBox_Validating);
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(12, 9);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(36, 17);
            this.urlLabel.TabIndex = 2;
            this.urlLabel.Text = "URL";
            // 
            // urlErrorLabel
            // 
            this.urlErrorLabel.AutoSize = true;
            this.urlErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.urlErrorLabel.Location = new System.Drawing.Point(64, 9);
            this.urlErrorLabel.Name = "urlErrorLabel";
            this.urlErrorLabel.Size = new System.Drawing.Size(226, 17);
            this.urlErrorLabel.TabIndex = 3;
            this.urlErrorLabel.Text = "That url does not seem to bel valid";
            this.urlErrorLabel.Visible = false;
            // 
            // OpenWebsiteActionEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 102);
            this.Controls.Add(this.urlErrorLabel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.buttonLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OpenWebsiteActionEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Action";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OpenWebsiteActionEditorForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ButtonLayout buttonLayout;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label urlErrorLabel;
    }
}
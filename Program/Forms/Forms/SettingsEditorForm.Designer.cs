
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
            this.buttonLayout1 = new CommandWheelForms.Controls.ButtonLayout();
            this.SuspendLayout();
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
            this.Controls.Add(this.buttonLayout1);
            this.Name = "SettingsEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SettingsEditorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ButtonLayout buttonLayout1;
    }
}
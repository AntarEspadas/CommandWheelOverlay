
namespace CommandWheelForms.Forms.Actions
{
    partial class ShowSubwheelActionEditorForm
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
            this.basicLayout1 = new CommandWheelForms.Controls.BasicLayout();
            this.SuspendLayout();
            // 
            // basicLayout1
            // 
            this.basicLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basicLayout1.Location = new System.Drawing.Point(0, 0);
            this.basicLayout1.Margin = new System.Windows.Forms.Padding(0);
            this.basicLayout1.Name = "basicLayout1";
            this.basicLayout1.Size = new System.Drawing.Size(336, 183);
            this.basicLayout1.TabIndex = 0;
            // 
            // ShowSubwheelActionEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 183);
            this.Controls.Add(this.basicLayout1);
            this.Name = "ShowSubwheelActionEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ShowSubwheelActionEditorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.BasicLayout basicLayout1;
    }
}
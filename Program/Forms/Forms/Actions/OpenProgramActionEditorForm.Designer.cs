
namespace CommandWheelForms.Forms.Actions
{
    partial class OpenProgramActionEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenProgramActionEditorForm));
            this.buttonLayout1 = new CommandWheelForms.Controls.ButtonLayout();
            this.pathLabel = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.argsLabel = new System.Windows.Forms.Label();
            this.argsTextBox = new System.Windows.Forms.TextBox();
            this.pathBrowseButton = new System.Windows.Forms.Button();
            this.pathOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonLayout1
            // 
            this.buttonLayout1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLayout1.Location = new System.Drawing.Point(0, 123);
            this.buttonLayout1.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLayout1.Name = "buttonLayout1";
            this.buttonLayout1.Size = new System.Drawing.Size(396, 40);
            this.buttonLayout1.TabIndex = 0;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(12, 9);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(94, 17);
            this.pathLabel.TabIndex = 1;
            this.pathLabel.Text = "Program path";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(15, 29);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(259, 22);
            this.pathTextBox.TabIndex = 2;
            // 
            // argsLabel
            // 
            this.argsLabel.AutoSize = true;
            this.argsLabel.Location = new System.Drawing.Point(12, 54);
            this.argsLabel.Name = "argsLabel";
            this.argsLabel.Size = new System.Drawing.Size(76, 17);
            this.argsLabel.TabIndex = 3;
            this.argsLabel.Text = "Arguments";
            // 
            // argsTextBox
            // 
            this.argsTextBox.Location = new System.Drawing.Point(15, 74);
            this.argsTextBox.Name = "argsTextBox";
            this.argsTextBox.Size = new System.Drawing.Size(259, 22);
            this.argsTextBox.TabIndex = 4;
            // 
            // pathBrowseButton
            // 
            this.pathBrowseButton.Location = new System.Drawing.Point(299, 27);
            this.pathBrowseButton.Name = "pathBrowseButton";
            this.pathBrowseButton.Size = new System.Drawing.Size(75, 26);
            this.pathBrowseButton.TabIndex = 5;
            this.pathBrowseButton.Text = "Browse";
            this.pathBrowseButton.UseVisualStyleBackColor = true;
            this.pathBrowseButton.Click += new System.EventHandler(this.PathBrowseButton_Click);
            // 
            // pathOpenFileDialog
            // 
            this.pathOpenFileDialog.Filter = "Executable files (*.exe;*.bat)|*.exe;*.bat|All files (*.*)|*.*";
            // 
            // OpenProgramActionEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 163);
            this.Controls.Add(this.pathBrowseButton);
            this.Controls.Add(this.argsTextBox);
            this.Controls.Add(this.argsLabel);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.buttonLayout1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OpenProgramActionEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OpenProgramActionEditorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ButtonLayout buttonLayout1;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label argsLabel;
        private System.Windows.Forms.TextBox argsTextBox;
        private System.Windows.Forms.Button pathBrowseButton;
        private System.Windows.Forms.OpenFileDialog pathOpenFileDialog;
    }
}
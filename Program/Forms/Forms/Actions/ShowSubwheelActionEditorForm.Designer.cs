
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowSubwheelActionEditorForm));
            this.subWheelLabel = new System.Windows.Forms.Label();
            this.subWheelComboBox = new System.Windows.Forms.ComboBox();
            this.subWheelEditButton = new System.Windows.Forms.Button();
            this.basicLayout1 = new CommandWheelForms.Controls.ButtonLayout();
            this.SuspendLayout();
            // 
            // subWheelLabel
            // 
            this.subWheelLabel.AutoSize = true;
            this.subWheelLabel.Location = new System.Drawing.Point(12, 9);
            this.subWheelLabel.Name = "subWheelLabel";
            this.subWheelLabel.Size = new System.Drawing.Size(77, 17);
            this.subWheelLabel.TabIndex = 1;
            this.subWheelLabel.Text = "Sub Wheel";
            // 
            // subWheelComboBox
            // 
            this.subWheelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subWheelComboBox.FormattingEnabled = true;
            this.subWheelComboBox.Location = new System.Drawing.Point(12, 29);
            this.subWheelComboBox.Name = "subWheelComboBox";
            this.subWheelComboBox.Size = new System.Drawing.Size(171, 24);
            this.subWheelComboBox.TabIndex = 2;
            this.subWheelComboBox.SelectedIndexChanged += new System.EventHandler(this.subWheelComboBox_SelectedIndexChanged);
            // 
            // subWheelEditButton
            // 
            this.subWheelEditButton.Location = new System.Drawing.Point(214, 27);
            this.subWheelEditButton.Name = "subWheelEditButton";
            this.subWheelEditButton.Size = new System.Drawing.Size(75, 26);
            this.subWheelEditButton.TabIndex = 3;
            this.subWheelEditButton.Text = "Edit";
            this.subWheelEditButton.UseVisualStyleBackColor = true;
            this.subWheelEditButton.Click += new System.EventHandler(this.subWheelEditButton_Click);
            // 
            // basicLayout1
            // 
            this.basicLayout1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.basicLayout1.Location = new System.Drawing.Point(0, 89);
            this.basicLayout1.Margin = new System.Windows.Forms.Padding(0);
            this.basicLayout1.Name = "basicLayout1";
            this.basicLayout1.Size = new System.Drawing.Size(336, 40);
            this.basicLayout1.TabIndex = 0;
            // 
            // ShowSubwheelActionEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 129);
            this.Controls.Add(this.subWheelEditButton);
            this.Controls.Add(this.subWheelComboBox);
            this.Controls.Add(this.subWheelLabel);
            this.Controls.Add(this.basicLayout1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowSubwheelActionEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ShowSubwheelActionEditorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ButtonLayout basicLayout1;
        private System.Windows.Forms.Label subWheelLabel;
        private System.Windows.Forms.ComboBox subWheelComboBox;
        private System.Windows.Forms.Button subWheelEditButton;
    }
}
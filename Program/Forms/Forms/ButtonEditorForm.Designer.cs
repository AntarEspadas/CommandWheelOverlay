
namespace CommandWheelForms.Forms
{
    partial class ButtonEditorForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.editActionButton = new System.Windows.Forms.Button();
            this.actionLabel = new System.Windows.Forms.Label();
            this.actionComboBox = new System.Windows.Forms.ComboBox();
            this.imageBrowseButton = new System.Windows.Forms.Button();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.imageLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.imageOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.okButton.Location = new System.Drawing.Point(85, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(74, 28);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Location = new System.Drawing.Point(330, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(74, 28);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.mainPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(496, 301);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.okButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cancelButton, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 264);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(490, 34);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.editActionButton);
            this.mainPanel.Controls.Add(this.actionLabel);
            this.mainPanel.Controls.Add(this.actionComboBox);
            this.mainPanel.Controls.Add(this.imageBrowseButton);
            this.mainPanel.Controls.Add(this.imageTextBox);
            this.mainPanel.Controls.Add(this.imageLabel);
            this.mainPanel.Controls.Add(this.nameTextBox);
            this.mainPanel.Controls.Add(this.nameLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(3, 3);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(490, 255);
            this.mainPanel.TabIndex = 1;
            // 
            // editActionButton
            // 
            this.editActionButton.Location = new System.Drawing.Point(282, 114);
            this.editActionButton.Name = "editActionButton";
            this.editActionButton.Size = new System.Drawing.Size(75, 26);
            this.editActionButton.TabIndex = 7;
            this.editActionButton.Text = "Edit";
            this.editActionButton.UseVisualStyleBackColor = true;
            this.editActionButton.Click += new System.EventHandler(this.editActionButton_Click);
            // 
            // actionLabel
            // 
            this.actionLabel.AutoSize = true;
            this.actionLabel.Location = new System.Drawing.Point(9, 96);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(47, 17);
            this.actionLabel.TabIndex = 6;
            this.actionLabel.Text = "Action";
            // 
            // actionComboBox
            // 
            this.actionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actionComboBox.FormattingEnabled = true;
            this.actionComboBox.Location = new System.Drawing.Point(12, 116);
            this.actionComboBox.Name = "actionComboBox";
            this.actionComboBox.Size = new System.Drawing.Size(240, 24);
            this.actionComboBox.TabIndex = 5;
            this.actionComboBox.SelectedValueChanged += new System.EventHandler(this.actionComboBox_SelectedValueChanged);
            // 
            // imageBrowseButton
            // 
            this.imageBrowseButton.Location = new System.Drawing.Point(282, 69);
            this.imageBrowseButton.Name = "imageBrowseButton";
            this.imageBrowseButton.Size = new System.Drawing.Size(75, 26);
            this.imageBrowseButton.TabIndex = 4;
            this.imageBrowseButton.Text = "Browse";
            this.imageBrowseButton.UseVisualStyleBackColor = true;
            this.imageBrowseButton.Click += new System.EventHandler(this.imageBrowseButton_Click);
            // 
            // imageTextBox
            // 
            this.imageTextBox.Location = new System.Drawing.Point(12, 71);
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(240, 22);
            this.imageTextBox.TabIndex = 3;
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.Location = new System.Drawing.Point(9, 51);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(46, 17);
            this.imageLabel.TabIndex = 2;
            this.imageLabel.Text = "Image";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 26);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(171, 22);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(9, 6);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // imageOpenFileDialog
            // 
            this.imageOpenFileDialog.Filter = "Image files|*.png;*.jpg;*jpeg|All files|*.*";
            // 
            // ButtonEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 301);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ButtonEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ButtonEditorForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button imageBrowseButton;
        private System.Windows.Forms.TextBox imageTextBox;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.OpenFileDialog imageOpenFileDialog;
        private System.Windows.Forms.Label actionLabel;
        private System.Windows.Forms.ComboBox actionComboBox;
        private System.Windows.Forms.Button editActionButton;
    }
}
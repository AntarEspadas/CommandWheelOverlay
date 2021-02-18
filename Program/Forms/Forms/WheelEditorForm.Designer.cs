
namespace CommandWheelForms.Forms
{
    partial class WheelEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WheelEditorForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bgColorAlphaLabel = new System.Windows.Forms.Label();
            this.bgColorAlphaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.startupWheelCheckbox = new System.Windows.Forms.CheckBox();
            this.addButtonButton = new System.Windows.Forms.Button();
            this.accentColorLabel = new System.Windows.Forms.Label();
            this.bgColorLabel = new System.Windows.Forms.Label();
            this.accentColorPanel = new System.Windows.Forms.Panel();
            this.bgColorPanel = new System.Windows.Forms.Panel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.buttonsLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.colorPicker = new System.Windows.Forms.ColorDialog();
            this.basicLayout1 = new CommandWheelForms.Controls.ButtonLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bgColorAlphaNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonsLayoutPanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(468, 413);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bgColorAlphaLabel);
            this.panel1.Controls.Add(this.bgColorAlphaNumericUpDown);
            this.panel1.Controls.Add(this.startupWheelCheckbox);
            this.panel1.Controls.Add(this.addButtonButton);
            this.panel1.Controls.Add(this.accentColorLabel);
            this.panel1.Controls.Add(this.bgColorLabel);
            this.panel1.Controls.Add(this.accentColorPanel);
            this.panel1.Controls.Add(this.bgColorPanel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 154);
            this.panel1.TabIndex = 0;
            // 
            // bgColorAlphaLabel
            // 
            this.bgColorAlphaLabel.AutoSize = true;
            this.bgColorAlphaLabel.Location = new System.Drawing.Point(139, 73);
            this.bgColorAlphaLabel.Name = "bgColorAlphaLabel";
            this.bgColorAlphaLabel.Size = new System.Drawing.Size(56, 17);
            this.bgColorAlphaLabel.TabIndex = 8;
            this.bgColorAlphaLabel.Text = "Opacity";
            // 
            // bgColorAlphaNumericUpDown
            // 
            this.bgColorAlphaNumericUpDown.Location = new System.Drawing.Point(76, 71);
            this.bgColorAlphaNumericUpDown.Name = "bgColorAlphaNumericUpDown";
            this.bgColorAlphaNumericUpDown.Size = new System.Drawing.Size(57, 22);
            this.bgColorAlphaNumericUpDown.TabIndex = 7;
            this.bgColorAlphaNumericUpDown.ValueChanged += new System.EventHandler(this.BgColorAlphaNumericUpDown_ValueChanged);
            // 
            // startupWheelCheckbox
            // 
            this.startupWheelCheckbox.AutoSize = true;
            this.startupWheelCheckbox.Location = new System.Drawing.Point(247, 112);
            this.startupWheelCheckbox.Name = "startupWheelCheckbox";
            this.startupWheelCheckbox.Size = new System.Drawing.Size(141, 21);
            this.startupWheelCheckbox.TabIndex = 6;
            this.startupWheelCheckbox.Text = "Use as first wheel";
            this.startupWheelCheckbox.UseVisualStyleBackColor = true;
            // 
            // addButtonButton
            // 
            this.addButtonButton.Location = new System.Drawing.Point(9, 112);
            this.addButtonButton.Name = "addButtonButton";
            this.addButtonButton.Size = new System.Drawing.Size(75, 29);
            this.addButtonButton.TabIndex = 5;
            this.addButtonButton.Text = "Add Button";
            this.addButtonButton.UseVisualStyleBackColor = true;
            this.addButtonButton.Click += new System.EventHandler(this.addButtonButton_Click);
            // 
            // accentColorLabel
            // 
            this.accentColorLabel.AutoSize = true;
            this.accentColorLabel.Location = new System.Drawing.Point(244, 51);
            this.accentColorLabel.Name = "accentColorLabel";
            this.accentColorLabel.Size = new System.Drawing.Size(75, 17);
            this.accentColorLabel.TabIndex = 4;
            this.accentColorLabel.Text = "Main Color";
            // 
            // bgColorLabel
            // 
            this.bgColorLabel.AutoSize = true;
            this.bgColorLabel.Location = new System.Drawing.Point(9, 51);
            this.bgColorLabel.Name = "bgColorLabel";
            this.bgColorLabel.Size = new System.Drawing.Size(121, 17);
            this.bgColorLabel.TabIndex = 3;
            this.bgColorLabel.Text = "Background Color";
            // 
            // accentColorPanel
            // 
            this.accentColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.accentColorPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accentColorPanel.Location = new System.Drawing.Point(247, 71);
            this.accentColorPanel.Name = "accentColorPanel";
            this.accentColorPanel.Size = new System.Drawing.Size(42, 22);
            this.accentColorPanel.TabIndex = 2;
            this.accentColorPanel.Click += new System.EventHandler(this.AccentColorPanel_Click);
            // 
            // bgColorPanel
            // 
            this.bgColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bgColorPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bgColorPanel.Location = new System.Drawing.Point(12, 71);
            this.bgColorPanel.Name = "bgColorPanel";
            this.bgColorPanel.Size = new System.Drawing.Size(42, 22);
            this.bgColorPanel.TabIndex = 2;
            this.bgColorPanel.Click += new System.EventHandler(this.BgColorPanel_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 26);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(224, 22);
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
            // buttonsLayoutPanel
            // 
            this.buttonsLayoutPanel.AutoScroll = true;
            this.buttonsLayoutPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsLayoutPanel.Location = new System.Drawing.Point(3, 163);
            this.buttonsLayoutPanel.Name = "buttonsLayoutPanel";
            this.buttonsLayoutPanel.Size = new System.Drawing.Size(462, 247);
            this.buttonsLayoutPanel.TabIndex = 1;
            // 
            // basicLayout1
            // 
            this.basicLayout1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.basicLayout1.Location = new System.Drawing.Point(0, 413);
            this.basicLayout1.Margin = new System.Windows.Forms.Padding(0);
            this.basicLayout1.Name = "basicLayout1";
            this.basicLayout1.Size = new System.Drawing.Size(468, 40);
            this.basicLayout1.TabIndex = 0;
            // 
            // WheelEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 453);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.basicLayout1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WheelEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WheelEditorForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bgColorAlphaNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ButtonLayout basicLayout1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label accentColorLabel;
        private System.Windows.Forms.Label bgColorLabel;
        private System.Windows.Forms.Panel bgColorPanel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ColorDialog colorPicker;
        private System.Windows.Forms.Panel accentColorPanel;
        private System.Windows.Forms.Button addButtonButton;
        private System.Windows.Forms.FlowLayoutPanel buttonsLayoutPanel;
        private System.Windows.Forms.CheckBox startupWheelCheckbox;
        private System.Windows.Forms.Label bgColorAlphaLabel;
        private System.Windows.Forms.NumericUpDown bgColorAlphaNumericUpDown;
    }
}
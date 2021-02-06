
namespace CommandWheelForms.Controlls
{
    partial class ElementListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.downButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 5;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainPanel.Controls.Add(this.deleteButton, 4, 0);
            this.mainPanel.Controls.Add(this.editButton, 3, 0);
            this.mainPanel.Controls.Add(this.label1, 0, 0);
            this.mainPanel.Controls.Add(this.downButton, 2, 0);
            this.mainPanel.Controls.Add(this.upButton, 1, 0);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 1;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Size = new System.Drawing.Size(401, 40);
            this.mainPanel.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.Location = new System.Drawing.Point(364, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(34, 34);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "X";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editButton.Location = new System.Drawing.Point(314, 3);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(44, 34);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "label";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // downButton
            // 
            this.downButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downButton.Location = new System.Drawing.Point(279, 3);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(29, 34);
            this.downButton.TabIndex = 3;
            this.downButton.Text = "🡇";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // upButton
            // 
            this.upButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upButton.Location = new System.Drawing.Point(244, 3);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(29, 34);
            this.upButton.TabIndex = 0;
            this.upButton.Text = "🡅";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // ElementListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Name = "ElementListItem";
            this.Size = new System.Drawing.Size(401, 40);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        public System.Windows.Forms.Button deleteButton;
        public System.Windows.Forms.Button editButton;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button upButton;
    }
}

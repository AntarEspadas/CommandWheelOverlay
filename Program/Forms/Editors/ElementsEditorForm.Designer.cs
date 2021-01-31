
namespace CommandWheelForms.Editors
{
    partial class ElementsEditorForm
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
            this.wheelsListView = new System.Windows.Forms.ListView();
            this.buttonsListView = new System.Windows.Forms.ListView();
            this.addWheelButton = new System.Windows.Forms.Button();
            this.addButtonButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wheelsListView
            // 
            this.wheelsListView.HideSelection = false;
            this.wheelsListView.Location = new System.Drawing.Point(12, 73);
            this.wheelsListView.Name = "wheelsListView";
            this.wheelsListView.Size = new System.Drawing.Size(197, 456);
            this.wheelsListView.TabIndex = 0;
            this.wheelsListView.UseCompatibleStateImageBehavior = false;
            // 
            // buttonsListView
            // 
            this.buttonsListView.HideSelection = false;
            this.buttonsListView.Location = new System.Drawing.Point(234, 73);
            this.buttonsListView.Name = "buttonsListView";
            this.buttonsListView.Size = new System.Drawing.Size(200, 456);
            this.buttonsListView.TabIndex = 0;
            this.buttonsListView.UseCompatibleStateImageBehavior = false;
            // 
            // addWheelButton
            // 
            this.addWheelButton.Location = new System.Drawing.Point(12, 33);
            this.addWheelButton.Name = "addWheelButton";
            this.addWheelButton.Size = new System.Drawing.Size(197, 34);
            this.addWheelButton.TabIndex = 1;
            this.addWheelButton.Text = "Add Wheel";
            this.addWheelButton.UseVisualStyleBackColor = true;
            // 
            // addButtonButton
            // 
            this.addButtonButton.Location = new System.Drawing.Point(234, 33);
            this.addButtonButton.Name = "addButtonButton";
            this.addButtonButton.Size = new System.Drawing.Size(197, 34);
            this.addButtonButton.TabIndex = 1;
            this.addButtonButton.Text = "Add Button";
            this.addButtonButton.UseVisualStyleBackColor = true;
            // 
            // ElementsEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 541);
            this.Controls.Add(this.addButtonButton);
            this.Controls.Add(this.addWheelButton);
            this.Controls.Add(this.buttonsListView);
            this.Controls.Add(this.wheelsListView);
            this.Name = "ElementsEditorForm";
            this.Text = "ElementsEditorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView wheelsListView;
        private System.Windows.Forms.ListView buttonsListView;
        private System.Windows.Forms.Button addWheelButton;
        private System.Windows.Forms.Button addButtonButton;
    }
}
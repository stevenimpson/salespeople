namespace Salespeople
{
    partial class AddEmployeeForm
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
            this.newNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newNameBox
            // 
            this.newNameBox.AcceptsTab = true;
            this.newNameBox.Location = new System.Drawing.Point(109, 17);
            this.newNameBox.Name = "newNameBox";
            this.newNameBox.Size = new System.Drawing.Size(243, 20);
            this.newNameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(110, 43);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 23);
            this.confirm.TabIndex = 2;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(192, 43);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 75);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newNameBox);
            this.Name = "AddEmployeeForm";
            this.Text = "New Employee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEmployeeForm_FormClosing);
            this.Load += new System.EventHandler(this.AddEmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button Cancel;
    }
}
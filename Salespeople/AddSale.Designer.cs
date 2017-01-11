namespace Salespeople
{
    partial class AddSale
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
            this.saleLabel = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saleLabel
            // 
            this.saleLabel.AutoSize = true;
            this.saleLabel.Location = new System.Drawing.Point(12, 13);
            this.saleLabel.Name = "saleLabel";
            this.saleLabel.Size = new System.Drawing.Size(82, 13);
            this.saleLabel.TabIndex = 0;
            this.saleLabel.Text = "Sale Amount ($)";
            // 
            // amountBox
            // 
            this.amountBox.Location = new System.Drawing.Point(100, 10);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(172, 20);
            this.amountBox.TabIndex = 1;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(197, 37);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 2;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(12, 37);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 68);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.saleLabel);
            this.Name = "AddSale";
            this.Text = "Add Sale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saleLabel;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
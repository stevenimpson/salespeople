namespace Salespeople
{
    partial class Form1
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
            this.PeopleListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpPagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.mobBox = new System.Windows.Forms.TextBox();
            this.homphBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.mobLabel = new System.Windows.Forms.Label();
            this.homphLabel = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.areaBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.salesBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.newSaleButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.returnToList = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.areaSearch = new System.Windows.Forms.Button();
            this.areaSearchBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.millionButton = new System.Windows.Forms.Button();
            this.employeeReportButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PeopleListBox
            // 
            this.PeopleListBox.FormattingEnabled = true;
            this.PeopleListBox.Location = new System.Drawing.Point(12, 44);
            this.PeopleListBox.Name = "PeopleListBox";
            this.PeopleListBox.Size = new System.Drawing.Size(320, 355);
            this.PeopleListBox.TabIndex = 0;
            this.PeopleListBox.SelectedIndexChanged += new System.EventHandler(this.PeopleList_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(674, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpPagesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpPagesToolStripMenuItem
            // 
            this.helpPagesToolStripMenuItem.Name = "helpPagesToolStripMenuItem";
            this.helpPagesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.helpPagesToolStripMenuItem.Text = "Help pages...";
            this.helpPagesToolStripMenuItem.Click += new System.EventHandler(this.helpPagesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Salespeople";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(53, 572);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(161, 20);
            this.searchBox.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 405);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(320, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add New Employee";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.AcceptsTab = true;
            this.nameBox.Location = new System.Drawing.Point(420, 44);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(240, 20);
            this.nameBox.TabIndex = 6;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(420, 70);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(240, 20);
            this.idBox.TabIndex = 6;
            // 
            // mobBox
            // 
            this.mobBox.Location = new System.Drawing.Point(420, 96);
            this.mobBox.Name = "mobBox";
            this.mobBox.Size = new System.Drawing.Size(240, 20);
            this.mobBox.TabIndex = 6;
            // 
            // homphBox
            // 
            this.homphBox.Location = new System.Drawing.Point(420, 122);
            this.homphBox.Name = "homphBox";
            this.homphBox.Size = new System.Drawing.Size(240, 20);
            this.homphBox.TabIndex = 6;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(420, 148);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(240, 20);
            this.emailBox.TabIndex = 6;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(420, 174);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(240, 20);
            this.addressBox.TabIndex = 6;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(338, 47);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(338, 73);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 7;
            this.idLabel.Text = "ID";
            this.idLabel.Click += new System.EventHandler(this.idLabel_Click);
            // 
            // mobLabel
            // 
            this.mobLabel.AutoSize = true;
            this.mobLabel.Location = new System.Drawing.Point(338, 99);
            this.mobLabel.Name = "mobLabel";
            this.mobLabel.Size = new System.Drawing.Size(38, 13);
            this.mobLabel.TabIndex = 7;
            this.mobLabel.Text = "Mobile";
            // 
            // homphLabel
            // 
            this.homphLabel.AutoSize = true;
            this.homphLabel.Location = new System.Drawing.Point(338, 125);
            this.homphLabel.Name = "homphLabel";
            this.homphLabel.Size = new System.Drawing.Size(52, 13);
            this.homphLabel.TabIndex = 7;
            this.homphLabel.Text = "Home No";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(338, 177);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(45, 13);
            this.Address.TabIndex = 7;
            this.Address.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Email";
            // 
            // areaBox
            // 
            this.areaBox.Location = new System.Drawing.Point(420, 200);
            this.areaBox.Name = "areaBox";
            this.areaBox.Size = new System.Drawing.Size(240, 20);
            this.areaBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Area";
            // 
            // salesBox
            // 
            this.salesBox.Location = new System.Drawing.Point(420, 226);
            this.salesBox.Name = "salesBox";
            this.salesBox.Size = new System.Drawing.Size(240, 20);
            this.salesBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Sales ($)";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(438, 264);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(91, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save Changes";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newSaleButton
            // 
            this.newSaleButton.Location = new System.Drawing.Point(341, 264);
            this.newSaleButton.Name = "newSaleButton";
            this.newSaleButton.Size = new System.Drawing.Size(91, 23);
            this.newSaleButton.TabIndex = 9;
            this.newSaleButton.Text = "New Sale";
            this.newSaleButton.UseVisualStyleBackColor = true;
            this.newSaleButton.Click += new System.EventHandler(this.newSaleButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(12, 463);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(320, 23);
            this.refreshButton.TabIndex = 10;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Employee Details";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(220, 570);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(107, 23);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // returnToList
            // 
            this.returnToList.Location = new System.Drawing.Point(12, 434);
            this.returnToList.Name = "returnToList";
            this.returnToList.Size = new System.Drawing.Size(320, 23);
            this.returnToList.TabIndex = 10;
            this.returnToList.Text = "Return to Full List";
            this.returnToList.UseVisualStyleBackColor = true;
            this.returnToList.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 575);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 550);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Search Options";
            // 
            // areaSearch
            // 
            this.areaSearch.Location = new System.Drawing.Point(220, 600);
            this.areaSearch.Name = "areaSearch";
            this.areaSearch.Size = new System.Drawing.Size(107, 23);
            this.areaSearch.TabIndex = 15;
            this.areaSearch.Text = "Search";
            this.areaSearch.UseVisualStyleBackColor = true;
            this.areaSearch.Click += new System.EventHandler(this.areaSearch_Click);
            // 
            // areaSearchBox
            // 
            this.areaSearchBox.Location = new System.Drawing.Point(53, 602);
            this.areaSearchBox.Name = "areaSearchBox";
            this.areaSearchBox.Size = new System.Drawing.Size(161, 20);
            this.areaSearchBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 605);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Area";
            // 
            // millionButton
            // 
            this.millionButton.Location = new System.Drawing.Point(12, 493);
            this.millionButton.Name = "millionButton";
            this.millionButton.Size = new System.Drawing.Size(315, 23);
            this.millionButton.TabIndex = 18;
            this.millionButton.Text = "Employees with over $1m in sales";
            this.millionButton.UseVisualStyleBackColor = true;
            this.millionButton.Click += new System.EventHandler(this.millionButton_Click);
            // 
            // employeeReportButton
            // 
            this.employeeReportButton.Location = new System.Drawing.Point(536, 263);
            this.employeeReportButton.Name = "employeeReportButton";
            this.employeeReportButton.Size = new System.Drawing.Size(75, 23);
            this.employeeReportButton.TabIndex = 19;
            this.employeeReportButton.Text = "Save Employee Report";
            this.employeeReportButton.UseVisualStyleBackColor = true;
            this.employeeReportButton.Click += new System.EventHandler(this.employeeReportButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 681);
            this.Controls.Add(this.employeeReportButton);
            this.Controls.Add(this.millionButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.areaSearchBox);
            this.Controls.Add(this.areaSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.returnToList);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.newSaleButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.homphLabel);
            this.Controls.Add(this.mobLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.salesBox);
            this.Controls.Add(this.areaBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.homphBox);
            this.Controls.Add(this.mobBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PeopleListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sales of the Century";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PeopleListBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpPagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox mobBox;
        private System.Windows.Forms.TextBox homphBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label mobLabel;
        private System.Windows.Forms.Label homphLabel;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox areaBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox salesBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newSaleButton;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button returnToList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button areaSearch;
        private System.Windows.Forms.TextBox areaSearchBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button millionButton;
        private System.Windows.Forms.Button employeeReportButton;
    }
}


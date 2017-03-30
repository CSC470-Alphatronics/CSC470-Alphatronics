namespace ClimbingWall
{
    partial class SearchForm
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
            this.tableDataView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.tableSelectBox = new System.Windows.Forms.ComboBox();
            this.tablePageControl = new ClimbingWall.PageControl();
            this.employeePage = new System.Windows.Forms.TabPage();
            this.empNameBox = new System.Windows.Forms.TextBox();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.empLevelBox = new System.Windows.Forms.TextBox();
            this.EmployeeLevelLabel = new System.Windows.Forms.Label();
            this.EmployeeIdLabel = new System.Windows.Forms.Label();
            this.empIdBox = new System.Windows.Forms.TextBox();
            this.patronPage = new System.Windows.Forms.TabPage();
            this.patronIdBox = new System.Windows.Forms.TextBox();
            this.patronIdLabel = new System.Windows.Forms.Label();
            this.patronFirstNameLabel = new System.Windows.Forms.Label();
            this.patronFirstNameBox = new System.Windows.Forms.TextBox();
            this.patronLastNameBox = new System.Windows.Forms.TextBox();
            this.patronLastNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataView)).BeginInit();
            this.tablePageControl.SuspendLayout();
            this.employeePage.SuspendLayout();
            this.patronPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableDataView
            // 
            this.tableDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataView.Location = new System.Drawing.Point(356, 12);
            this.tableDataView.Name = "tableDataView";
            this.tableDataView.Size = new System.Drawing.Size(401, 297);
            this.tableDataView.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(102, 286);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(164, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // tableSelectBox
            // 
            this.tableSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableSelectBox.FormattingEnabled = true;
            this.tableSelectBox.Items.AddRange(new object[] {
            "Employee",
            "Patron"});
            this.tableSelectBox.Location = new System.Drawing.Point(5, 3);
            this.tableSelectBox.Name = "tableSelectBox";
            this.tableSelectBox.Size = new System.Drawing.Size(227, 21);
            this.tableSelectBox.TabIndex = 3;
            this.tableSelectBox.SelectedIndexChanged += new System.EventHandler(this.tableSelectBox_SelectedIndexChanged);
            // 
            // tablePageControl
            // 
            this.tablePageControl.Controls.Add(this.employeePage);
            this.tablePageControl.Controls.Add(this.patronPage);
            this.tablePageControl.Location = new System.Drawing.Point(1, 30);
            this.tablePageControl.Name = "tablePageControl";
            this.tablePageControl.SelectedIndex = 0;
            this.tablePageControl.Size = new System.Drawing.Size(353, 250);
            this.tablePageControl.TabIndex = 2;
            // 
            // employeePage
            // 
            this.employeePage.Controls.Add(this.empNameBox);
            this.employeePage.Controls.Add(this.employeeNameLabel);
            this.employeePage.Controls.Add(this.empLevelBox);
            this.employeePage.Controls.Add(this.EmployeeLevelLabel);
            this.employeePage.Controls.Add(this.EmployeeIdLabel);
            this.employeePage.Controls.Add(this.empIdBox);
            this.employeePage.Location = new System.Drawing.Point(4, 22);
            this.employeePage.Name = "employeePage";
            this.employeePage.Padding = new System.Windows.Forms.Padding(3);
            this.employeePage.Size = new System.Drawing.Size(345, 224);
            this.employeePage.TabIndex = 0;
            this.employeePage.Text = "Employee";
            this.employeePage.UseVisualStyleBackColor = true;
            // 
            // empNameBox
            // 
            this.empNameBox.Location = new System.Drawing.Point(153, 113);
            this.empNameBox.Name = "empNameBox";
            this.empNameBox.Size = new System.Drawing.Size(169, 20);
            this.empNameBox.TabIndex = 5;
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Location = new System.Drawing.Point(28, 116);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(84, 13);
            this.employeeNameLabel.TabIndex = 4;
            this.employeeNameLabel.Text = "Employee Name";
            // 
            // empLevelBox
            // 
            this.empLevelBox.Location = new System.Drawing.Point(153, 68);
            this.empLevelBox.Name = "empLevelBox";
            this.empLevelBox.Size = new System.Drawing.Size(169, 20);
            this.empLevelBox.TabIndex = 3;
            // 
            // EmployeeLevelLabel
            // 
            this.EmployeeLevelLabel.AutoSize = true;
            this.EmployeeLevelLabel.Location = new System.Drawing.Point(28, 71);
            this.EmployeeLevelLabel.Name = "EmployeeLevelLabel";
            this.EmployeeLevelLabel.Size = new System.Drawing.Size(82, 13);
            this.EmployeeLevelLabel.TabIndex = 2;
            this.EmployeeLevelLabel.Text = "Employee Level";
            // 
            // EmployeeIdLabel
            // 
            this.EmployeeIdLabel.AutoSize = true;
            this.EmployeeIdLabel.Location = new System.Drawing.Point(28, 25);
            this.EmployeeIdLabel.Name = "EmployeeIdLabel";
            this.EmployeeIdLabel.Size = new System.Drawing.Size(67, 13);
            this.EmployeeIdLabel.TabIndex = 1;
            this.EmployeeIdLabel.Text = "Employee ID";
            // 
            // empIdBox
            // 
            this.empIdBox.Location = new System.Drawing.Point(153, 22);
            this.empIdBox.Name = "empIdBox";
            this.empIdBox.Size = new System.Drawing.Size(169, 20);
            this.empIdBox.TabIndex = 0;
            // 
            // patronPage
            // 
            this.patronPage.Controls.Add(this.patronLastNameLabel);
            this.patronPage.Controls.Add(this.patronLastNameBox);
            this.patronPage.Controls.Add(this.patronFirstNameBox);
            this.patronPage.Controls.Add(this.patronFirstNameLabel);
            this.patronPage.Controls.Add(this.patronIdBox);
            this.patronPage.Controls.Add(this.patronIdLabel);
            this.patronPage.Location = new System.Drawing.Point(4, 22);
            this.patronPage.Name = "patronPage";
            this.patronPage.Padding = new System.Windows.Forms.Padding(3);
            this.patronPage.Size = new System.Drawing.Size(345, 224);
            this.patronPage.TabIndex = 1;
            this.patronPage.Text = "Patron";
            this.patronPage.UseVisualStyleBackColor = true;
            // 
            // patronIdBox
            // 
            this.patronIdBox.Location = new System.Drawing.Point(152, 24);
            this.patronIdBox.Name = "patronIdBox";
            this.patronIdBox.Size = new System.Drawing.Size(170, 20);
            this.patronIdBox.TabIndex = 1;
            // 
            // patronIdLabel
            // 
            this.patronIdLabel.AutoSize = true;
            this.patronIdLabel.Location = new System.Drawing.Point(45, 27);
            this.patronIdLabel.Name = "patronIdLabel";
            this.patronIdLabel.Size = new System.Drawing.Size(52, 13);
            this.patronIdLabel.TabIndex = 0;
            this.patronIdLabel.Text = "Patron ID";
            // 
            // patronFirstNameLabel
            // 
            this.patronFirstNameLabel.AutoSize = true;
            this.patronFirstNameLabel.Location = new System.Drawing.Point(45, 85);
            this.patronFirstNameLabel.Name = "patronFirstNameLabel";
            this.patronFirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.patronFirstNameLabel.TabIndex = 2;
            this.patronFirstNameLabel.Text = "First Name";
            // 
            // patronFirstNameBox
            // 
            this.patronFirstNameBox.Location = new System.Drawing.Point(152, 82);
            this.patronFirstNameBox.Name = "patronFirstNameBox";
            this.patronFirstNameBox.Size = new System.Drawing.Size(170, 20);
            this.patronFirstNameBox.TabIndex = 3;
            // 
            // patronLastNameBox
            // 
            this.patronLastNameBox.Location = new System.Drawing.Point(152, 138);
            this.patronLastNameBox.Name = "patronLastNameBox";
            this.patronLastNameBox.Size = new System.Drawing.Size(170, 20);
            this.patronLastNameBox.TabIndex = 4;
            // 
            // patronLastNameLabel
            // 
            this.patronLastNameLabel.AutoSize = true;
            this.patronLastNameLabel.Location = new System.Drawing.Point(45, 141);
            this.patronLastNameLabel.Name = "patronLastNameLabel";
            this.patronLastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.patronLastNameLabel.TabIndex = 5;
            this.patronLastNameLabel.Text = "Last Name";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 321);
            this.Controls.Add(this.tableSelectBox);
            this.Controls.Add(this.tablePageControl);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.tableDataView);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            ((System.ComponentModel.ISupportInitialize)(this.tableDataView)).EndInit();
            this.tablePageControl.ResumeLayout(false);
            this.employeePage.ResumeLayout(false);
            this.employeePage.PerformLayout();
            this.patronPage.ResumeLayout(false);
            this.patronPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableDataView;
        private System.Windows.Forms.Button searchButton;
        private PageControl tablePageControl;
        private System.Windows.Forms.TabPage employeePage;
        private System.Windows.Forms.TabPage patronPage;
        private System.Windows.Forms.ComboBox tableSelectBox;
        private System.Windows.Forms.TextBox empLevelBox;
        private System.Windows.Forms.Label EmployeeLevelLabel;
        private System.Windows.Forms.Label EmployeeIdLabel;
        private System.Windows.Forms.TextBox empIdBox;
        private System.Windows.Forms.TextBox empNameBox;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.TextBox patronIdBox;
        private System.Windows.Forms.Label patronIdLabel;
        private System.Windows.Forms.Label patronLastNameLabel;
        private System.Windows.Forms.TextBox patronLastNameBox;
        private System.Windows.Forms.TextBox patronFirstNameBox;
        private System.Windows.Forms.Label patronFirstNameLabel;
    }
}
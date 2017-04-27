namespace ClimbingWall
{
    partial class EmployeeInterface
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
            this.addUserButton = new System.Windows.Forms.Button();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.noteDelete = new System.Windows.Forms.Button();
            this.scheduleButton = new System.Windows.Forms.Button();
            this.searchDatabaseButton = new System.Windows.Forms.Button();
            this.resetPassButton = new System.Windows.Forms.Button();
            this.suspendButton = new System.Windows.Forms.Button();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.changePassButton = new System.Windows.Forms.Button();
            this.noteButton = new System.Windows.Forms.Button();
            this.SusRequestButton = new System.Windows.Forms.Button();
            this.empChk = new System.Windows.Forms.Button();
            this.Change_Employee_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ClinicRegButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.modifyPatronButton = new System.Windows.Forms.Button();
            this.adminPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(12, 34);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(126, 23);
            this.addUserButton.TabIndex = 0;
            this.addUserButton.Text = "Add New Patron";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // adminPanel
            // 
            this.adminPanel.Controls.Add(this.noteDelete);
            this.adminPanel.Controls.Add(this.scheduleButton);
            this.adminPanel.Controls.Add(this.searchDatabaseButton);
            this.adminPanel.Controls.Add(this.resetPassButton);
            this.adminPanel.Controls.Add(this.suspendButton);
            this.adminPanel.Controls.Add(this.addEmployeeButton);
            this.adminPanel.Location = new System.Drawing.Point(532, 34);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(117, 335);
            this.adminPanel.TabIndex = 0;
            // 
            // noteDelete
            // 
            this.noteDelete.Location = new System.Drawing.Point(4, 303);
            this.noteDelete.Name = "noteDelete";
            this.noteDelete.Size = new System.Drawing.Size(75, 23);
            this.noteDelete.TabIndex = 13;
            this.noteDelete.Text = "Delete Note";
            this.noteDelete.UseVisualStyleBackColor = true;
            this.noteDelete.Click += new System.EventHandler(this.noteDelete_Click);
            // 
            // scheduleButton
            // 
            this.scheduleButton.Location = new System.Drawing.Point(4, 125);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Size = new System.Drawing.Size(113, 23);
            this.scheduleButton.TabIndex = 12;
            this.scheduleButton.Text = "Schedule";
            this.scheduleButton.UseVisualStyleBackColor = true;
            this.scheduleButton.Click += new System.EventHandler(this.scheduleButton_Click);
            // 
            // searchDatabaseButton
            // 
            this.searchDatabaseButton.Location = new System.Drawing.Point(4, 8);
            this.searchDatabaseButton.Name = "searchDatabaseButton";
            this.searchDatabaseButton.Size = new System.Drawing.Size(113, 23);
            this.searchDatabaseButton.TabIndex = 11;
            this.searchDatabaseButton.Text = "Search Database";
            this.searchDatabaseButton.UseVisualStyleBackColor = true;
            this.searchDatabaseButton.Click += new System.EventHandler(this.searchDatabaseButton_Click);
            // 
            // resetPassButton
            // 
            this.resetPassButton.Location = new System.Drawing.Point(4, 37);
            this.resetPassButton.Name = "resetPassButton";
            this.resetPassButton.Size = new System.Drawing.Size(113, 23);
            this.resetPassButton.TabIndex = 10;
            this.resetPassButton.Text = "Reset Password";
            this.resetPassButton.UseVisualStyleBackColor = true;
            this.resetPassButton.Click += new System.EventHandler(this.resetPassButton_Click);
            // 
            // suspendButton
            // 
            this.suspendButton.Location = new System.Drawing.Point(4, 66);
            this.suspendButton.Name = "suspendButton";
            this.suspendButton.Size = new System.Drawing.Size(113, 23);
            this.suspendButton.TabIndex = 8;
            this.suspendButton.Text = "Suspend Patron";
            this.suspendButton.UseVisualStyleBackColor = true;
            this.suspendButton.Click += new System.EventHandler(this.suspendButton_Click);
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(4, 95);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(113, 24);
            this.addEmployeeButton.TabIndex = 0;
            this.addEmployeeButton.Text = "Add Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(12, 63);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(126, 23);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Manual Patron Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // changePassButton
            // 
            this.changePassButton.Location = new System.Drawing.Point(12, 288);
            this.changePassButton.Name = "changePassButton";
            this.changePassButton.Size = new System.Drawing.Size(113, 23);
            this.changePassButton.TabIndex = 2;
            this.changePassButton.Text = "Change Password";
            this.changePassButton.UseVisualStyleBackColor = true;
            this.changePassButton.Click += new System.EventHandler(this.changePassButton_Click);
            // 
            // noteButton
            // 
            this.noteButton.Location = new System.Drawing.Point(12, 123);
            this.noteButton.Name = "noteButton";
            this.noteButton.Size = new System.Drawing.Size(126, 23);
            this.noteButton.TabIndex = 3;
            this.noteButton.Text = "Create Note";
            this.noteButton.UseVisualStyleBackColor = true;
            this.noteButton.Click += new System.EventHandler(this.noteButton_Click);
            // 
            // SusRequestButton
            // 
            this.SusRequestButton.Location = new System.Drawing.Point(13, 152);
            this.SusRequestButton.Name = "SusRequestButton";
            this.SusRequestButton.Size = new System.Drawing.Size(125, 23);
            this.SusRequestButton.TabIndex = 4;
            this.SusRequestButton.Text = "Request Suspension";
            this.SusRequestButton.UseVisualStyleBackColor = true;
            this.SusRequestButton.Click += new System.EventHandler(this.SusRequestButton_Click);
            // 
            // empChk
            // 
            this.empChk.Location = new System.Drawing.Point(12, 346);
            this.empChk.Name = "empChk";
            this.empChk.Size = new System.Drawing.Size(113, 23);
            this.empChk.TabIndex = 10;
            this.empChk.Text = "Level Check";
            this.empChk.UseVisualStyleBackColor = true;
            this.empChk.Click += new System.EventHandler(this.empChk_Click);
            // 
            // Change_Employee_Button
            // 
            this.Change_Employee_Button.Location = new System.Drawing.Point(13, 317);
            this.Change_Employee_Button.Name = "Change_Employee_Button";
            this.Change_Employee_Button.Size = new System.Drawing.Size(112, 23);
            this.Change_Employee_Button.TabIndex = 11;
            this.Change_Employee_Button.Text = "Switch Employee";
            this.Change_Employee_Button.UseVisualStyleBackColor = true;
            this.Change_Employee_Button.Click += new System.EventHandler(this.Change_Employee_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Notes";
            // 
            // ClinicRegButton
            // 
            this.ClinicRegButton.Location = new System.Drawing.Point(13, 181);
            this.ClinicRegButton.Name = "ClinicRegButton";
            this.ClinicRegButton.Size = new System.Drawing.Size(125, 23);
            this.ClinicRegButton.TabIndex = 14;
            this.ClinicRegButton.Text = "Clinic Registration";
            this.ClinicRegButton.UseVisualStyleBackColor = true;
            this.ClinicRegButton.Click += new System.EventHandler(this.ClinicRegButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(13, 210);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(125, 25);
            this.reportButton.TabIndex = 15;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(451, 337);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 16;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(144, 42);
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataView.Size = new System.Drawing.Size(382, 289);
            this.dataView.TabIndex = 17;
            // 
            // modifyPatronButton
            // 
            this.modifyPatronButton.Location = new System.Drawing.Point(12, 92);
            this.modifyPatronButton.Name = "modifyPatronButton";
            this.modifyPatronButton.Size = new System.Drawing.Size(125, 25);
            this.modifyPatronButton.TabIndex = 18;
            this.modifyPatronButton.Text = "Modify Patron";
            this.modifyPatronButton.UseVisualStyleBackColor = true;
            this.modifyPatronButton.Click += new System.EventHandler(this.modifyPatronButton_Click);
            // 
            // EmployeeInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 381);
            this.Controls.Add(this.modifyPatronButton);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.ClinicRegButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Change_Employee_Button);
            this.Controls.Add(this.empChk);
            this.Controls.Add(this.SusRequestButton);
            this.Controls.Add(this.noteButton);
            this.Controls.Add(this.changePassButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.addUserButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EmployeeInterface";
            this.Text = "Climbing Wall System";
            this.adminPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Button suspendButton;
        private System.Windows.Forms.Button changePassButton;
        private System.Windows.Forms.Button noteButton;
        private System.Windows.Forms.Button SusRequestButton;
		private System.Windows.Forms.Button empChk;
		private System.Windows.Forms.Button Change_Employee_Button;
        private System.Windows.Forms.Button resetPassButton;
        private System.Windows.Forms.Button searchDatabaseButton;
        private System.Windows.Forms.Button scheduleButton;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button ClinicRegButton;
		private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button refreshButton;
		private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Button noteDelete;
        private System.Windows.Forms.Button modifyPatronButton;
    }
}
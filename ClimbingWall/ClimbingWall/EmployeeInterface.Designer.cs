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
			this.scheduleButton = new System.Windows.Forms.Button();
			this.searchDatabaseButton = new System.Windows.Forms.Button();
			this.resetPassButton = new System.Windows.Forms.Button();
			this.levelBox = new System.Windows.Forms.ComboBox();
			this.suspendButton = new System.Windows.Forms.Button();
			this.newPasswordInput = new System.Windows.Forms.TextBox();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.newUsernameInput = new System.Windows.Forms.TextBox();
			this.levelLabel = new System.Windows.Forms.Label();
			this.usernameLabel = new System.Windows.Forms.Label();
			this.addEmployeeButton = new System.Windows.Forms.Button();
			this.loginButton = new System.Windows.Forms.Button();
			this.changePassButton = new System.Windows.Forms.Button();
			this.noteButton = new System.Windows.Forms.Button();
			this.SusRequestButton = new System.Windows.Forms.Button();
			this.empChk = new System.Windows.Forms.Button();
			this.Change_Employee_Button = new System.Windows.Forms.Button();
			this.dataView = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.ClinicRegButton = new System.Windows.Forms.Button();
			this.reportButton = new System.Windows.Forms.Button();
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
			this.addUserButton.Text = "Add User";
			this.addUserButton.UseVisualStyleBackColor = true;
			this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
			// 
			// adminPanel
			// 
			this.adminPanel.Controls.Add(this.scheduleButton);
			this.adminPanel.Controls.Add(this.searchDatabaseButton);
			this.adminPanel.Controls.Add(this.resetPassButton);
			this.adminPanel.Controls.Add(this.levelBox);
			this.adminPanel.Controls.Add(this.suspendButton);
			this.adminPanel.Controls.Add(this.newPasswordInput);
			this.adminPanel.Controls.Add(this.passwordLabel);
			this.adminPanel.Controls.Add(this.newUsernameInput);
			this.adminPanel.Controls.Add(this.levelLabel);
			this.adminPanel.Controls.Add(this.usernameLabel);
			this.adminPanel.Controls.Add(this.addEmployeeButton);
			this.adminPanel.Location = new System.Drawing.Point(582, 34);
			this.adminPanel.Name = "adminPanel";
			this.adminPanel.Size = new System.Drawing.Size(343, 315);
			this.adminPanel.TabIndex = 0;
			// 
			// scheduleButton
			// 
			this.scheduleButton.Location = new System.Drawing.Point(167, 37);
			this.scheduleButton.Name = "scheduleButton";
			this.scheduleButton.Size = new System.Drawing.Size(113, 23);
			this.scheduleButton.TabIndex = 12;
			this.scheduleButton.Text = "Schedule";
			this.scheduleButton.UseVisualStyleBackColor = true;
			this.scheduleButton.Click += new System.EventHandler(this.scheduleButton_Click);
			// 
			// searchDatabaseButton
			// 
			this.searchDatabaseButton.Location = new System.Drawing.Point(167, 8);
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
			// levelBox
			// 
			this.levelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.levelBox.FormattingEnabled = true;
			this.levelBox.Items.AddRange(new object[] {
            "Employee",
            "Manager",
            "Admin"});
			this.levelBox.Location = new System.Drawing.Point(125, 242);
			this.levelBox.Name = "levelBox";
			this.levelBox.Size = new System.Drawing.Size(134, 21);
			this.levelBox.TabIndex = 9;
			// 
			// suspendButton
			// 
			this.suspendButton.Location = new System.Drawing.Point(4, 8);
			this.suspendButton.Name = "suspendButton";
			this.suspendButton.Size = new System.Drawing.Size(113, 23);
			this.suspendButton.TabIndex = 8;
			this.suspendButton.Text = "Suspend User";
			this.suspendButton.UseVisualStyleBackColor = true;
			this.suspendButton.Click += new System.EventHandler(this.suspendButton_Click);
			// 
			// newPasswordInput
			// 
			this.newPasswordInput.Location = new System.Drawing.Point(125, 213);
			this.newPasswordInput.Name = "newPasswordInput";
			this.newPasswordInput.Size = new System.Drawing.Size(134, 20);
			this.newPasswordInput.TabIndex = 7;
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(64, 216);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(53, 13);
			this.passwordLabel.TabIndex = 6;
			this.passwordLabel.Text = "Password";
			// 
			// newUsernameInput
			// 
			this.newUsernameInput.Location = new System.Drawing.Point(125, 186);
			this.newUsernameInput.Name = "newUsernameInput";
			this.newUsernameInput.Size = new System.Drawing.Size(134, 20);
			this.newUsernameInput.TabIndex = 5;
			// 
			// levelLabel
			// 
			this.levelLabel.AutoSize = true;
			this.levelLabel.Location = new System.Drawing.Point(64, 242);
			this.levelLabel.Name = "levelLabel";
			this.levelLabel.Size = new System.Drawing.Size(33, 13);
			this.levelLabel.TabIndex = 3;
			this.levelLabel.Text = "Level";
			// 
			// usernameLabel
			// 
			this.usernameLabel.AutoSize = true;
			this.usernameLabel.Location = new System.Drawing.Point(64, 189);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(55, 13);
			this.usernameLabel.TabIndex = 1;
			this.usernameLabel.Text = "Username";
			// 
			// addEmployeeButton
			// 
			this.addEmployeeButton.Location = new System.Drawing.Point(167, 273);
			this.addEmployeeButton.Name = "addEmployeeButton";
			this.addEmployeeButton.Size = new System.Drawing.Size(92, 24);
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
			this.loginButton.Text = "Manual User Login";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// changePassButton
			// 
			this.changePassButton.Location = new System.Drawing.Point(12, 92);
			this.changePassButton.Name = "changePassButton";
			this.changePassButton.Size = new System.Drawing.Size(126, 23);
			this.changePassButton.TabIndex = 2;
			this.changePassButton.Text = "Change Password";
			this.changePassButton.UseVisualStyleBackColor = true;
			this.changePassButton.Click += new System.EventHandler(this.changePassButton_Click);
			// 
			// noteButton
			// 
			this.noteButton.Location = new System.Drawing.Point(12, 121);
			this.noteButton.Name = "noteButton";
			this.noteButton.Size = new System.Drawing.Size(126, 23);
			this.noteButton.TabIndex = 3;
			this.noteButton.Text = "Notes";
			this.noteButton.UseVisualStyleBackColor = true;
			this.noteButton.Click += new System.EventHandler(this.noteButton_Click);
			// 
			// SusRequestButton
			// 
			this.SusRequestButton.Location = new System.Drawing.Point(13, 151);
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
			this.empChk.Text = "LevelCheck";
			this.empChk.UseVisualStyleBackColor = true;
			this.empChk.Click += new System.EventHandler(this.empChk_Click);
			// 
			// Change_Employee_Button
			// 
			this.Change_Employee_Button.Location = new System.Drawing.Point(13, 317);
			this.Change_Employee_Button.Name = "Change_Employee_Button";
			this.Change_Employee_Button.Size = new System.Drawing.Size(112, 23);
			this.Change_Employee_Button.TabIndex = 11;
			this.Change_Employee_Button.Text = "Switch User";
			this.Change_Employee_Button.UseVisualStyleBackColor = true;
			this.Change_Employee_Button.Click += new System.EventHandler(this.Change_Employee_Button_Click);
			// 
			// dataView
			// 
			this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataView.Location = new System.Drawing.Point(195, 42);
			this.dataView.Name = "dataView";
			this.dataView.Size = new System.Drawing.Size(381, 289);
			this.dataView.TabIndex = 12;
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
			this.reportButton.Location = new System.Drawing.Point(13, 211);
			this.reportButton.Name = "reportButton";
			this.reportButton.Size = new System.Drawing.Size(125, 25);
			this.reportButton.TabIndex = 15;
			this.reportButton.Text = "Report";
			this.reportButton.UseVisualStyleBackColor = true;
			this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
			// 
			// EmployeeInterface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(943, 381);
			this.Controls.Add(this.reportButton);
			this.Controls.Add(this.ClinicRegButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataView);
			this.Controls.Add(this.Change_Employee_Button);
			this.Controls.Add(this.empChk);
			this.Controls.Add(this.SusRequestButton);
			this.Controls.Add(this.noteButton);
			this.Controls.Add(this.changePassButton);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.adminPanel);
			this.Controls.Add(this.addUserButton);
			this.Name = "EmployeeInterface";
			this.Text = "EmployeeInterface";
			this.adminPanel.ResumeLayout(false);
			this.adminPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.TextBox newUsernameInput;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox newPasswordInput;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button suspendButton;
        private System.Windows.Forms.ComboBox levelBox;
        private System.Windows.Forms.Button changePassButton;
        private System.Windows.Forms.Button noteButton;
        private System.Windows.Forms.Button SusRequestButton;
		private System.Windows.Forms.Button empChk;
		private System.Windows.Forms.Button Change_Employee_Button;
        private System.Windows.Forms.Button resetPassButton;
        private System.Windows.Forms.Button searchDatabaseButton;
        private System.Windows.Forms.Button scheduleButton;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button ClinicRegButton;
		private System.Windows.Forms.Button reportButton;
	}
}
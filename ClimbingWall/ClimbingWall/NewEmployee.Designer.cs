namespace ClimbingWall
{
    partial class NewEmployee
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
            this.levelBox = new System.Windows.Forms.ComboBox();
            this.newPasswordInput = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.newUsernameInput = new System.Windows.Forms.TextBox();
            this.levelLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.empFN_Label = new System.Windows.Forms.Label();
            this.empLN_Label = new System.Windows.Forms.Label();
            this.empFName = new System.Windows.Forms.TextBox();
            this.empLName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // levelBox
            // 
            this.levelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.levelBox.FormattingEnabled = true;
            this.levelBox.Items.AddRange(new object[] {
            "Employee",
            "Manager",
            "Admin"});
            this.levelBox.Location = new System.Drawing.Point(73, 151);
            this.levelBox.Name = "levelBox";
            this.levelBox.Size = new System.Drawing.Size(134, 21);
            this.levelBox.TabIndex = 17;
            // 
            // newPasswordInput
            // 
            this.newPasswordInput.Location = new System.Drawing.Point(73, 125);
            this.newPasswordInput.Name = "newPasswordInput";
            this.newPasswordInput.Size = new System.Drawing.Size(134, 20);
            this.newPasswordInput.TabIndex = 16;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(12, 128);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 21;
            this.passwordLabel.Text = "Password";
            // 
            // newUsernameInput
            // 
            this.newUsernameInput.Location = new System.Drawing.Point(73, 99);
            this.newUsernameInput.Name = "newUsernameInput";
            this.newUsernameInput.Size = new System.Drawing.Size(134, 20);
            this.newUsernameInput.TabIndex = 15;
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(12, 154);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(33, 13);
            this.levelLabel.TabIndex = 19;
            this.levelLabel.Text = "Level";
            this.levelLabel.Click += new System.EventHandler(this.levelLabel_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(12, 102);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 20;
            this.usernameLabel.Text = "Username";
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(115, 184);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(92, 24);
            this.addEmployeeButton.TabIndex = 18;
            this.addEmployeeButton.Text = "Add Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // empFN_Label
            // 
            this.empFN_Label.AutoSize = true;
            this.empFN_Label.Location = new System.Drawing.Point(12, 38);
            this.empFN_Label.Name = "empFN_Label";
            this.empFN_Label.Size = new System.Drawing.Size(57, 13);
            this.empFN_Label.TabIndex = 40;
            this.empFN_Label.Text = "First Name";
            // 
            // empLN_Label
            // 
            this.empLN_Label.AutoSize = true;
            this.empLN_Label.Location = new System.Drawing.Point(12, 64);
            this.empLN_Label.Name = "empLN_Label";
            this.empLN_Label.Size = new System.Drawing.Size(58, 13);
            this.empLN_Label.TabIndex = 42;
            this.empLN_Label.Text = "Last Name";
            // 
            // empFName
            // 
            this.empFName.Location = new System.Drawing.Point(107, 35);
            this.empFName.Name = "empFName";
            this.empFName.Size = new System.Drawing.Size(100, 20);
            this.empFName.TabIndex = 10;
            // 
            // empLName
            // 
            this.empLName.Location = new System.Drawing.Point(107, 61);
            this.empLName.Name = "empLName";
            this.empLName.Size = new System.Drawing.Size(100, 20);
            this.empLName.TabIndex = 12;
            // 
            // NewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 250);
            this.Controls.Add(this.empLName);
            this.Controls.Add(this.empFName);
            this.Controls.Add(this.empLN_Label);
            this.Controls.Add(this.empFN_Label);
            this.Controls.Add(this.levelBox);
            this.Controls.Add(this.newPasswordInput);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.newUsernameInput);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.addEmployeeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "NewEmployee";
            this.Text = "New Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox levelBox;
        private System.Windows.Forms.TextBox newPasswordInput;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox newUsernameInput;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Label empFN_Label;
        private System.Windows.Forms.Label empLN_Label;
        private System.Windows.Forms.TextBox empFName;
        private System.Windows.Forms.TextBox empLName;
    }
}
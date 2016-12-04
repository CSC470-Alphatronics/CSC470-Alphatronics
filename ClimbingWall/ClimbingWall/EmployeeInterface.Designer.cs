﻿namespace ClimbingWall
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
            this.loginButton = new System.Windows.Forms.Button();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.isAdminLabel = new System.Windows.Forms.Label();
            this.isAdminInput = new System.Windows.Forms.CheckBox();
            this.newUsernameInput = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.newPasswordInput = new System.Windows.Forms.TextBox();
            this.adminPanel.SuspendLayout();
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
            // 
            // adminPanel
            // 
            this.adminPanel.Controls.Add(this.newPasswordInput);
            this.adminPanel.Controls.Add(this.passwordLabel);
            this.adminPanel.Controls.Add(this.newUsernameInput);
            this.adminPanel.Controls.Add(this.isAdminInput);
            this.adminPanel.Controls.Add(this.isAdminLabel);
            this.adminPanel.Controls.Add(this.usernameLabel);
            this.adminPanel.Controls.Add(this.addEmployeeButton);
            this.adminPanel.Location = new System.Drawing.Point(314, 26);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(343, 286);
            this.adminPanel.TabIndex = 0;
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
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(167, 237);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(92, 24);
            this.addEmployeeButton.TabIndex = 0;
            this.addEmployeeButton.Text = "Add Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
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
            // isAdminLabel
            // 
            this.isAdminLabel.AutoSize = true;
            this.isAdminLabel.Location = new System.Drawing.Point(64, 242);
            this.isAdminLabel.Name = "isAdminLabel";
            this.isAdminLabel.Size = new System.Drawing.Size(36, 13);
            this.isAdminLabel.TabIndex = 3;
            this.isAdminLabel.Text = "Admin";
            // 
            // isAdminInput
            // 
            this.isAdminInput.AutoSize = true;
            this.isAdminInput.Location = new System.Drawing.Point(125, 242);
            this.isAdminInput.Name = "isAdminInput";
            this.isAdminInput.Size = new System.Drawing.Size(15, 14);
            this.isAdminInput.TabIndex = 4;
            this.isAdminInput.UseVisualStyleBackColor = true;
            // 
            // newUsernameInput
            // 
            this.newUsernameInput.Location = new System.Drawing.Point(125, 186);
            this.newUsernameInput.Name = "newUsernameInput";
            this.newUsernameInput.Size = new System.Drawing.Size(134, 20);
            this.newUsernameInput.TabIndex = 5;
            this.newUsernameInput.TextChanged += new System.EventHandler(this.newUsernameInput_TextChanged);
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
            // newPasswordInput
            // 
            this.newPasswordInput.Location = new System.Drawing.Point(125, 213);
            this.newPasswordInput.Name = "newPasswordInput";
            this.newPasswordInput.Size = new System.Drawing.Size(134, 20);
            this.newPasswordInput.TabIndex = 7;
            // 
            // EmployeeInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 381);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.addUserButton);
            this.Name = "EmployeeInterface";
            this.Text = "EmployeeInterface";
            this.Load += new System.EventHandler(this.EmployeeInterface_Load);
            this.adminPanel.ResumeLayout(false);
            this.adminPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.TextBox newUsernameInput;
        private System.Windows.Forms.CheckBox isAdminInput;
        private System.Windows.Forms.Label isAdminLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox newPasswordInput;
        private System.Windows.Forms.Label passwordLabel;
    }
}
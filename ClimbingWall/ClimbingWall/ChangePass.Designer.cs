namespace ClimbingWall
{
    partial class ChangePass
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
            this.currentText = new System.Windows.Forms.TextBox();
            this.newText = new System.Windows.Forms.TextBox();
            this.currentBox = new System.Windows.Forms.Label();
            this.newBox = new System.Windows.Forms.Label();
            this.confirmText = new System.Windows.Forms.TextBox();
            this.confirmBox = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currentText
            // 
            this.currentText.Location = new System.Drawing.Point(134, 28);
            this.currentText.Name = "currentText";
            this.currentText.PasswordChar = '*';
            this.currentText.Size = new System.Drawing.Size(163, 20);
            this.currentText.TabIndex = 0;
            this.currentText.UseSystemPasswordChar = true;
            // 
            // newText
            // 
            this.newText.Location = new System.Drawing.Point(134, 54);
            this.newText.Name = "newText";
            this.newText.PasswordChar = '*';
            this.newText.Size = new System.Drawing.Size(163, 20);
            this.newText.TabIndex = 1;
            this.newText.UseSystemPasswordChar = true;
            // 
            // currentBox
            // 
            this.currentBox.AutoSize = true;
            this.currentBox.Location = new System.Drawing.Point(38, 31);
            this.currentBox.Name = "currentBox";
            this.currentBox.Size = new System.Drawing.Size(90, 13);
            this.currentBox.TabIndex = 2;
            this.currentBox.Text = "Current Password";
            // 
            // newBox
            // 
            this.newBox.AutoSize = true;
            this.newBox.Location = new System.Drawing.Point(50, 57);
            this.newBox.Name = "newBox";
            this.newBox.Size = new System.Drawing.Size(78, 13);
            this.newBox.TabIndex = 3;
            this.newBox.Text = "New Password";
            // 
            // confirmText
            // 
            this.confirmText.Location = new System.Drawing.Point(134, 80);
            this.confirmText.Name = "confirmText";
            this.confirmText.PasswordChar = '*';
            this.confirmText.Size = new System.Drawing.Size(163, 20);
            this.confirmText.TabIndex = 4;
            this.confirmText.UseSystemPasswordChar = true;
            this.confirmText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.confirmText_KeyDown);
            // 
            // confirmBox
            // 
            this.confirmBox.AutoSize = true;
            this.confirmBox.Location = new System.Drawing.Point(12, 83);
            this.confirmBox.Name = "confirmBox";
            this.confirmBox.Size = new System.Drawing.Size(116, 13);
            this.confirmBox.TabIndex = 5;
            this.confirmBox.Text = "Confirm New Password";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(222, 106);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 6;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 138);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.confirmBox);
            this.Controls.Add(this.confirmText);
            this.Controls.Add(this.newBox);
            this.Controls.Add(this.currentBox);
            this.Controls.Add(this.newText);
            this.Controls.Add(this.currentText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "ChangePass";
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox currentText;
        private System.Windows.Forms.TextBox newText;
        private System.Windows.Forms.Label currentBox;
        private System.Windows.Forms.Label newBox;
        private System.Windows.Forms.TextBox confirmText;
        private System.Windows.Forms.Label confirmBox;
        private System.Windows.Forms.Button changeButton;
    }
}
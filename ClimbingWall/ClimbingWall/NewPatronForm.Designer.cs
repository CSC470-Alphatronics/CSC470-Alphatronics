namespace ClimbingWall
{
	partial class NewPatronForm
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
			if (disposing && (components != null)) {
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
            this.FirstNameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LastNameTextbox = new System.Windows.Forms.TextBox();
            this.MiddleInitTextbox = new System.Windows.Forms.TextBox();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.PhoneTextbox = new System.Windows.Forms.TextBox();
            this.IDTextbox = new System.Windows.Forms.TextBox();
            this.CreatePatronButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstNameTextbox
            // 
            this.FirstNameTextbox.Location = new System.Drawing.Point(73, 38);
            this.FirstNameTextbox.Name = "FirstNameTextbox";
            this.FirstNameTextbox.Size = new System.Drawing.Size(101, 20);
            this.FirstNameTextbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Student/RockWall ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Middle Initial:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Phone: ";
            // 
            // LastNameTextbox
            // 
            this.LastNameTextbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LastNameTextbox.Location = new System.Drawing.Point(73, 12);
            this.LastNameTextbox.Name = "LastNameTextbox";
            this.LastNameTextbox.Size = new System.Drawing.Size(101, 20);
            this.LastNameTextbox.TabIndex = 1;
            // 
            // MiddleInitTextbox
            // 
            this.MiddleInitTextbox.Location = new System.Drawing.Point(73, 67);
            this.MiddleInitTextbox.MaxLength = 1;
            this.MiddleInitTextbox.Name = "MiddleInitTextbox";
            this.MiddleInitTextbox.Size = new System.Drawing.Size(100, 20);
            this.MiddleInitTextbox.TabIndex = 3;
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Location = new System.Drawing.Point(299, 38);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(145, 20);
            this.EmailTextbox.TabIndex = 5;
            // 
            // PhoneTextbox
            // 
            this.PhoneTextbox.Location = new System.Drawing.Point(299, 64);
            this.PhoneTextbox.Name = "PhoneTextbox";
            this.PhoneTextbox.Size = new System.Drawing.Size(145, 20);
            this.PhoneTextbox.TabIndex = 6;
            // 
            // IDTextbox
            // 
            this.IDTextbox.Location = new System.Drawing.Point(299, 12);
            this.IDTextbox.Name = "IDTextbox";
            this.IDTextbox.Size = new System.Drawing.Size(145, 20);
            this.IDTextbox.TabIndex = 4;
            // 
            // CreatePatronButton
            // 
            this.CreatePatronButton.Location = new System.Drawing.Point(155, 95);
            this.CreatePatronButton.Name = "CreatePatronButton";
            this.CreatePatronButton.Size = new System.Drawing.Size(105, 23);
            this.CreatePatronButton.TabIndex = 8;
            this.CreatePatronButton.Text = "Create Account";
            this.CreatePatronButton.UseVisualStyleBackColor = true;
            this.CreatePatronButton.Click += new System.EventHandler(this.CreatePatronButton_Click);
            // 
            // NewPatronForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 128);
            this.Controls.Add(this.CreatePatronButton);
            this.Controls.Add(this.IDTextbox);
            this.Controls.Add(this.PhoneTextbox);
            this.Controls.Add(this.EmailTextbox);
            this.Controls.Add(this.MiddleInitTextbox);
            this.Controls.Add(this.LastNameTextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstNameTextbox);
            this.Name = "NewPatronForm";
            this.Text = "NewPatronForm";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox FirstNameTextbox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox LastNameTextbox;
		private System.Windows.Forms.TextBox MiddleInitTextbox;
		private System.Windows.Forms.TextBox EmailTextbox;
		private System.Windows.Forms.TextBox PhoneTextbox;
		private System.Windows.Forms.TextBox IDTextbox;
		private System.Windows.Forms.Button CreatePatronButton;
	}
}
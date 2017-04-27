namespace ClimbingWall
{
	partial class CertifyPatrons
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.certifyBtn = new System.Windows.Forms.Button();
            this.CertOptionsBox = new System.Windows.Forms.GroupBox();
            this.Bouldering_chkBox = new System.Windows.Forms.CheckBox();
            this.Lead_chkBox = new System.Windows.Forms.CheckBox();
            this.Belay_chkBox = new System.Windows.Forms.CheckBox();
            this.CertOptionsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(12, 141);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(79, 31);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // certifyBtn
            // 
            this.certifyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.certifyBtn.Location = new System.Drawing.Point(119, 141);
            this.certifyBtn.Name = "certifyBtn";
            this.certifyBtn.Size = new System.Drawing.Size(85, 31);
            this.certifyBtn.TabIndex = 2;
            this.certifyBtn.Text = "Certify Patrons";
            this.certifyBtn.UseVisualStyleBackColor = true;
            this.certifyBtn.Click += new System.EventHandler(this.certifyBtn_Click);
            // 
            // CertOptionsBox
            // 
            this.CertOptionsBox.Controls.Add(this.Bouldering_chkBox);
            this.CertOptionsBox.Controls.Add(this.Lead_chkBox);
            this.CertOptionsBox.Controls.Add(this.Belay_chkBox);
            this.CertOptionsBox.Location = new System.Drawing.Point(12, 12);
            this.CertOptionsBox.Name = "CertOptionsBox";
            this.CertOptionsBox.Size = new System.Drawing.Size(192, 98);
            this.CertOptionsBox.TabIndex = 3;
            this.CertOptionsBox.TabStop = false;
            this.CertOptionsBox.Text = "Earned Certification(s)";
            // 
            // Bouldering_chkBox
            // 
            this.Bouldering_chkBox.AutoSize = true;
            this.Bouldering_chkBox.Location = new System.Drawing.Point(8, 65);
            this.Bouldering_chkBox.Name = "Bouldering_chkBox";
            this.Bouldering_chkBox.Size = new System.Drawing.Size(76, 17);
            this.Bouldering_chkBox.TabIndex = 2;
            this.Bouldering_chkBox.Text = "Bouldering";
            this.Bouldering_chkBox.UseVisualStyleBackColor = true;
            this.Bouldering_chkBox.CheckedChanged += new System.EventHandler(this.Bouldering_chkBox_CheckedChanged);
            // 
            // Lead_chkBox
            // 
            this.Lead_chkBox.AutoSize = true;
            this.Lead_chkBox.Location = new System.Drawing.Point(8, 42);
            this.Lead_chkBox.Name = "Lead_chkBox";
            this.Lead_chkBox.Size = new System.Drawing.Size(50, 17);
            this.Lead_chkBox.TabIndex = 1;
            this.Lead_chkBox.Text = "Lead";
            this.Lead_chkBox.UseVisualStyleBackColor = true;
            this.Lead_chkBox.CheckedChanged += new System.EventHandler(this.Lead_chkBox_CheckedChanged);
            // 
            // Belay_chkBox
            // 
            this.Belay_chkBox.AutoSize = true;
            this.Belay_chkBox.Location = new System.Drawing.Point(8, 19);
            this.Belay_chkBox.Name = "Belay_chkBox";
            this.Belay_chkBox.Size = new System.Drawing.Size(52, 17);
            this.Belay_chkBox.TabIndex = 0;
            this.Belay_chkBox.Text = "Belay";
            this.Belay_chkBox.UseVisualStyleBackColor = true;
            this.Belay_chkBox.CheckedChanged += new System.EventHandler(this.Belay_chkBox_CheckedChanged);
            // 
            // CertifyPatrons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 184);
            this.Controls.Add(this.CertOptionsBox);
            this.Controls.Add(this.certifyBtn);
            this.Controls.Add(this.cancelBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CertifyPatrons";
            this.Text = "CertifyPatrons";
            this.CertOptionsBox.ResumeLayout(false);
            this.CertOptionsBox.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.Button certifyBtn;
		private System.Windows.Forms.GroupBox CertOptionsBox;
		private System.Windows.Forms.CheckBox Bouldering_chkBox;
		private System.Windows.Forms.CheckBox Lead_chkBox;
		private System.Windows.Forms.CheckBox Belay_chkBox;
	}
}
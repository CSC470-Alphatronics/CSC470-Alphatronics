namespace ClimbingWall
{
	partial class ClinicRegistration
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
            this.availClinicTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.regButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.patronTextBox = new System.Windows.Forms.TextBox();
            this.clinicTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.availClinicTable)).BeginInit();
            this.SuspendLayout();
            // 
            // availClinicTable
            // 
            this.availClinicTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availClinicTable.Location = new System.Drawing.Point(243, 42);
            this.availClinicTable.Name = "availClinicTable";
            this.availClinicTable.ReadOnly = true;
            this.availClinicTable.Size = new System.Drawing.Size(434, 349);
            this.availClinicTable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Clinics";
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(12, 125);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(75, 23);
            this.regButton.TabIndex = 2;
            this.regButton.Text = "Register";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Patron ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Clinic ID:";
            // 
            // patronTextBox
            // 
            this.patronTextBox.Location = new System.Drawing.Point(12, 59);
            this.patronTextBox.Name = "patronTextBox";
            this.patronTextBox.Size = new System.Drawing.Size(100, 20);
            this.patronTextBox.TabIndex = 5;
            // 
            // clinicTextBox
            // 
            this.clinicTextBox.Location = new System.Drawing.Point(12, 99);
            this.clinicTextBox.Name = "clinicTextBox";
            this.clinicTextBox.Size = new System.Drawing.Size(100, 20);
            this.clinicTextBox.TabIndex = 6;
            // 
            // ClinicRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 403);
            this.Controls.Add(this.clinicTextBox);
            this.Controls.Add(this.patronTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.availClinicTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ClinicRegistration";
            this.Text = "ClinicRegistration";
            ((System.ComponentModel.ISupportInitialize)(this.availClinicTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView availClinicTable;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button regButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox patronTextBox;
		private System.Windows.Forms.TextBox clinicTextBox;
	}
}
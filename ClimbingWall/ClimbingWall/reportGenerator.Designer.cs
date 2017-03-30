namespace ClimbingWall
{
	partial class reportGenerator
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
			this.startDate = new System.Windows.Forms.DateTimePicker();
			this.endDate = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.generateReport = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// startDate
			// 
			this.startDate.CustomFormat = "yyyy-MM-dd";
			this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.startDate.Location = new System.Drawing.Point(12, 31);
			this.startDate.Name = "startDate";
			this.startDate.Size = new System.Drawing.Size(130, 20);
			this.startDate.TabIndex = 0;
			// 
			// endDate
			// 
			this.endDate.CustomFormat = "yyyy-MM-dd";
			this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.endDate.Location = new System.Drawing.Point(12, 70);
			this.endDate.Name = "endDate";
			this.endDate.Size = new System.Drawing.Size(130, 20);
			this.endDate.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Start Date";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "End Date";
			// 
			// generateReport
			// 
			this.generateReport.Location = new System.Drawing.Point(12, 96);
			this.generateReport.Name = "generateReport";
			this.generateReport.Size = new System.Drawing.Size(130, 23);
			this.generateReport.TabIndex = 4;
			this.generateReport.Text = "Generate Report";
			this.generateReport.UseVisualStyleBackColor = true;
			this.generateReport.Click += new System.EventHandler(this.generateReport_Click);
			// 
			// reportGenerator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(161, 139);
			this.Controls.Add(this.generateReport);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.endDate);
			this.Controls.Add(this.startDate);
			this.Name = "reportGenerator";
			this.Text = "reportGenerator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker startDate;
		private System.Windows.Forms.DateTimePicker endDate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button generateReport;
	}
}
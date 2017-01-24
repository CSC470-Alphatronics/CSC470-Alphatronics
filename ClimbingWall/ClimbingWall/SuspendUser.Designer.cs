namespace ClimbingWall
{
    partial class SuspendUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reasonBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.suspendButton = new System.Windows.Forms.Button();
            this.lengthBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patron ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reason:";
            // 
            // reasonBox
            // 
            this.reasonBox.Location = new System.Drawing.Point(13, 64);
            this.reasonBox.MaxLength = 200;
            this.reasonBox.Multiline = true;
            this.reasonBox.Name = "reasonBox";
            this.reasonBox.Size = new System.Drawing.Size(458, 38);
            this.reasonBox.TabIndex = 2;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(86, 13);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(125, 20);
            this.idBox.TabIndex = 3;
            // 
            // suspendButton
            // 
            this.suspendButton.Location = new System.Drawing.Point(228, 13);
            this.suspendButton.Name = "suspendButton";
            this.suspendButton.Size = new System.Drawing.Size(65, 23);
            this.suspendButton.TabIndex = 4;
            this.suspendButton.Text = "Suspend";
            this.suspendButton.UseVisualStyleBackColor = true;
            this.suspendButton.Click += new System.EventHandler(this.suspendButton_Click);
            // 
            // lengthBox
            // 
            this.lengthBox.FormattingEnabled = true;
            this.lengthBox.Items.AddRange(new object[] {
            "7 Days",
            "30 Days",
            "Semester",
            "1 Year"});
            this.lengthBox.Location = new System.Drawing.Point(155, 111);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(121, 21);
            this.lengthBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Length of Suspension:";
            // 
            // SuspendUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 175);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lengthBox);
            this.Controls.Add(this.suspendButton);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.reasonBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SuspendUser";
            this.Text = "Suspend User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reasonBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Button suspendButton;
        private System.Windows.Forms.ComboBox lengthBox;
        private System.Windows.Forms.Label label3;
    }
}
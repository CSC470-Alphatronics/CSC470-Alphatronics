namespace ClimbingWall
{
    partial class Note
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
            this.noteText = new System.Windows.Forms.RichTextBox();
            this.priorityBox = new System.Windows.Forms.ComboBox();
            this.noteLabel = new System.Windows.Forms.Label();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // noteText
            // 
            this.noteText.Location = new System.Drawing.Point(12, 48);
            this.noteText.MaxLength = 300;
            this.noteText.Name = "noteText";
            this.noteText.Size = new System.Drawing.Size(475, 87);
            this.noteText.TabIndex = 0;
            this.noteText.Text = "";
            // 
            // priorityBox
            // 
            this.priorityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priorityBox.FormattingEnabled = true;
            this.priorityBox.Items.AddRange(new object[] {
            "Normal",
            "High"});
            this.priorityBox.Location = new System.Drawing.Point(366, 12);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(121, 21);
            this.priorityBox.TabIndex = 1;
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Location = new System.Drawing.Point(13, 29);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(57, 13);
            this.noteLabel.TabIndex = 2;
            this.noteLabel.Text = "Note Text:";
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Location = new System.Drawing.Point(325, 15);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(38, 13);
            this.priorityLabel.TabIndex = 3;
            this.priorityLabel.Text = "Priority";
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(415, 141);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(72, 37);
            this.enterButton.TabIndex = 4;
            this.enterButton.Text = "Enter Note";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 185);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.priorityBox);
            this.Controls.Add(this.noteText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Note";
            this.Text = "Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox noteText;
        private System.Windows.Forms.ComboBox priorityBox;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.Button enterButton;
    }
}
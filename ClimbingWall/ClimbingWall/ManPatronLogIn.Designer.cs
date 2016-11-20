namespace PlaygroudForms
{
    partial class ManLogInForm
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
            this.logButton = new System.Windows.Forms.Button();
            this.idTextbox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logButton
            // 
            this.logButton.Location = new System.Drawing.Point(194, 44);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(128, 50);
            this.logButton.TabIndex = 0;
            this.logButton.Text = "Log In";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // idTextbox
            // 
            this.idTextbox.Location = new System.Drawing.Point(143, 12);
            this.idTextbox.Name = "idTextbox";
            this.idTextbox.Size = new System.Drawing.Size(235, 26);
            this.idTextbox.TabIndex = 1;
            // 
            // resultLabel
            // 
            this.resultLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(139, 108);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 20);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resultLabel.Click += new System.EventHandler(this.resultLabel_Click);
            // 
            // ManLogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 184);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.idTextbox);
            this.Controls.Add(this.logButton);
            this.Name = "ManLogInForm";
            this.Text = "Manual Patron Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.TextBox idTextbox;
        private System.Windows.Forms.Label resultLabel;
    }
}

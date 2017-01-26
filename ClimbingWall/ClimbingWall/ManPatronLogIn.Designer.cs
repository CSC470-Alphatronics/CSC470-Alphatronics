namespace ClimbingWall {
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
            this.logButton.Location = new System.Drawing.Point(129, 32);
            this.logButton.Margin = new System.Windows.Forms.Padding(2);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(85, 32);
            this.logButton.TabIndex = 0;
            this.logButton.Text = "Log In";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // idTextbox
            // 
            this.idTextbox.Location = new System.Drawing.Point(95, 8);
            this.idTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.idTextbox.Name = "idTextbox";
            this.idTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.idTextbox.Size = new System.Drawing.Size(158, 20);
            this.idTextbox.TabIndex = 1;
            this.idTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.idTextbox_KeyDown);
            // 
            // resultLabel
            // 
            this.resultLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(93, 70);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resultLabel.Click += new System.EventHandler(this.resultLabel_Click);
            // 
            // ManLogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 120);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.idTextbox);
            this.Controls.Add(this.logButton);
            this.Margin = new System.Windows.Forms.Padding(2);
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


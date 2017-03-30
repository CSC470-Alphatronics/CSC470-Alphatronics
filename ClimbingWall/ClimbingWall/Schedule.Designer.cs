namespace ClimbingWall
{
    partial class Schedule
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
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.beginLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hourBox = new System.Windows.Forms.ComboBox();
            this.minuteBox = new System.Windows.Forms.ComboBox();
            this.periodBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.periodBox_end = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.newPeriodBox = new System.Windows.Forms.ComboBox();
            this.newMinuteBox = new System.Windows.Forms.ComboBox();
            this.newHourBox = new System.Windows.Forms.ComboBox();
            this.newDateLabel = new System.Windows.Forms.Label();
            this.newDate = new System.Windows.Forms.DateTimePicker();
            this.newClinicLabel = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.newClinicButton = new System.Windows.Forms.Button();
            this.instructorBox = new System.Windows.Forms.TextBox();
            this.instructorLabel = new System.Windows.Forms.Label();
            this.regButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // startDate
            // 
            this.startDate.CustomFormat = "yyyy-MM-dd";
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDate.Location = new System.Drawing.Point(55, 54);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(95, 20);
            this.startDate.TabIndex = 1;
            // 
            // endDate
            // 
            this.endDate.CustomFormat = "yyyy-MM-dd";
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDate.Location = new System.Drawing.Point(201, 54);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(95, 20);
            this.endDate.TabIndex = 2;
            // 
            // beginLabel
            // 
            this.beginLabel.AutoSize = true;
            this.beginLabel.Location = new System.Drawing.Point(12, 54);
            this.beginLabel.Name = "beginLabel";
            this.beginLabel.Size = new System.Drawing.Size(37, 13);
            this.beginLabel.TabIndex = 3;
            this.beginLabel.Text = "Begin:";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(166, 54);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(29, 13);
            this.endLabel.TabIndex = 4;
            this.endLabel.Text = "End:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date Range";
            // 
            // hourBox
            // 
            this.hourBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hourBox.FormattingEnabled = true;
            this.hourBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.hourBox.Location = new System.Drawing.Point(90, 84);
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(45, 21);
            this.hourBox.TabIndex = 6;
            // 
            // minuteBox
            // 
            this.minuteBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minuteBox.FormattingEnabled = true;
            this.minuteBox.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.minuteBox.Location = new System.Drawing.Point(161, 84);
            this.minuteBox.Name = "minuteBox";
            this.minuteBox.Size = new System.Drawing.Size(45, 21);
            this.minuteBox.TabIndex = 7;
            // 
            // periodBox
            // 
            this.periodBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periodBox.FormattingEnabled = true;
            this.periodBox.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.periodBox.Location = new System.Drawing.Point(212, 84);
            this.periodBox.Name = "periodBox";
            this.periodBox.Size = new System.Drawing.Size(45, 21);
            this.periodBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Time:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(221, 162);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(141, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = ":";
            // 
            // periodBox_end
            // 
            this.periodBox_end.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.periodBox_end.FormattingEnabled = true;
            this.periodBox_end.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.periodBox_end.Location = new System.Drawing.Point(212, 121);
            this.periodBox_end.Name = "periodBox_end";
            this.periodBox_end.Size = new System.Drawing.Size(45, 21);
            this.periodBox_end.TabIndex = 14;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBox2.Location = new System.Drawing.Point(161, 121);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(45, 21);
            this.comboBox2.TabIndex = 13;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.comboBox3.Location = new System.Drawing.Point(90, 121);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(45, 21);
            this.comboBox3.TabIndex = 12;
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(302, 54);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(467, 394);
            this.dataView.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(153, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = ":";
            // 
            // newPeriodBox
            // 
            this.newPeriodBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newPeriodBox.FormattingEnabled = true;
            this.newPeriodBox.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.newPeriodBox.Location = new System.Drawing.Point(224, 351);
            this.newPeriodBox.Name = "newPeriodBox";
            this.newPeriodBox.Size = new System.Drawing.Size(45, 21);
            this.newPeriodBox.TabIndex = 20;
            // 
            // newMinuteBox
            // 
            this.newMinuteBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newMinuteBox.FormattingEnabled = true;
            this.newMinuteBox.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.newMinuteBox.Location = new System.Drawing.Point(173, 351);
            this.newMinuteBox.Name = "newMinuteBox";
            this.newMinuteBox.Size = new System.Drawing.Size(45, 21);
            this.newMinuteBox.TabIndex = 19;
            // 
            // newHourBox
            // 
            this.newHourBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newHourBox.FormattingEnabled = true;
            this.newHourBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.newHourBox.Location = new System.Drawing.Point(102, 351);
            this.newHourBox.Name = "newHourBox";
            this.newHourBox.Size = new System.Drawing.Size(45, 21);
            this.newHourBox.TabIndex = 18;
            // 
            // newDateLabel
            // 
            this.newDateLabel.AutoSize = true;
            this.newDateLabel.Location = new System.Drawing.Point(29, 319);
            this.newDateLabel.Name = "newDateLabel";
            this.newDateLabel.Size = new System.Drawing.Size(30, 13);
            this.newDateLabel.TabIndex = 24;
            this.newDateLabel.Text = "Date";
            // 
            // newDate
            // 
            this.newDate.CustomFormat = "yyyy-MM-dd";
            this.newDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.newDate.Location = new System.Drawing.Point(95, 313);
            this.newDate.Name = "newDate";
            this.newDate.Size = new System.Drawing.Size(95, 20);
            this.newDate.TabIndex = 23;
            // 
            // newClinicLabel
            // 
            this.newClinicLabel.AutoSize = true;
            this.newClinicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newClinicLabel.Location = new System.Drawing.Point(8, 262);
            this.newClinicLabel.Name = "newClinicLabel";
            this.newClinicLabel.Size = new System.Drawing.Size(100, 24);
            this.newClinicLabel.TabIndex = 25;
            this.newClinicLabel.Text = "New Clinic";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(12, 400);
            this.descriptionBox.MaxLength = 45;
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(284, 95);
            this.descriptionBox.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Description";
            // 
            // newClinicButton
            // 
            this.newClinicButton.Location = new System.Drawing.Point(169, 501);
            this.newClinicButton.Name = "newClinicButton";
            this.newClinicButton.Size = new System.Drawing.Size(127, 23);
            this.newClinicButton.TabIndex = 28;
            this.newClinicButton.Text = "Create New Clinic";
            this.newClinicButton.UseVisualStyleBackColor = true;
            this.newClinicButton.Click += new System.EventHandler(this.newClinicButton_Click);
            // 
            // instructorBox
            // 
            this.instructorBox.Location = new System.Drawing.Point(72, 289);
            this.instructorBox.Name = "instructorBox";
            this.instructorBox.Size = new System.Drawing.Size(135, 20);
            this.instructorBox.TabIndex = 29;
            // 
            // instructorLabel
            // 
            this.instructorLabel.AutoSize = true;
            this.instructorLabel.Location = new System.Drawing.Point(15, 295);
            this.instructorLabel.Name = "instructorLabel";
            this.instructorLabel.Size = new System.Drawing.Size(51, 13);
            this.instructorLabel.TabIndex = 30;
            this.instructorLabel.Text = "Instructor";
            // 
            // regButton
            // 
            this.regButton.Location = new System.Drawing.Point(200, 191);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(96, 23);
            this.regButton.TabIndex = 31;
            this.regButton.Text = "View Participants";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 588);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.instructorLabel);
            this.Controls.Add(this.instructorBox);
            this.Controls.Add(this.newClinicButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.newClinicLabel);
            this.Controls.Add(this.newDateLabel);
            this.Controls.Add(this.newDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.newPeriodBox);
            this.Controls.Add(this.newMinuteBox);
            this.Controls.Add(this.newHourBox);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.periodBox_end);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.periodBox);
            this.Controls.Add(this.minuteBox);
            this.Controls.Add(this.hourBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.beginLabel);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Name = "Schedule";
            this.Text = "Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label beginLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox hourBox;
        private System.Windows.Forms.ComboBox minuteBox;
        private System.Windows.Forms.ComboBox periodBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox periodBox_end;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox newPeriodBox;
        private System.Windows.Forms.ComboBox newMinuteBox;
        private System.Windows.Forms.ComboBox newHourBox;
        private System.Windows.Forms.Label newDateLabel;
        private System.Windows.Forms.DateTimePicker newDate;
        private System.Windows.Forms.Label newClinicLabel;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button newClinicButton;
        private System.Windows.Forms.TextBox instructorBox;
        private System.Windows.Forms.Label instructorLabel;
        private System.Windows.Forms.Button regButton;
    }
}
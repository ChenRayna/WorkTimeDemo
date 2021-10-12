
namespace ExceptionWorkTime
{
    partial class FunSubForm
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
            this.labName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labSection = new System.Windows.Forms.Label();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.labShift = new System.Windows.Forms.Label();
            this.txtShift = new System.Windows.Forms.TextBox();
            this.labStartTime = new System.Windows.Forms.Label();
            this.labEndTime = new System.Windows.Forms.Label();
            this.btnPart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbbStart1 = new System.Windows.Forms.ComboBox();
            this.cbbStart2 = new System.Windows.Forms.ComboBox();
            this.cbbEnd1 = new System.Windows.Forms.ComboBox();
            this.cbbEnd2 = new System.Windows.Forms.ComboBox();
            this.btnExceptionName = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(44, 76);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(52, 25);
            this.labName.TabIndex = 6;
            this.labName.Text = "名稱";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(159, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 34);
            this.txtName.TabIndex = 7;
            // 
            // labSection
            // 
            this.labSection.AutoSize = true;
            this.labSection.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSection.Location = new System.Drawing.Point(44, 120);
            this.labSection.Name = "labSection";
            this.labSection.Size = new System.Drawing.Size(52, 25);
            this.labSection.TabIndex = 8;
            this.labSection.Text = "課別";
            // 
            // txtSection
            // 
            this.txtSection.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSection.Location = new System.Drawing.Point(159, 117);
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(191, 34);
            this.txtSection.TabIndex = 9;
            // 
            // labShift
            // 
            this.labShift.AutoSize = true;
            this.labShift.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShift.Location = new System.Drawing.Point(44, 164);
            this.labShift.Name = "labShift";
            this.labShift.Size = new System.Drawing.Size(52, 25);
            this.labShift.TabIndex = 10;
            this.labShift.Text = "班別";
            // 
            // txtShift
            // 
            this.txtShift.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtShift.Location = new System.Drawing.Point(159, 161);
            this.txtShift.Name = "txtShift";
            this.txtShift.Size = new System.Drawing.Size(191, 34);
            this.txtShift.TabIndex = 11;
            // 
            // labStartTime
            // 
            this.labStartTime.AutoSize = true;
            this.labStartTime.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStartTime.Location = new System.Drawing.Point(44, 209);
            this.labStartTime.Name = "labStartTime";
            this.labStartTime.Size = new System.Drawing.Size(92, 25);
            this.labStartTime.TabIndex = 12;
            this.labStartTime.Text = "開始時間";
            // 
            // labEndTime
            // 
            this.labEndTime.AutoSize = true;
            this.labEndTime.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEndTime.Location = new System.Drawing.Point(44, 254);
            this.labEndTime.Name = "labEndTime";
            this.labEndTime.Size = new System.Drawing.Size(92, 25);
            this.labEndTime.TabIndex = 14;
            this.labEndTime.Text = "結束時間";
            // 
            // btnPart
            // 
            this.btnPart.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnPart.Location = new System.Drawing.Point(49, 332);
            this.btnPart.Name = "btnPart";
            this.btnPart.Size = new System.Drawing.Size(101, 43);
            this.btnPart.TabIndex = 16;
            this.btnPart.Text = "OK";
            this.btnPart.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.button1.Location = new System.Drawing.Point(249, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 43);
            this.button1.TabIndex = 17;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbbStart1
            // 
            this.cbbStart1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbbStart1.FormattingEnabled = true;
            this.cbbStart1.Items.AddRange(new object[] {
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
            "23"});
            this.cbbStart1.Location = new System.Drawing.Point(159, 206);
            this.cbbStart1.Name = "cbbStart1";
            this.cbbStart1.Size = new System.Drawing.Size(91, 33);
            this.cbbStart1.TabIndex = 18;
            // 
            // cbbStart2
            // 
            this.cbbStart2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbbStart2.FormattingEnabled = true;
            this.cbbStart2.Items.AddRange(new object[] {
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
            this.cbbStart2.Location = new System.Drawing.Point(259, 206);
            this.cbbStart2.Name = "cbbStart2";
            this.cbbStart2.Size = new System.Drawing.Size(91, 33);
            this.cbbStart2.TabIndex = 19;
            // 
            // cbbEnd1
            // 
            this.cbbEnd1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbbEnd1.FormattingEnabled = true;
            this.cbbEnd1.Items.AddRange(new object[] {
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
            "23"});
            this.cbbEnd1.Location = new System.Drawing.Point(159, 250);
            this.cbbEnd1.Name = "cbbEnd1";
            this.cbbEnd1.Size = new System.Drawing.Size(91, 33);
            this.cbbEnd1.TabIndex = 22;
            // 
            // cbbEnd2
            // 
            this.cbbEnd2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbbEnd2.FormattingEnabled = true;
            this.cbbEnd2.Items.AddRange(new object[] {
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
            this.cbbEnd2.Location = new System.Drawing.Point(259, 250);
            this.cbbEnd2.Name = "cbbEnd2";
            this.cbbEnd2.Size = new System.Drawing.Size(91, 33);
            this.cbbEnd2.TabIndex = 23;
            // 
            // btnExceptionName
            // 
            this.btnExceptionName.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnExceptionName.Location = new System.Drawing.Point(354, 117);
            this.btnExceptionName.Name = "btnExceptionName";
            this.btnExceptionName.Size = new System.Drawing.Size(37, 34);
            this.btnExceptionName.TabIndex = 24;
            this.btnExceptionName.Text = "...";
            this.btnExceptionName.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.button2.Location = new System.Drawing.Point(354, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 34);
            this.button2.TabIndex = 25;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // labCode
            // 
            this.labCode.AutoSize = true;
            this.labCode.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCode.Location = new System.Drawing.Point(44, 33);
            this.labCode.Name = "labCode";
            this.labCode.Size = new System.Drawing.Size(92, 25);
            this.labCode.TabIndex = 26;
            this.labCode.Text = "例外代碼";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCode.Location = new System.Drawing.Point(159, 29);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(191, 34);
            this.txtCode.TabIndex = 27;
            // 
            // FunSubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 401);
            this.Controls.Add(this.labCode);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnExceptionName);
            this.Controls.Add(this.cbbEnd2);
            this.Controls.Add(this.cbbEnd1);
            this.Controls.Add(this.cbbStart2);
            this.Controls.Add(this.cbbStart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPart);
            this.Controls.Add(this.labStartTime);
            this.Controls.Add(this.labEndTime);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labSection);
            this.Controls.Add(this.txtSection);
            this.Controls.Add(this.labShift);
            this.Controls.Add(this.txtShift);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FunSubForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FunForm";
            this.Load += new System.EventHandler(this.FunSubForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labSection;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.Label labShift;
        private System.Windows.Forms.TextBox txtShift;
        private System.Windows.Forms.Label labStartTime;
        private System.Windows.Forms.Label labEndTime;
        private System.Windows.Forms.Button btnPart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbbStart1;
        private System.Windows.Forms.ComboBox cbbStart2;
        private System.Windows.Forms.ComboBox cbbEnd1;
        private System.Windows.Forms.ComboBox cbbEnd2;
        private System.Windows.Forms.Button btnExceptionName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labCode;
        private System.Windows.Forms.TextBox txtCode;
    }
}
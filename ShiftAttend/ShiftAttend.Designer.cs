
namespace ShiftAttend
{
    partial class ShiftAttend
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShiftAttend));
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnModify = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.panTop = new System.Windows.Forms.Panel();
            this.btnCode = new System.Windows.Forms.Button();
            this.labCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.labSection = new System.Windows.Forms.Label();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.labShift = new System.Windows.Forms.Label();
            this.btnPeriodCode = new System.Windows.Forms.Button();
            this.txtShift = new System.Windows.Forms.TextBox();
            this.btnShift = new System.Windows.Forms.Button();
            this.labPeriodCode = new System.Windows.Forms.Label();
            this.btnSection = new System.Windows.Forms.Button();
            this.txtPeriodCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 211);
            this.dgvData.Name = "dgvData";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvData.RowHeadersWidth = 62;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvData.RowTemplate.Height = 31;
            this.dgvData.Size = new System.Drawing.Size(1002, 501);
            this.dgvData.TabIndex = 22;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.toolStripSeparator1,
            this.btnModify,
            this.toolStripSeparator2,
            this.btnDelete,
            this.btnSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 173);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1002, 38);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(34, 33);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // btnModify
            // 
            this.btnModify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
            this.btnModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(34, 33);
            this.btnModify.Text = "Modify";
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(34, 33);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(34, 33);
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panTop
            // 
            this.panTop.Controls.Add(this.btnCode);
            this.panTop.Controls.Add(this.labCode);
            this.panTop.Controls.Add(this.txtCode);
            this.panTop.Controls.Add(this.labSection);
            this.panTop.Controls.Add(this.txtSection);
            this.panTop.Controls.Add(this.labShift);
            this.panTop.Controls.Add(this.btnPeriodCode);
            this.panTop.Controls.Add(this.txtShift);
            this.panTop.Controls.Add(this.btnShift);
            this.panTop.Controls.Add(this.labPeriodCode);
            this.panTop.Controls.Add(this.btnSection);
            this.panTop.Controls.Add(this.txtPeriodCode);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(1002, 173);
            this.panTop.TabIndex = 20;
            // 
            // btnCode
            // 
            this.btnCode.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnCode.Location = new System.Drawing.Point(298, 26);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(37, 34);
            this.btnCode.TabIndex = 15;
            this.btnCode.Text = "...";
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // labCode
            // 
            this.labCode.AutoSize = true;
            this.labCode.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCode.Location = new System.Drawing.Point(28, 29);
            this.labCode.Name = "labCode";
            this.labCode.Size = new System.Drawing.Size(92, 25);
            this.labCode.TabIndex = 13;
            this.labCode.Text = "班別代碼";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCode.Location = new System.Drawing.Point(130, 26);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(165, 34);
            this.txtCode.TabIndex = 14;
            // 
            // labSection
            // 
            this.labSection.AutoSize = true;
            this.labSection.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSection.Location = new System.Drawing.Point(28, 72);
            this.labSection.Name = "labSection";
            this.labSection.Size = new System.Drawing.Size(92, 25);
            this.labSection.TabIndex = 0;
            this.labSection.Text = "生產區段";
            // 
            // txtSection
            // 
            this.txtSection.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSection.Location = new System.Drawing.Point(130, 69);
            this.txtSection.Name = "txtSection";
            this.txtSection.Size = new System.Drawing.Size(165, 34);
            this.txtSection.TabIndex = 1;
            // 
            // labShift
            // 
            this.labShift.AutoSize = true;
            this.labShift.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShift.Location = new System.Drawing.Point(28, 116);
            this.labShift.Name = "labShift";
            this.labShift.Size = new System.Drawing.Size(52, 25);
            this.labShift.TabIndex = 2;
            this.labShift.Text = "班別";
            // 
            // btnPeriodCode
            // 
            this.btnPeriodCode.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnPeriodCode.Location = new System.Drawing.Point(659, 24);
            this.btnPeriodCode.Name = "btnPeriodCode";
            this.btnPeriodCode.Size = new System.Drawing.Size(37, 34);
            this.btnPeriodCode.TabIndex = 12;
            this.btnPeriodCode.Text = "...";
            this.btnPeriodCode.UseVisualStyleBackColor = true;
            // 
            // txtShift
            // 
            this.txtShift.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtShift.Location = new System.Drawing.Point(130, 113);
            this.txtShift.Name = "txtShift";
            this.txtShift.Size = new System.Drawing.Size(165, 34);
            this.txtShift.TabIndex = 3;
            // 
            // btnShift
            // 
            this.btnShift.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnShift.Location = new System.Drawing.Point(298, 113);
            this.btnShift.Name = "btnShift";
            this.btnShift.Size = new System.Drawing.Size(37, 34);
            this.btnShift.TabIndex = 11;
            this.btnShift.Text = "...";
            this.btnShift.UseVisualStyleBackColor = true;
            // 
            // labPeriodCode
            // 
            this.labPeriodCode.AutoSize = true;
            this.labPeriodCode.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPeriodCode.Location = new System.Drawing.Point(389, 27);
            this.labPeriodCode.Name = "labPeriodCode";
            this.labPeriodCode.Size = new System.Drawing.Size(92, 25);
            this.labPeriodCode.TabIndex = 4;
            this.labPeriodCode.Text = "時段代碼";
            // 
            // btnSection
            // 
            this.btnSection.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.btnSection.Location = new System.Drawing.Point(298, 69);
            this.btnSection.Name = "btnSection";
            this.btnSection.Size = new System.Drawing.Size(37, 34);
            this.btnSection.TabIndex = 10;
            this.btnSection.Text = "...";
            this.btnSection.UseVisualStyleBackColor = true;
            // 
            // txtPeriodCode
            // 
            this.txtPeriodCode.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPeriodCode.Location = new System.Drawing.Point(491, 24);
            this.txtPeriodCode.Name = "txtPeriodCode";
            this.txtPeriodCode.Size = new System.Drawing.Size(165, 34);
            this.txtPeriodCode.TabIndex = 5;
            // 
            // ShiftAttend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panTop);
            this.Name = "ShiftAttend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "班組出勤時間";
            this.Load += new System.EventHandler(this.ShiftAttend_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnModify;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.Label labCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label labSection;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.Label labShift;
        private System.Windows.Forms.Button btnPeriodCode;
        private System.Windows.Forms.TextBox txtShift;
        private System.Windows.Forms.Button btnShift;
        private System.Windows.Forms.Label labPeriodCode;
        private System.Windows.Forms.Button btnSection;
        private System.Windows.Forms.TextBox txtPeriodCode;
    }
}


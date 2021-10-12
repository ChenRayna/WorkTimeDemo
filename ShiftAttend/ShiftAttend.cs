using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShiftAttend
{
    public partial class ShiftAttend : Form
    {
        public ShiftAttend()
        {
            InitializeComponent();
        }

        private void ShiftAttend_Load(object sender, EventArgs e)
        {
            SetDataGridViewProperty();
        }

        public void SetDataGridViewProperty()
        {
            dgvData.RowHeadersVisible = false;
            dgvData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.ReadOnly = true;
            dgvData.AllowUserToAddRows = false;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            FunSubForm form = new FunSubForm();
            form.Text = "維護";
            form.ShowDialog();
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            SearchSubForm form = new SearchSubForm();
            form.ShowDialog();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            FunSubForm form = new FunSubForm();
            form.Text = "維護";
            form.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "是否要刪除XXX",
                                   "刪除確認", MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question,
                                   MessageBoxDefaultButton.Button1, 0);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void SearchData()
        {
            dgvData.DataSource = LoadDataGridViewData();
        }

        public DataTable LoadDataGridViewData()
        {
            using (DataTable table = new DataTable())
            {
                table.Columns.Add("班別代碼", typeof(string));
                table.Columns.Add("生產區段", typeof(string));
                table.Columns.Add("代碼", typeof(string));
                table.Columns.Add("開始時間", typeof(string));
                table.Columns.Add("結束時間", typeof(string));
                table.Columns.Add("工作時段代碼", typeof(string));
                table.Rows.Add("1601_TEST-F1夜-1", "F1", "夜班", "0000", "0820", "0000-0820");
                table.Rows.Add("ASSY中(1601)", "ASSY", "中班", "1700", "0120", "1601_1700-0120-ATP");
                table.Rows.Add("DIP中(1601)", "DIP", "中班", "1700", "0120", "1601_1700-0120-ATP");
                table.Rows.Add("DIP日(1601)", "DIP", "早班", "0815", "1650", "1601_0815-1650-D");
                return table;
            }
        }
    }
}

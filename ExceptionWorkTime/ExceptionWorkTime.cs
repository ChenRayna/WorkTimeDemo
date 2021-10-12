using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExceptionWorkTime
{
    public partial class ExceptionWorkTime : Form
    {
        public ExceptionWorkTime()
        {
            InitializeComponent();
        }

        private void ExceptionWorkTime_Load(object sender, EventArgs e)
        {
            SetDataGridViewProperty();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FunSubForm form = new FunSubForm();
            form.Text = "維護";
            form.ShowDialog();
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            SearchSubForm form = new SearchSubForm();
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

        public void SetDataGridViewProperty()
        {
            dgvData.RowHeadersVisible = false;
            dgvData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.ReadOnly = true;
            dgvData.AllowUserToAddRows = false;
        }

        public DataTable LoadDataGridViewData()
        {
            using (DataTable table = new DataTable())
            {
                table.Columns.Add("代碼", typeof(string));
                table.Columns.Add("名稱", typeof(string));
                table.Columns.Add("課別 ", typeof(string));
                table.Columns.Add("班別", typeof(string));
                table.Columns.Add("起始時間", typeof(string));
                table.Columns.Add("結束時間", typeof(string));
                table.Columns.Add("建立日期", typeof(string));
                table.Rows.Add("A01","上午-休息時間", "沖壓課", "沖壓A班",  "10:00", "10:10", "2000/01/01");
                table.Rows.Add("B01", "中午-休息時間", "沖壓課", "沖壓B班", "12:00", "13:00", "2000/01/01");
                table.Rows.Add("C01", "下午-休息時間", "沖壓課", "沖壓C班", "15:00", "15:10", "2000/01/01");
                table.Rows.Add("D01", "晚上-休息時間", "沖壓課", "沖壓D班", "17:00", "18:00", "2000/01/01");
                return table;
            }
        }
    }
}

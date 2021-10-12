using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ResponsibleUnit
{
    public partial class ResponsibleUnit : Form
    {
        public ResponsibleUnit()
        {
            InitializeComponent();
        }

        private void ResponsibleUnit_Load(object sender, EventArgs e)
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

        public DataTable LoadDataGridViewData()
        {
            using (DataTable table = new DataTable())
            {
                table.Columns.Add("單位代碼", typeof(string));
                table.Columns.Add("單位名稱", typeof(string));
                table.Columns.Add("建立日期", typeof(string));
                table.Rows.Add("R1", "營運中心", "2000/01/01");
                table.Rows.Add("R2", "製造一部", "2000/01/02");
                table.Rows.Add("R3", "倉庫", "2000/01/03");
                return table;
            }
        }

        private void SearchData()
        {
            dgvData.DataSource = LoadDataGridViewData();
        }

        private void OpenSubForm()
        {
            SearchSubForm form = new SearchSubForm();
            form.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FunSubForm form = new FunSubForm();
            form.Text = "維護";
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

        private void btnUnit_Click(object sender, EventArgs e)
        {
            OpenSubForm();
        }
    }
}

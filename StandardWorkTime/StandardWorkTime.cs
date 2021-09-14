using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo001
{
    public partial class StandardWorkTime : Form
    {
        public StandardWorkTime()
        {
            InitializeComponent();
        }

        private void StandardWorkTime_Load(object sender, EventArgs e)
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
                table.Columns.Add("料號", typeof(string));
                table.Columns.Add("機台", typeof(string));
                table.Columns.Add("線別 ", typeof(string));
                table.Columns.Add("標準工時", typeof(float));
                table.Rows.Add("123456", "Coating", "自動化R1", 0.04);
                table.Rows.Add("QWERTY", "Coating", "自動化R1", 0.99);
                table.Rows.Add("ASDFGH", "Coating", "自動化R1", .073);
                table.Rows.Add("ZXCVBN", "Coating", "自動化R1", .022);
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

        private void btnPart_Click(object sender, EventArgs e)
        {
            OpenSubForm();
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
    }
}

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
    public partial class SearchSubForm : Form
    {
        public SearchSubForm()
        {
            InitializeComponent();
        }

        private void SearchSubForm_Load(object sender, EventArgs e)
        {
            SetDataGridViewProperty();
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
                table.Columns.Add("欄位1", typeof(string));
                table.Columns.Add("欄位2", typeof(string));
                table.Rows.Add("1111", "測試用1");
                table.Rows.Add("2222", "測試用2");
                table.Rows.Add("3333", "測試用3");
                table.Rows.Add("5555", "測試用4");
                return table;
            }
        }
    }
}

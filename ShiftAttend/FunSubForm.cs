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
    public partial class FunSubForm : Form
    {
        public FunSubForm()
        {
            InitializeComponent();
        }

        private void FunSubForm_Load(object sender, EventArgs e)
        {
            cbbStart1.SelectedIndex = 0;
            cbbStart2.SelectedIndex = 0;
            cbbEnd1.SelectedIndex = 0;
            cbbEnd2.SelectedIndex = 0;
        }
    }
}

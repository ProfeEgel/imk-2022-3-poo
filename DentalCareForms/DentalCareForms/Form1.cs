using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLiteDb;

namespace DentalCareForms
{
    public partial class Form1 : Form
    {
        private SQLiteConn conn;

        public Form1()
        {
            InitializeComponent();

            conn = new SQLiteConn("dentalcaredata.db");
            conn.Open();

            cmbDays.DataSource = conn.GetDays();
            cmbDays.DisplayMember = "Name";
            cmbDays.ValueMember = "Id";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

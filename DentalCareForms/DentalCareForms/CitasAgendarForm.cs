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
    public partial class CitasAgendarForm : Form
    {
        SQLiteConn conn;

        public CitasAgendarForm(SQLiteConn conn)
        {
            InitializeComponent();
            this.conn = conn;
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {

        }
    }
}

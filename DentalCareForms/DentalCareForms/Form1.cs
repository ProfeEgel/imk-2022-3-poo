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

            cmbDays.DisplayMember = "Name";
            cmbDays.ValueMember = "Id";
            cmbDays.DataSource = conn.GetDays();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dayId = (int)cmbDays.SelectedValue;
            var appointments = conn.GetAppointmentsByTime(dayId);
            dgvAppointments.DataSource = appointments;
        }

        private void citasPorPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new CitasPorPacienteForm(conn);
            form.ShowDialog();
        }

        private void agendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new CitasAgendarForm(conn);
            form.ShowDialog();
        }
    }
}

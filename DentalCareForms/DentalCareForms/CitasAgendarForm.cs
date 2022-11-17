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

            cmbPacientes.DisplayMember = "FullName";
            cmbPacientes.ValueMember = "Id";
            cmbPacientes.DataSource = conn.GetAvailablePatients();

            cmbDias.DisplayMember = "Name";
            cmbDias.ValueMember = "Id";
            cmbDias.DataSource = conn.GetAvailableDays();
        }

        private void cmbDias_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dayId = (int)cmbDias.SelectedValue;

            cmbHoras.DisplayMember = "Description";
            cmbHoras.ValueMember = "Id";
            cmbHoras.DataSource = conn.GetAvailableTimes(dayId);
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            int patientId = (int)cmbPacientes.SelectedValue;
            int dayId = (int)cmbDias.SelectedValue;
            int timeId = (int)cmbHoras.SelectedValue;

            conn.GenerateAppointment(patientId, dayId, timeId);

            MessageBox.Show("¡Cita realizada con éxito!",
                            "Aviso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            Close();
        }
    }
}

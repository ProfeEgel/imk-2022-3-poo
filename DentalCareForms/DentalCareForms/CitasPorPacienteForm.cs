using SQLiteDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalCareForms
{
    public partial class CitasPorPacienteForm : Form
    {
        public CitasPorPacienteForm(SQLiteConn conn)
        {
            InitializeComponent();

            dgvAppointments.DataSource = conn.GetAppointmentsByPatient();
        }
    }
}

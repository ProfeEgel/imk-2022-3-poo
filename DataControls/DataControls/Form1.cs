using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // #1 => strings - Items
            lstPatients.Items.Add("Lopez, Javier");
            lstPatients.Items.Add("Izquierdo, Minerva");
            lstPatients.Items.Add("Chavez, Erika");
            lstPatients.Items.Add("Monforte, Miguel");
            lstPatients.Items.Add("Quintal, Elizabeth");
            lstPatients.Items.Add("Perez, Juan");
            lstPatients.Items.Add("Martin, Carlos");

            // #2 => objects - Items
            //...

            // #3 => strings - DataSource
            // No funcionan botones
            //List<string> patients = new List<string>();
            //patients.Add("Lopez, Javier");
            //patients.Add("Izquierdo, Minerva");
            //patients.Add("Chavez, Erika");
            //patients.Add("Monforte, Miguel");
            //patients.Add("Quintal, Elizabeth");
            //patients.Add("Perez, Juan");
            //patients.Add("Martin, Carlos");
            //
            //lstPatients.DataSource = patients;

            // #4 => objects - DataSource
            List<Patient> patients = new List<Patient>();
            patients.Add(new Patient(687, "Javier", "Lopez"));
            patients.Add(new Patient(351, "Minerva", "Izquierdo"));
            patients.Add(new Patient(366, "Erika", "Chavez"));
            patients.Add(new Patient(743, "Miguel", "Monforte"));
            patients.Add(new Patient(975, "Elizabeth", "Quintal"));
            patients.Add(new Patient(372, "Juan", "Perez"));
            patients.Add(new Patient(489, "Carlos", "Martis"));

            lstPatients.DisplayMember = "FullName";
            lstPatients.ValueMember = "Id";
            lstPatients.DataSource = patients;
        }

        private void lstPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            // #1 => strings - Items
            //txtIndex.Text = lstPatients.SelectedIndex.ToString();
            //txtItem.Text = lstPatients.SelectedItem.ToString();
            //txtValue.Text = "N/A";

            // #3 => strings - Lists
            // #4 => objects - DataSource
            txtIndex.Text = lstPatients.SelectedIndex.ToString();
            txtItem.Text = lstPatients.SelectedItem.ToString();
            txtValue.Text = lstPatients.SelectedValue.ToString();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void verifySyntaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verifySyntaxToolStripMenuItem.Checked
                = !verifySyntaxToolStripMenuItem.Checked;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

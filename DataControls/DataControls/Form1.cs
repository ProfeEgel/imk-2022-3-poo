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


        }

        private void lstPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIndex.Text = lstPatients.SelectedIndex.ToString();
            txtItem.Text = lstPatients.SelectedItem.ToString();
            //txtValue.Text = lstPatients.SelectedValue.ToString();
        }
    }
}

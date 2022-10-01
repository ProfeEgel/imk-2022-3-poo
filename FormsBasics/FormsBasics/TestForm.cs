using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsBasics
{
    public partial class TestForm : Form
    {
        private int contador = 0;
        private List<CheckBox> lstColors;

        public TestForm()
        {
            InitializeComponent();

            txtTest.Text = "Contador: 0";

            lstColors = new List<CheckBox>();
            lstColors.Add(chkRojo);
            lstColors.Add(chkAzul);
            lstColors.Add(chkVerde);
            lstColors.Add(chkCyan);
            lstColors.Add(chkMagenta);
            lstColors.Add(chkAmarillo);

            radMercurio.Checked = true;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            txtTest.Text = $"Contador: {++contador}";
            //txtTest.Text = "Esto es una prueba...";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Esto es un mensajito...",
                                    "Aviso",
                                    MessageBoxButtons.YesNoCancel,
                                    MessageBoxIcon.Warning))
            {
                case DialogResult.Yes:
                    MessageBox.Show("Selección: SI");
                    break;

                case DialogResult.No:
                    MessageBox.Show("Selección: NO");
                    break;

                case DialogResult.Cancel:
                    MessageBox.Show("Selección: CANCELAR");
                    break;

                default:
                    break;
            }
        }

        private void chkRojo_CheckedChanged(object sender, EventArgs e)
        {
            List<string> lstColorsText = new List<string>();

            lstColors
                .FindAll(chk => chk.Checked)
                .ForEach(chk => lstColorsText.Add(chk.Text));

            txtColors.Text = String.Join("+", lstColorsText);
        }

        private void radMercurio_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;

            if (radio.Checked)
            {
                txtPlanets.Text = radio.Text;
            }
        }
    }
}

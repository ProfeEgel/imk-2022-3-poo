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

        public TestForm()
        {
            InitializeComponent();

            txtTest.Text = "Contador: 0";
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
    }
}

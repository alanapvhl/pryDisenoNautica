using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryDisenoNautica
{
    public partial class frmAlquileres : Form
    {
        public frmAlquileres()
        {
            InitializeComponent();
        }

        private void tboDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbodni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tboHoras_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtdni_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                e.Handled = true;
            }
        }



        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if ((tboHoras.Text == "") || (tboHoras.Text == "0"))
            {
                MessageBox.Show("Por favor, ingrese la cantidad de horas.");
            }


        }

        private void tboNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cboEmbargacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmAlquileres_Load(object sender, EventArgs e)
        {

            if (tboNombre.Text.Length > 0 && tboDni.Text.Length > 0 && cboEmbargacion.SelectedIndex != -1 && tboHoras.Text.Length > 0)
            {
                btnCalcular.Enabled = true;
            }
            else
            {  
                btnCalcular.Enabled = false;
            }
           


        }

        private void tboDni_TextChanged_1(object sender, EventArgs e)
        {
            
        }
    }
}

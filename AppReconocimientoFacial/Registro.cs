using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios_DCU;

namespace AppReconocimientoFacial
{
    public partial class Registro : Form
    {
        Class1 objetoCN = new Class1();
        private int IdCliente;
        public Registro()
        {
            InitializeComponent();
        }

        private void limpiarForm()
        {
            
            txtNombre.Clear();
            txtCedula.Clear();
            txtEdad.Clear();
            txtEmail.Clear();
            txtNotas.Clear();
            txtTel.Clear();
           
            /*
             * limpiar todos los combo box y checkbox
             * 
             */

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Quieres realizar los cambios ?", "Warning",
            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (objetoCN.Editar == false)
                {
                    try
                    {

                        objetoCN.InsertarCliente(txtNombre.Text, Convert.ToInt32(txtCedula.Text), Convert.ToInt32(txtEdad.Text), CBgenero.Text, CBNacionalidad.Text, txtEmail.Text, txtTel.Text, CBTipoPiel.Text, checkedListBox1.Text, checkedListBox2.Text, txtNotas.Text);
                        MessageBox.Show("se inserto correctamente");
                        limpiarForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("no se pudo insertar los datos por: " + ex);
                    }
                }

            }
            else if (result == DialogResult.No)
            {
                limpiarForm();
                
            }
            else if (result == DialogResult.Cancel)
            {
                limpiarForm();
                MessageBox.Show("Ha sido cancelado");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



       
    }
}

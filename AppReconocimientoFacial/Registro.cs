using Negocios_DCU;
using System;
using System.Windows.Forms;

namespace AppReconocimientoFacial
{
    public partial class Registro : Form
    {
        Class1 objetoCN = new Class1();
        //private int IdCliente;
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


            for (int i = 0; i < checkCondicionPiel.Items.Count; i++)
            {
                checkCondicionPiel.SetItemChecked(i, false);
                for (int a = 0; a < checkEnfermedades.Items.Count; a++)
                {
                    checkEnfermedades.SetItemChecked(a, false);
                }
            }


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
                        //revisar esta parte por los check box

                        //objetoCN.InsertarCliente(txtNombre.Text, Convert.ToInt32(txtCedula.Text), Convert.ToInt32(txtEdad.Text), CBgenero.Text, CBNacionalidad.Text, txtEmail.Text, txtTel.Text, CBTipoPiel.Text, txtNotas.Text);
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

        private void btnCapturarRostro_Click(object sender, EventArgs e)
        {
            //abrir reconocimiento facial
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
        }

        private void txtCedula_Click(object sender, EventArgs e)
        {
            txtCedula.Clear();
        }

        private void txtEdad_Click(object sender, EventArgs e)
        {
            txtEdad.Clear();
        }

    }





}


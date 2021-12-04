using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppReconocimientoFacial
{
    public partial class Registro : Form
    {
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


            for(int i=0; i <checkCondicionPiel.Items.Count; i++)
            {
                checkCondicionPiel.SetItemChecked(i, false);
                for(int a =0; a <checkEnfermedades.Items.Count; a++)
                {
                    checkEnfermedades.SetItemChecked(a, false);
                }
            }
            

            dateTimePicker1.Value = DateTime.Today;

        }

        private void txtTelefono_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }
    }
}

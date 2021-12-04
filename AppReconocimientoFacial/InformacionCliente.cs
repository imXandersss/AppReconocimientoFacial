using System;
using System.Windows.Forms;

namespace AppReconocimientoFacial
{
    public partial class InformacionCliente : Form
    {
        public InformacionCliente()
        {
            InitializeComponent();
        }

        private void txtEnfermedad_TextChanged(object sender, EventArgs e)
        {
            txtEnfermedad.ReadOnly = true;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.ReadOnly = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtEnfermedad.ReadOnly = true;
        }

        private void txtNota_TextChanged(object sender, EventArgs e)
        {
            txtNota.ReadOnly = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Aqui va el metodo que devuelve el formulario principal
        }
    }
}

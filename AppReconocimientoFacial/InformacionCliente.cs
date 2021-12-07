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
    public partial class InformacionCliente : Form
    {
        public InformacionCliente()
        {
            InitializeComponent();

        }

        //private void txtEnfermedad_TextChanged(object sender, EventArgs e)
        //{
        //    txtEnfermedad.ReadOnly = true;
        //}

        //private void txtNombre_TextChanged(object sender, EventArgs e)
        //{
        //    txtNombre.ReadOnly = true;
        //}

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    txtEnfermedad.ReadOnly = true;
        //}

        //private void txtNota_TextChanged(object sender, EventArgs e)
        //{
        //    txtNota.ReadOnly = true;
        //}

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void MostrarCliente()
        {
            Class1 objeto = new Class1();
            dataGridView1.DataSource = objeto.InfoCliente(Convert.ToInt32(FaceRecognition.Cedula));
        }

        private void InformacionCliente_Load(object sender, EventArgs e)
        {

        }

        //private void InformacionCliente_Load(object sender, EventArgs e)
        //{
        //    MostrarCliente();
        //    //fechaPicker.Format = DateTimePickerFormat.Short;
        //    //fechaPicker.Value = DateTime.Today;

        //    //DatosClase datosClase = new DatosClase();
        //    //datosClase.InformacionCliente(Convert.ToInt32(FaceRecognition.Cedula));

        //    //txtNombre.Text = DatosClase.Nombre;
        //    //txtEnfermedad.Text = DatosClase.Enfermedad;
        //    //txtNota.Text = DatosClase.Nota;
        //    ////fechaPicker.Value = Convert.ToDateTime( DatosClase.Fecha);
        //    //textBox1.Text = DatosClase.CondicionPiel;
        //}

        private void InformacionCliente_Load_1(object sender, EventArgs e)
        {
            MostrarCliente();
        }
    }
}

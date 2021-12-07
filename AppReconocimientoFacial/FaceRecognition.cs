using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;
using Datos;

namespace AppReconocimientoFacial
{
    public partial class FaceRecognition : Form
    {
        private static string cedula;
        public FaceRecognition()
        {
            InitializeComponent();
        }
        FaceRec faceid = new FaceRec();

        public static string Cedula { get => cedula; set => cedula = value; }

        private void FaceRecognition_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            faceid.openCamera(pictureBox1,pictureBox2);
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            faceid.Save_IMAGE(textBox1.Text);
            MessageBox.Show("Imagen guardada");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            faceid.isTrained = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cedula = textBox1.Text;
            InformacionCliente informacionCliente = new InformacionCliente();
            informacionCliente.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

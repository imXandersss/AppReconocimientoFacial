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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarAgenda();
        }

        private void MostrarAgenda()
        {
            Class1 objeto = new Class1();
            dataGridView1.DataSource = objeto.MostrarProd();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.ShowDialog();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.ShowDialog();
        }

        private void personalizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Citas citas = new Citas();
            citas.ShowDialog();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog1.Color;
                this.BackColor = color;
                
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //abre la ventana de reconocimiento facial
        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //abrir una ventana que diga las informaciones importantes a saber
        }
    }
}

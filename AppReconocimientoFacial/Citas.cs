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
    public partial class Citas : Form
    {
        Class1 objetoCN = new Class1();
        private int IdCita;

        public Citas()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Citas_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Value = DateTime.Today;
            MostrarAgenda();
        }

        private void MostrarAgenda()
        {
            Class1 objeto = new Class1();
            dataGridView1.DataSource = objeto.MostrarProd();
        }

        private void limpiarForm()
        {
            txtComentario.Clear();
            txtNombre.Clear();
            txtIDcliente.Clear();
            dateTimePicker1.Value = DateTime.Today;
            

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                objetoCN.Editar = true;
                IdCita = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdCita"].Value.ToString());
                txtIDcliente.Text = dataGridView1.CurrentRow.Cells["IdCliente"].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["nombreCliente"].Value.ToString();
                txtComentario.Text = dataGridView1.CurrentRow.Cells["comentario"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["fecha"].Value.ToString());

            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                IdCita = Convert.ToInt32(dataGridView1.CurrentRow.Cells["IdCita"].Value.ToString());
                objetoCN.EliminarPRod(IdCita);
                MessageBox.Show("Eliminado correctamente");
                
                MostrarAgenda();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (objetoCN.Editar == false)
            {
                try
                {

                    objetoCN.InsertarPRod(Convert.ToInt32(txtIDcliente.Text), txtNombre.Text, dateTimePicker1.Value.ToString() ,txtComentario.Text);
                    MessageBox.Show("se inserto correctamente");
                    MostrarAgenda();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
            //EDITAR
            if (objetoCN.Editar == true)
            {
                try
                {
                    

                    objetoCN.EditarProd(IdCita, Convert.ToInt32(txtIDcliente.Text), txtNombre.Text, dateTimePicker1.Value.ToString(), txtComentario.Text);
                    MessageBox.Show("se edito correctamente");
                    MostrarAgenda();
                    limpiarForm();
                    objetoCN.Editar = false;

                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }
        }

        private void BuscarCitas()
        {
            Class1 objeto1 = new Class1();
            dataGridView1.DataSource = objeto1.BuscarProd(txtNombre.Text);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                BuscarCitas();
                limpiarForm();

                if (dataGridView1.RowCount <= 1)
                {
                    MessageBox.Show("no se encontro ningun archivo, revise el nombre y vuelvalo a escribir");
                    MostrarAgenda();
                    limpiarForm();
                }


            }
            catch
            {
                MessageBox.Show("Se produjo un error en el sistema");
                MostrarAgenda();
                limpiarForm();
            }
        }
    }
}

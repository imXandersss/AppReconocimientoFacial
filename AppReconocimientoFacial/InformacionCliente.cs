using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void BaseDatos()
        {


            string queryString =
            "SELECT OrderID, CustomerID FROM dbo.Orders;";

            using (SqlConnection connection =
                       new SqlConnection("Server = DESKTOP-3B0O51K\\MYSERVER;DataBase=Estetica;Integrated Security = true"))
            {
                SqlCommand command =
                    new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                // Call Read before accessing data.
                while (reader.Read())
                {
                    ReadSingleRow((IDataRecord)reader);
                }

                // Call Close when done reading.
                reader.Close();


            }
        }

        private static void ReadSingleRow(IDataRecord dataRecord)
        {
            //aqui deberia poner los textbox con las informaciones
        }


        private void button1_Click(object sender, EventArgs e)
        {
              
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}

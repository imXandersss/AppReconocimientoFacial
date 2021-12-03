using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosClase
    {
        private static string connectionString = "Server = DESKTOP-3B0O51K\\MYSERVER;DataBase=Estetica;Integrated Security = true";

        SqlConnection conexion = new SqlConnection(connectionString);
        public SqlConnection OpenBD()
        {

            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }

        public SqlConnection CloseBD()
        {

            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }


        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar()
        {

            comando.Connection = OpenBD();
            comando.CommandText = "MostrarCitas";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            CloseBD();
            return tabla;

        }

        public DataTable Buscar(string nombreCliente)
        {

            comando.Connection = OpenBD();
            comando.CommandText = "BuscarCitas";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombreCliente", nombreCliente);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            CloseBD();
            return tabla;

        }


        public void Insertar(int IdCliente, string nombreCliente, DateTime fecha, string Comentario)
        {
            comando.Connection = OpenBD();
            comando.CommandText = "InsertCita";
            comando.CommandType = CommandType.StoredProcedure;
            //comando.Parameters.AddWithValue("@IdCita", IdCita);
            comando.Parameters.AddWithValue("@IdCliente", IdCliente);
            comando.Parameters.AddWithValue("@nombreCliente", nombreCliente);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@comentario", Comentario);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            CloseBD();
        }

        // TOMAR EN CUENTA EL TIPO DE DATOS DE FECHA
        public void Modificar(int IdCita, int IdCliente, string nombreCliente, DateTime fecha, string Comentario)
        {
            comando.Connection = OpenBD();
            comando.CommandText = "UpdateCita";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdCita", IdCita);
            comando.Parameters.AddWithValue("@IdCliente", IdCliente);
            comando.Parameters.AddWithValue("@nombreCliente", nombreCliente);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@comentario", Comentario);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            CloseBD();
        }
        public void Eliminar(int IdCita)
        {
            comando.Connection = OpenBD();
            comando.CommandText = "DeleteCitas";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdCita", IdCita);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            CloseBD();
        }
    }
}

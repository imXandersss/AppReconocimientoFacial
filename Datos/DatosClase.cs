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
        private static string nombre;
        private static string fecha;
        private static string condicionPiel;
        private static string enfermedad;
        private static string nota;


        public static string Nombre { get => nombre; set => nombre = value; }
        public static string Fecha { get => fecha; set => fecha = value; }
        public static string CondicionPiel { get => condicionPiel; set => condicionPiel = value; }
        public static string Enfermedad { get => enfermedad; set => enfermedad = value; }
        public static string Nota { get => nota; set => nota = value; }

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
            comando.Parameters.AddWithValue("@IdCliente", IdCliente);
            comando.Parameters.AddWithValue("@nombreCliente", nombreCliente);
            comando.Parameters.AddWithValue("@fecha", fecha);
            comando.Parameters.AddWithValue("@comentario", Comentario);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            CloseBD();
        }

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
        public void insertarCliente(string nombre,int cedula, int edad, string genero,string nacionalidad,string email, string telefono, string tipoPiel, string condicionPiel, string enfermedades, string nota)
        {
            //OpenConexion
            comando.Connection = OpenBD();
            comando.CommandText = "InsertCliente";
            comando.CommandType = CommandType.StoredProcedure;
            //values
            comando.Parameters.AddWithValue("@nombre",nombre);
            comando.Parameters.AddWithValue("@cedula", cedula);
            comando.Parameters.AddWithValue("@edad",edad);
            comando.Parameters.AddWithValue("@genero",genero);
            comando.Parameters.AddWithValue("@nacionalidad",nacionalidad);
            comando.Parameters.AddWithValue("@email",email);
            comando.Parameters.AddWithValue("@telefono",telefono);
            comando.Parameters.AddWithValue("@tipoPiel",tipoPiel);
            comando.Parameters.AddWithValue("@condicionPiel",condicionPiel);
            comando.Parameters.AddWithValue("@enfermedades",enfermedades);
            comando.Parameters.AddWithValue("@nota",nota);

            //Executig query + closing database
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            CloseBD();
        }


        public void InformacionCliente(int cedula)
        {

            comando.Connection = OpenBD();
            comando.CommandText = "InfoCliente";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@ID", cedula);
            
            leer = comando.ExecuteReader();
            if (leer.Read())
            {
                Nombre = leer["nombre"].ToString();
                CondicionPiel = leer["condicionPiel"].ToString();
                fecha = leer["fecha"].ToString();
                Enfermedad = leer["enfermedades"].ToString();
                Nota = leer["nota"].ToString();
            }
            leer.Close();
            comando.Parameters.Clear();
            CloseBD();
        }

        //public void modificarCliente(string nombre, int cedula, int edad, string genero, string nacionalidad, string email, string telefono, string tipoPiel, string condicionPiel, string enfermedades, string nota)
        //{
        //    //OpenConexion
        //    comando.Connection = OpenBD();
        //    comando.CommandText = "UpdateCliente";
        //    comando.CommandType = CommandType.StoredProcedure;
        //    //values
        //    comando.Parameters.AddWithValue("@nombre", nombre);
        //    comando.Parameters.AddWithValue("@cedula", cedula);
        //    comando.Parameters.AddWithValue("@edad", edad);
        //    comando.Parameters.AddWithValue("@genero", genero);
        //    comando.Parameters.AddWithValue("@nacionalidad", nacionalidad);
        //    comando.Parameters.AddWithValue("@email", email);
        //    comando.Parameters.AddWithValue("@telefono", telefono);
        //    comando.Parameters.AddWithValue("@tipoPiel", tipoPiel);
        //    comando.Parameters.AddWithValue("@condicionPiel", condicionPiel);
        //    comando.Parameters.AddWithValue("@enfermedades", enfermedades);
        //    comando.Parameters.AddWithValue("@nota", nota);

        //    //Executig query + closing database
        //    comando.ExecuteNonQuery();
        //    comando.Parameters.Clear();
        //    CloseBD();


        //}

        //public void buscarCliente(int cedula)
        //{
        //    //OpenConexion
        //    comando.Connection = OpenBD();
        //    comando.CommandText = "Cliente";
        //    comando.CommandType = CommandType.StoredProcedure;
        //    //values
        //    comando.Parameters.AddWithValue("@cedula", cedula);
        //    //Executig query + closing database
        //    comando.ExecuteNonQuery();
        //    comando.Parameters.Clear();
        //    CloseBD();


        //}

    }
}


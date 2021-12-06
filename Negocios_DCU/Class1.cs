using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;


namespace Negocios_DCU
{
    public class Class1
    {

        private DatosClase objetoCD = new DatosClase();
        public bool Editar = false;
        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void InsertarPRod(int IdCliente, string nombreCliente, string fecha, string Comentario)
        {
            objetoCD.Insertar(IdCliente, nombreCliente, Convert.ToDateTime(fecha), Comentario);
        }
        public void EditarProd( int IdCita ,int IdCliente, string nombreCliente, string fecha, string Comentario)
        {
            objetoCD.Modificar(IdCita, IdCliente, nombreCliente, Convert.ToDateTime(fecha), Comentario);
        }
        public void EliminarPRod(int IdCita)
        {
            objetoCD.Eliminar(IdCita);
        }

        public void InsertarCliente(string nombre, int cedula, int edad, string genero, string nacionalidad, string email, string telefono, string tipoPiel, string condicionPiel, string enfermedades, string nota)
        {
            objetoCD.insertarCliente(nombre, cedula, edad, genero, nacionalidad, email, telefono, tipoPiel, condicionPiel, enfermedades, nota);
        }
        //public void EditarCliente(string nombre, int cedula, int edad, string genero, string nacionalidad, string email, string telefono, string tipoPiel, string condicionPiel, string enfermedades, string nota)
        //{
        //    //objetoCD.ModificarCliente(nombre, cedula, edad, genero, nacionalidad, email, telefono, tipoPiel, condicionPiel, enfermedades, nota);
        //}

        //public void BuscarCliente(int cedula)
        //{
        //    //objetoCD.BuscarCliente(cedula);
        //}

        public DataTable BuscarProd(string Descripcion)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Buscar(Descripcion);
            return tabla;
        }
    }
}

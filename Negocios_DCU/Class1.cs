using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;


namespace Negocios_DCU
{
    public class Class1
    {

        private Datos objetoCD = new Datos();
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

        public DataTable BuscarProd(string Descripcion)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Buscar(Descripcion);
            return tabla;
        }
    }
}

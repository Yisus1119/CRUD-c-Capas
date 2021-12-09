using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace SolucionPrimerRetoEstudio
{

    /*En esta capa/clase de negocios realizaremos la lógica de nuestra aplicación, en ésta vamos a crear métodos para
    invocar a los métodos (valga la redundancia) creados previamente en la capa de acceso a datos. */
    public class Negocios
    {
        private Datos objetoDatos = new Datos();


        //Datatable para mostrar las mercancias en el dataGridView.
        public DataTable MostrarMercancias()
        {
            DataTable tabla = new DataTable();
            tabla = objetoDatos.Mostrar();
            return tabla;
        }

        /* Aquí los métodos para cada función del CRUD. En cada método estamos llamando a la lógica de cada método
        de la capa/clase Datos. */
        public void InsertarMercancia (string Descripcion, string Existencia, string Comentario, string Status, string NoEliminable) {
            objetoDatos.Insertar(Descripcion, Convert.ToInt32(Existencia), Comentario, Status, Convert.ToByte( NoEliminable));
        }

        public void ActualizarMercancia(string IdMercancia, string Descripcion, string Existencia, string Comentario, string Status, string NoEliminable)
        {
            objetoDatos.Actualizar(Convert.ToInt32(IdMercancia), Descripcion, Convert.ToInt32(Existencia), Comentario, Status, Convert.ToByte(NoEliminable));
        }

        public void BorrarMercancia(string IdMercancia)
        {
            objetoDatos.Eliminar(Convert.ToInt32(IdMercancia));
        }




    }
}

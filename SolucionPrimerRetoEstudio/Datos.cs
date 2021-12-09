using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace SolucionPrimerRetoEstudio
{
    //En esta clase datos es en donde crearemos todos nuestros métodos para hacer posible la creación del CRUD.

    class Datos
    {
        public static SqlConnection OpenDB()
        {
            //Aquí creamos nuestra conexión ADO.NET entre nuestro equipo y el servidor local de SQL.
            SqlConnection connection = new SqlConnection
                (
                "SERVER=LAPTOP-MOE4MLMT; DATABASE=MiPrimeraVez; integrated security=true;"
                );

            connection.Open();
            return connection;
        }

        //Aquí declararemos varíables que utilizaremos para hacer las conexiones y el llenado de tabla.
        SqlDataReader leerMercancias;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        /* Los dos primeros métodos están realizados a través de procedimientos almnacenados (store procedures), dichos procedimientos se 
        encuentran en el Script de la Base de Datos. */

        //Método para mostrar los datos en el DataGridView.
        public DataTable Mostrar()
        {
            comando.Connection =  Datos.OpenDB();
            comando.CommandText = "MostrarMercancias";
            comando.CommandType = CommandType.StoredProcedure;
            leerMercancias = comando.ExecuteReader();
            tabla.Load(leerMercancias);
            return tabla;      
        }

        //Método para Insertar las mercancías a nuestra base de datos.
        public void Insertar(string Descripcion, int Existencia, string Comentario, string Status, byte NoEliminable)
        {
            comando.Connection = Datos.OpenDB();
            comando.CommandText = "InsertarMercancia";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Descripcion", Descripcion);
            comando.Parameters.AddWithValue("@Existencia", Existencia);
            comando.Parameters.AddWithValue("@Comentario", Comentario);
            comando.Parameters.AddWithValue("@Status", Status);
            comando.Parameters.AddWithValue("@NoEliminable", NoEliminable);

            comando.ExecuteNonQuery();
        }


        //Realicé los últimos 2 métodos de manera manual o (hard code) para que se pueda visualizar los diferentes métodos existentes.

        //método para Actualizar nuestras mercancías.
        public void Actualizar(int IdMercancia, string Descripcion, int Existencia, string Comentario, string Status, byte NoEliminable)
        {
            comando.Connection = Datos.OpenDB();
            string actualizar = "UPDATE Mercancias SET Descripcion=@Descripcion, " +
                "@Existencia=@Existencia, Comentario=@Comentario, Status=@Status, NoEliminable=@NoEliminable WHERE IdMercancia=@IdMercancia";

            SqlCommand comandoActualizar = new SqlCommand(actualizar, comando.Connection = Datos.OpenDB());
            comandoActualizar.Parameters.AddWithValue("@IdMercancia", IdMercancia);
            comandoActualizar.Parameters.AddWithValue("@Descripcion", Descripcion);
            comandoActualizar.Parameters.AddWithValue("@Existencia", Existencia);
            comandoActualizar.Parameters.AddWithValue("@Comentario", Comentario);
            comandoActualizar.Parameters.AddWithValue("@Status", Status);
            comandoActualizar.Parameters.AddWithValue("@NoEliminable",NoEliminable);

            comandoActualizar.ExecuteNonQuery();
        }

        //Método para Eliminar la mercancía seleccionada.
        public void Eliminar(int IdMercancia)
        {
            comando.Connection = Datos.OpenDB();
            string borrar = "DELETE FROM Mercancias WHERE IdMercancia=@IdMercancia";

            SqlCommand comandoBorrar = new SqlCommand(borrar, comando.Connection = Datos.OpenDB());
            comandoBorrar.Parameters.AddWithValue("@IdMercancia", IdMercancia);

            comandoBorrar.ExecuteNonQuery();
        }




    }
}

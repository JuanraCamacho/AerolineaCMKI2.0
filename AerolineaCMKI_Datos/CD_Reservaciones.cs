using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AerolineaCMKI_Datos;


namespace AerolineaCMKI_Datos
{
    public class CD_Reservaciones
    {
        CD_Conexion conexion = new CD_Conexion();//iniciamos la instancia de la conexios

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarReservacionesN";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();//ejecuta 
            tabla.Load(leer);//la tabla sera rellenada con lo que lea
            conexion.CerrarConexion();
            return tabla;
            //gg

        }

       
        public DataTable ListarAviones()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "listaVuelo";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();//ejecuta 
            tabla.Load(leer);//la tabla sera rellenada con lo que lea
            conexion.CerrarConexion();
            return tabla;
        }

       
        

        public void InsertarReserva(String nombres, String apellidos, int telefono, int idVuelo, String asiento, char fila)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarReservacionesN";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", nombres);
            comando.Parameters.AddWithValue("@Apellidos", apellidos);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            comando.Parameters.AddWithValue("@IdVuelo", idVuelo);
            comando.Parameters.AddWithValue("@Asiento", asiento);
            comando.Parameters.AddWithValue("@Fila", fila);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }

   
        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarReservacionesN";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
    }
}

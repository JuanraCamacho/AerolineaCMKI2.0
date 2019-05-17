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
    public class CD_VuelosVuelos
    {
         CD_Conexion conexion = new CD_Conexion();//iniciamos la instancia de la conexios   

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarVueloDestinosD()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarDestinos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();//ejecuta 
            tabla.Load(leer);//la tabla sera rellenada con lo que lea
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarVuelosDestinos(String fecsalida, String fecllegada, String ruta, int avion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarVuelosN";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@fecsalida", fecsalida);
            comando.Parameters.AddWithValue("@fecLlegada", fecllegada);
            comando.Parameters.AddWithValue("@Ruta", ruta);
            comando.Parameters.AddWithValue("@Avion", avion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public void EditarVuelosDestinosD(String fecsalida, String fecllegada, String ruta, int avion, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarVuelosN";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@fecsalida", fecsalida);
            comando.Parameters.AddWithValue("@fecLlegada", fecllegada);
            comando.Parameters.AddWithValue("@Ruta", ruta);
            comando.Parameters.AddWithValue("@Avion", avion);

            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarVuelosN";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }


        public DataTable ListarAvionesN()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListadoAviones";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();//ejecuta 
            tabla.Load(leer);//la tabla sera rellenada con lo que lea
            conexion.CerrarConexion();
            return tabla;

        }

    }
}

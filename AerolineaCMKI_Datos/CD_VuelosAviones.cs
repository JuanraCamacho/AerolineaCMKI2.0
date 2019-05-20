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
    public class CD_VuelosAviones
    {
        CD_Conexion conexion = new CD_Conexion();//iniciamos la instancia de la conexios

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarVueloAvionesD()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarAvionesN";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();//ejecuta 
            tabla.Load(leer);//la tabla sera rellenada con lo que lea
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarVuelosVueloD(String modelo, String capacidad, int activo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarAvionesN";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@modelo", modelo);
            comando.Parameters.AddWithValue("@capacidad", capacidad);
            comando.Parameters.AddWithValue("@activo", activo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public void EditarVuelosVueloD(String modelo, String capacidad, int activo, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarAvionesN";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@modelo", modelo);
            comando.Parameters.AddWithValue("@capacidad", capacidad);
            comando.Parameters.AddWithValue("@activo", activo);
            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarAvionesN";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
    }  
   
}

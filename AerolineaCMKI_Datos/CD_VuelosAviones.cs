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
            comando.CommandText = "MostrarAviones";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();//ejecuta 
            tabla.Load(leer);//la tabla sera rellenada con lo que lea
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarVuelosVueloD(int fila, char asiento, String descripcion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertAviones";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@fila", fila);
            comando.Parameters.AddWithValue("@asiento", asiento);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public void EditarVuelosVueloD(int fila, char asiento, String descripcion, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarVuelosVuelo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@fila", fila);
            comando.Parameters.AddWithValue("@asiento", asiento);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarAviones";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
    }  
   
}

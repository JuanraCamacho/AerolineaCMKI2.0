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
    public class CD_VuelosAvion
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

        public void InsertarVuelosDestinos(String lugar, String FechaHora, String descripcion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarDestinos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Lugar", lugar);
            comando.Parameters.AddWithValue("@FechaHora", FechaHora);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public void EditarVuelosDestinosD(String lugar, String FechaHora, String descripcion, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarDestinos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@lugar", lugar);
            comando.Parameters.AddWithValue("@FechaHora", FechaHora);
            comando.Parameters.AddWithValue("@descripcion", descripcion);

            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarDestinos";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

    }
}

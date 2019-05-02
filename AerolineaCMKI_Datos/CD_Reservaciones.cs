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
            comando.CommandText = "GetAviones";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();//ejecuta 
            tabla.Load(leer);//la tabla sera rellenada con lo que lea
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarPrueba(String nombre, String apellidos, String fechaReservacion, String tipoReservacion, String tipoEstado, double monto, String MetodoPago, String numeroAsiento, char fila)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "pruebaInsertarNuevoPasajero";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellidos", apellidos);
            comando.Parameters.AddWithValue("@fechaReservacion", fechaReservacion);
            comando.Parameters.AddWithValue("@tipoReservaciones", tipoReservacion);
            comando.Parameters.AddWithValue("@tipoEstado", tipoEstado);
            comando.Parameters.AddWithValue("@monto", monto);
            comando.Parameters.AddWithValue("@metodoPago", MetodoPago);
            comando.Parameters.AddWithValue("@numeroAsiento", numeroAsiento);
            comando.Parameters.AddWithValue("@fila", fila);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }
    }
}

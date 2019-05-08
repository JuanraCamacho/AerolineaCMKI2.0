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
            comando.CommandText = "MostrarReservaciones";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();//ejecuta 
            tabla.Load(leer);//la tabla sera rellenada con lo que lea
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ListarDestinos()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListarDescripcionDestinos2";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();//ejecuta 
            tabla.Load(leer);//la tabla sera rellenada con lo que lea
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable ListarAviones()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListarAviones";
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

        public void InsertarReserva(String nombres, String apellidos, int telefono, int idDestinos, int idAviones)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "GuardarReservas";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombres", nombres);
            comando.Parameters.AddWithValue("@Apelidos", apellidos);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            comando.Parameters.AddWithValue("@IdDestinos", idDestinos);
            comando.Parameters.AddWithValue("@IdAviones", idAviones);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }
        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarReservas";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
    }
}

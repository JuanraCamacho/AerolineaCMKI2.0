using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaCMKI_Datos
{
    class CD_Conexion
    {
        private SqlConnection Conexion = new SqlConnection("server=ALEXIS\\ALEXIS;DataBase=DB_CMKI;Integrated security=true");

        // Iniciando conexion con la base de datos  
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }


        //cerrando conexion con la base de datos
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}

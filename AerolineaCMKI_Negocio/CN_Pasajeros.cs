using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AerolineaCMKI_Datos;

namespace AerolineaCMKI_Negocio
{
   public class CN_Pasajeros
    {
        private CD_Pasajeros objetoCN = new CD_Pasajeros();

        public DataTable MostrarPasajeros()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCN.MostrarPasajeros();
            return tabla;
        }
       
    }
}

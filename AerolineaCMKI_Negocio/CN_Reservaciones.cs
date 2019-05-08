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
    public class CN_Reservaciones
    {
        private CD_Reservaciones objetoCN = new CD_Reservaciones();

        public DataTable MostrarCatClase()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCN.Mostrar();
            return tabla;
        }
        public void Eliminar(String id)
        {
            objetoCN.Eliminar(Convert.ToInt32(id));
        }

    }
}

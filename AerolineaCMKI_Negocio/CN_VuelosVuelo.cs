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
    public class CN_VuelosVuelo
    {
        private CD_VuelosVuelos objetoCN = new CD_VuelosVuelos();

        public DataTable MostrarAvionesVuelosN()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCN.MostrarVueloDestinosD();
            return tabla;
        }
        public void InsertarDestinos(String fecsalida, String fecllegada, String ruta, int avion)
        {
            objetoCN.InsertarVuelosDestinos(fecsalida,fecllegada, ruta, avion);
        }
        public void EditarDestinos(String fecsalida, String fecllegada, String ruta, int avion, String id)
        {
            objetoCN.EditarVuelosDestinosD(fecsalida, fecllegada, ruta, avion, Convert.ToInt32(id));
        }

        public void Eliminar(String id)
        {
            objetoCN.Eliminar(Convert.ToInt32(id));
        }
    }
}

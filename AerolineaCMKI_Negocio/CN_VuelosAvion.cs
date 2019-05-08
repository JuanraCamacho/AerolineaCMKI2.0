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
    public class CN_VuelosAvion
    {
        private CD_VuelosAvion objetoCN = new CD_VuelosAvion();

        public DataTable MostrarAvionesVuelosN()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCN.MostrarVueloDestinosD();
            return tabla;
        }
        public void InsertarDestinos(String lugar, String FechaHora, String descripcion)
        {
            objetoCN.InsertarVuelosDestinos(lugar,FechaHora, descripcion);
        }
        public void EditarDestinos(String lugar, String FechaHora, String descripcion, String id)
        {
            objetoCN.EditarVuelosDestinosD(lugar, FechaHora,descripcion ,Convert.ToInt32(id));
        }

        public void Eliminar(String id)
        {
            objetoCN.Eliminar(Convert.ToInt32(id));
        }
    }
}

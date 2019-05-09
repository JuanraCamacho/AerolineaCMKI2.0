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
    public class CN_VuelosAviones
    {
        private CD_VuelosAviones objetoCN = new CD_VuelosAviones();

        public DataTable MostrarAvionesVuelosN()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCN.MostrarVueloAvionesD();
            return tabla;
        }
        public void InsertarVuelosVueloN(String fila, String asiento, String descripcion)
        {
            objetoCN.InsertarVuelosVueloD(Convert.ToInt32(fila),Convert.ToChar(asiento),descripcion);
        }
        public void EditarVuelosVueloN(String fila, String asiento, String descripcion, String id)
        {
            objetoCN.EditarVuelosVueloD(Convert.ToInt32(fila),Convert.ToChar(asiento), descripcion, Convert.ToInt32(id));
        }
        public void Eliminar(String id)
        {
            objetoCN.Eliminar(Convert.ToInt32(id));
        }

    }
}

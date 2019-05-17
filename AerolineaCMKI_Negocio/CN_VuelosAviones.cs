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
        int activo1= 0;
        public DataTable MostrarAvionesVuelosN()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCN.MostrarVueloAvionesD();
            return tabla;
        }
        public void InsertarVuelosVueloN(String modelo, String capacidad, String activo)
        {
            if(activo.Equals("SI"))
            {
                activo1 = 1;
            }
            if (activo.Equals("NO"))
            {
                activo1 = 0;
            }
            objetoCN.InsertarVuelosVueloD(modelo,capacidad,activo1);
        }


        public void EditarVuelosVueloN(String modelo, String capacidad, String activo, String id)
        {
            if (activo.Equals("SI"))
            {
                activo1 = 1;
            }
            if (activo.Equals("NO"))
            {
                activo1 = 0;
            }
            objetoCN.EditarVuelosVueloD(modelo,capacidad,activo1, Convert.ToInt32(id));
        }
        public void Eliminar(String id)
        {
            objetoCN.Eliminar(Convert.ToInt32(id));
        }

    }
}

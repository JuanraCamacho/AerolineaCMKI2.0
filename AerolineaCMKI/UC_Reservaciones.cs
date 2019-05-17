using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaCMKI_Negocio;
using AerolineaCMKI_Datos;

namespace AerolineaCMKI
{
    public partial class UC_Reservaciones : UserControl
    {
        
        private string ID = null;
        CN_Reservaciones objetoCN = new CN_Reservaciones();

        public UC_Reservaciones()
        {
            InitializeComponent();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            addReservacion ar = new addReservacion();
            ar.ShowDialog();
            ar.Dispose();
            MostrarCatClase();
        }

        public void MostrarCatClase()
        {
            CN_Reservaciones objeto = new CN_Reservaciones();
            dtgvReservaciones.DataSource = objeto.MostrarCatClase();
        }

        public void UC_Reservaciones_Load(object sender, EventArgs e)
        {
            MostrarCatClase();
           

        }

        private void dtgvReservaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pbDelete_Click(object sender, EventArgs e)
        {

            if (dtgvReservaciones.SelectedRows.Count > 0)
            {
                ID = dtgvReservaciones.CurrentRow.Cells["IdReservacion"].Value.ToString();
                objetoCN.Eliminar(ID);
                MessageBox.Show("Se ha eliminado correctamente");
                MostrarCatClase();

            }
            else
            {
                MessageBox.Show("seleccione la fila por favor");
            }
        }

       


    }
}

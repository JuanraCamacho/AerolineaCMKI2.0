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

namespace AerolineaCMKI
{
    public partial class UC_Reservaciones : UserControl
    {
        CN_Reservaciones objetoCN = new CN_Reservaciones();

        public UC_Reservaciones()
        {
            InitializeComponent();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            addReservacion ar = new addReservacion();
            ar.ShowDialog();
        }

        private void MostrarCatClase()
        {
            CN_Reservaciones objeto = new CN_Reservaciones();
            dtgvReservaciones.DataSource = objeto.MostrarCatClase();
        }

        private void UC_Reservaciones_Load(object sender, EventArgs e)
        {
            MostrarCatClase();
        }

    }
}

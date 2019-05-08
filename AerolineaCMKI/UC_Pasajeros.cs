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
    public partial class UC_Pasajeros : UserControl
    {
        public UC_Pasajeros()
        {
            InitializeComponent();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {

        }

        private void dtgvPasajeros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void MostrarPasajeros()
        {
            CN_Pasajeros objeto = new CN_Pasajeros();
            dtgvPasajeros.DataSource = objeto.MostrarPasajeros();
        }

        private void UC_Pasajeros_Load(object sender, EventArgs e)
        {
            MostrarPasajeros();
        }
    }
}

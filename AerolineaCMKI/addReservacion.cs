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
    public partial class addReservacion : Form
    {
        CN_Reservaciones objetoCN = new CN_Reservaciones();
        public addReservacion()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addReservacion_Load(object sender, EventArgs e)
        {

        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnGurdar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCN.InsertarGenerarFicha(txtNombre.Text,txtApellidos.Text, txtFechaReservacion.Text, txtTipoReservacion.Text, txtTipoEstado.Text, txtMonto.Text, txtMetodoPago.Text, txtNumeroAsiento.Text, txtFila.Text);
                MessageBox.Show("LOS DATOS SE HAN GUARDADO");
                objetoCN.MostrarCatClase();//actualiza el dato que entro
                //Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("los datos no se guardaron correctamente" + ex);
            }
        }
    }
}

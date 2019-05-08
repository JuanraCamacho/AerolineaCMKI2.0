using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AerolineaCMKI_Negocio;
using AerolineaCMKI_Datos;

namespace AerolineaCMKI
{
    public partial class addReservacion : Form
    {
        CN_Reservaciones objetoCN = new CN_Reservaciones();
        CD_Reservaciones BD = new CD_Reservaciones();
        bool check = false;
        public addReservacion()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addReservacion_Load(object sender, EventArgs e)
        {
            ListarDescripcionDestinos();
            ListarAviones();
        }
        private void ListarDescripcionDestinos()
        {
            CD_Reservaciones obj = new CD_Reservaciones();
            cmbxDescripcionDestinos.DataSource = obj.ListarDestinos();
            cmbxDescripcionDestinos.DisplayMember = "DescripcionDes";
          cmbxDescripcionDestinos.ValueMember = "IdDestinos";
        }

        private void ListarAviones()
        {
            CD_Reservaciones obj = new CD_Reservaciones();
            cmbxAviones.DataSource = obj.ListarAviones();
            cmbxAviones.DisplayMember = "DescripcionAV";
            cmbxAviones.ValueMember = "IdAviones";
        }



        private void txtMonto_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnGurdar_Click(object sender, EventArgs e)
        {
          
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pcbxGuardar_Click(object sender, EventArgs e)//boton guardar/imagen
        {
            UC_Reservaciones otro =new  UC_Reservaciones();
      
            
            BD.InsertarReserva(txtNombre.Text, txtApellidos.Text, Convert.ToInt32(txttelefono.Text), Convert.ToInt32(cmbxDescripcionDestinos.SelectedValue), Convert.ToInt32(cmbxDescripcionDestinos.SelectedValue));
            MessageBox.Show("LOS DATOS SE HAN GUARDADO");
            
            Limpiar();
        }
        private void Limpiar()
        {
            txtNombre.Clear();
            txtApellidos.Clear();
            txttelefono.Clear();
            txtNombre.Clear();
            cmbxDescripcionDestinos.Text = " ";
            cmbxAviones.Text = " ";

        }
        public void ActualizarReservas()
        {
            CN_Reservaciones miobj = new CN_Reservaciones();
           
        }
       
    }
}

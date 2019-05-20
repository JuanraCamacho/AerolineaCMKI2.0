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
        
        Validaciones Val;
        public addReservacion()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //kkkkkkkkk

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addReservacion_Load(object sender, EventArgs e)
        {
            
            ListarAviones();
        }
       

        private void ListarAviones()
        {
            CD_Reservaciones obj = new CD_Reservaciones();
            cmbxAvion.DataSource = obj.ListarAviones();
            cmbxAvion.DisplayMember = "Ruta";
            cmbxAvion.ValueMember = "idVuelo";
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pcbxGuardar_Click(object sender, EventArgs e)//boton guardar/imagen
        {
            try
            {
                


                BD.InsertarReserva(txtNombre.Text, txtApellidos.Text, Convert.ToInt32(txttelefono.Text), Convert.ToInt32(cmbxAvion.SelectedValue), txtAsiento.Text, Convert.ToChar(txtFila.Text));
                MessageBox.Show("LOS DATOS SE HAN GUARDADO");

                Limpiar();
                Close();
            }
            catch(Exception ex)
            {
                    MessageBox.Show(ex.Message.ToString(), "aereolinia CMKI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Limpiar()
        {
            txtNombre.Clear();
            txtApellidos.Clear();
            txttelefono.Clear();
            cmbxAvion.Text = "";
            txtAsiento.Clear();
            txtFila.Clear();
            

        }


    

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloTexto(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "aereolinia CMKI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloTexto(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "aereolinia CMKI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAsiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloNumerico(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "aereolinia CMKI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFila_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloTexto(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "aereolinia CMKI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                Val = new Validaciones();
                Val.SoloNumerico(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "aereolinia CMKI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

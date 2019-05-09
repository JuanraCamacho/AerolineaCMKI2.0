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
    public partial class UC_VuelosAviones : UserControl
    {
        public UC_VuelosAviones()
        {
            InitializeComponent();
        }

        CN_VuelosAviones objetoCN = new CN_VuelosAviones();
        private bool Editar = false;
        private string IdVuelosVuelo = null;

        private void UC_VuelosVuelo_Load(object sender, EventArgs e)
        {
            MostrarVuelosVuelo();
        }
        private void MostrarVuelosVuelo()
        {
            CN_VuelosAviones objeto = new CN_VuelosAviones();
            dtgvVuelosVuelo.DataSource = objeto.MostrarAvionesVuelosN();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objetoCN.InsertarVuelosVueloN(txtFila.Text, txtAsiento.Text, txtDescripcion.Text);
                    MessageBox.Show("LOS DATOS SE HAN GUARDADO");
                    MostrarVuelosVuelo();//muestra las generaFicha
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("los datos no se guardaron correctamente" + ex);
                }
            }
            if (Editar == true)
            {
                try
                {
                    objetoCN.EditarVuelosVueloN(txtFila.Text, txtAsiento.Text, txtDescripcion.Text,IdVuelosVuelo);
                    MessageBox.Show("LOS DATOS SE HAN ACTUALIZADO CORRECTAMENTE");
                    MostrarVuelosVuelo();//muestra las generaFicha
                    Limpiar();
                    Editar = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("no se pudo actualizar los datos" + ex);
                }
            }
        }
        private void Limpiar()
        {
            txtFila.Clear();
            txtAsiento.Clear();
            txtDescripcion.Clear();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

                if (dtgvVuelosVuelo.SelectedRows.Count > 0)
                {
                    Editar = true;

                    txtFila.Text = dtgvVuelosVuelo.CurrentRow.Cells["fila"].Value.ToString();//lo que esta entre corchetes debe estar con el mismo nombre de la base de datos
                    txtAsiento.Text = dtgvVuelosVuelo.CurrentRow.Cells["Asiento"].Value.ToString();
                    txtDescripcion.Text = dtgvVuelosVuelo.CurrentRow.Cells["DescripcionAV"].Value.ToString();
              
                    IdVuelosVuelo = dtgvVuelosVuelo.CurrentRow.Cells["IdAviones"].Value.ToString();

                }

                else
                {
                    MessageBox.Show("Seleccione una fila por favor");
                }

            
        }

        private void pcDelete_Click(object sender, EventArgs e)
        {
            if (dtgvVuelosVuelo.SelectedRows.Count > 0)
            {
                IdVuelosVuelo = dtgvVuelosVuelo.CurrentRow.Cells["IdAviones"].Value.ToString();
                objetoCN.Eliminar(IdVuelosVuelo);
                MessageBox.Show("Se ha eliminado correctamente");
                MostrarVuelosVuelo();

            }
            else
            {
                MessageBox.Show("seleccione la fila por favor");
            }
        }
    }
}

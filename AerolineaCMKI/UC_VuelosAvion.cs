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
    public partial class UC_VuelosAvion : UserControl
    {
       
        public UC_VuelosAvion()
        {
            InitializeComponent();
        }
        CN_VuelosAvion objetoCN = new CN_VuelosAvion();
        private bool Editar = false;
        private string IdDestino= null;

        private void UC_VuelosAvion_Load(object sender, EventArgs e)
        {
            MostrarDestinos();
        }
        private void MostrarDestinos()
        {
            CN_VuelosAvion objeto = new CN_VuelosAvion();
            dtgvVuelosAvion.DataSource = objeto.MostrarAvionesVuelosN();
        }

        private void Limpiar()
        {
            txtLugar.Clear();
            txtFechaHora.Clear();
            txtDescripcion.Clear();


        }

        private void pcbxEditar_Click(object sender, EventArgs e)
        {
            if (dtgvVuelosAvion.SelectedRows.Count > 0)
            {
                Editar = true;

                txtLugar.Text = dtgvVuelosAvion.CurrentRow.Cells["Lugar"].Value.ToString();//lo que esta entre corchetes debe estar con el mismo nombre de la base de datos
                txtFechaHora.Text = dtgvVuelosAvion.CurrentRow.Cells["FechaHora"].Value.ToString();
                txtDescripcion.Text = dtgvVuelosAvion.CurrentRow.Cells["DescripcionDes"].Value.ToString();

                    IdDestino = dtgvVuelosAvion.CurrentRow.Cells["IdDestinos"].Value.ToString();

            }

            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void pcbxGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objetoCN.InsertarDestinos(txtLugar.Text, txtFechaHora.Text, txtDescripcion.Text);
                    MessageBox.Show("LOS DATOS SE HAN GUARDADO");
                    MostrarDestinos();//muestra las generaFicha
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
                    objetoCN.EditarDestinos(txtLugar.Text, txtFechaHora.Text, txtDescripcion.Text, IdDestino);
                    MessageBox.Show("LOS DATOS SE HAN ACTUALIZADO CORRECTAMENTE");
                    MostrarDestinos();//muestra las generaFicha
                    Limpiar();
                    Editar = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("no se pudo actualizar los datos" + ex);
                }
            }
        }

        private void pcbxEliminar_Click(object sender, EventArgs e)
        {
            if (dtgvVuelosAvion.SelectedRows.Count > 0)
            {
                IdDestino = dtgvVuelosAvion.CurrentRow.Cells["IdDestinos"].Value.ToString();
                objetoCN.Eliminar(IdDestino);
                MessageBox.Show("Se ha eliminado correctamente");
                MostrarDestinos();

            }
            else
            {
                MessageBox.Show("seleccione la fila por favor");
            }
        }
    }
    
}

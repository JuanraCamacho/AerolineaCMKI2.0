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
    public partial class UC_VuelosVuelos : UserControl
    {
       
        public UC_VuelosVuelos()
        {
            InitializeComponent();
            cmbxAvion.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        CN_VuelosVuelo objetoCN = new CN_VuelosVuelo();
        CD_VuelosVuelos BD = new CD_VuelosVuelos();
        Validaciones Val;
        private bool Editar = false;

        private string IdDestino= null;

        private void UC_VuelosAvion_Load(object sender, EventArgs e)
        {
            MostrarDestinos();
            ListarAviones();
        }
        private void MostrarDestinos()
        {
            CN_VuelosVuelo objeto = new CN_VuelosVuelo();
            dtgvVuelosAvion.DataSource = objeto.MostrarAvionesVuelosN();
        }

        private void Limpiar()
        {
            txtfecsalida.Clear();
            txtFecllegada.Clear();
            txtruta.Clear();


        }

        private void pcbxEditar_Click(object sender, EventArgs e)
        {
            if (dtgvVuelosAvion.SelectedRows.Count > 0)
            {
                Editar = true;

                txtfecsalida.Text = dtgvVuelosAvion.CurrentRow.Cells["Lugar"].Value.ToString();//lo que esta entre corchetes debe estar con el mismo nombre de la base de datos
                txtFecllegada.Text = dtgvVuelosAvion.CurrentRow.Cells["FechaHora"].Value.ToString();
                txtruta.Text = dtgvVuelosAvion.CurrentRow.Cells["DescripcionDes"].Value.ToString();

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
                    objetoCN.InsertarDestinos(txtfecsalida.Text, txtFecllegada.Text, txtruta.Text, Convert.ToInt32(cmbxAvion.SelectedValue));
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
                    objetoCN.EditarDestinos(txtfecsalida.Text, txtFecllegada.Text, txtruta.Text, Convert.ToInt32(cmbxAvion.SelectedValue), IdDestino);
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
                IdDestino = dtgvVuelosAvion.CurrentRow.Cells["idVuelo"].Value.ToString();
                objetoCN.Eliminar(IdDestino);
                MessageBox.Show("Se ha eliminado correctamente");
                MostrarDestinos();

            }
            else
            {
                MessageBox.Show("seleccione la fila por favor");
            }
        }

        private void ListarAviones()
        {
            CD_VuelosVuelos obj = new CD_VuelosVuelos();
            cmbxAvion.DataSource = obj.ListarAvionesN();
            cmbxAvion.DisplayMember = "Modelo";
            cmbxAvion.ValueMember = "IdAvion";
        }


    }

}

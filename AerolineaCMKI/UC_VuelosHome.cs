using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaCMKI
{
    public partial class UC_VuelosHome : UserControl
    {
        public UC_VuelosHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uC_VuelosVuelo1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uC_VuelosAvion1.BringToFront();
        }
    }
}

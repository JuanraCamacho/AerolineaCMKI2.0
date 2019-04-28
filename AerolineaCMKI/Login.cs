using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaCMKI
{//https://paletton.com/#uid=13L0u0kor++cF+Mj0+Yug+WM7ZB
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }

        private void SoyCliente_Click(object sender, EventArgs e)
        {
            LoginCliente lg = new LoginCliente();
            lg.ShowDialog();
        }

    }
}

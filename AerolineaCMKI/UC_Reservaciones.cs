﻿using System;
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
    public partial class UC_Reservaciones : UserControl
    {
        public UC_Reservaciones()
        {
            InitializeComponent();
        }

        private void pbAdd_Click(object sender, EventArgs e)
        {
            addReservacion ar = new addReservacion();
            ar.ShowDialog();
        }
    }
}
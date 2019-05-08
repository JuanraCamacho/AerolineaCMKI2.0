namespace AerolineaCMKI
{
    partial class UC_VuelosHome
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlHomeVuelos = new System.Windows.Forms.Panel();
            this.uC_VuelosVuelo1 = new AerolineaCMKI.UC_VuelosVuelo();
            this.uC_VuelosAvion1 = new AerolineaCMKI.UC_VuelosAvion();
            this.panel1.SuspendLayout();
            this.pnlHomeVuelos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 64);
            this.panel1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(151)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(322, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(342, 64);
            this.button2.TabIndex = 2;
            this.button2.Text = "Vuelos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(151)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aviones";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlHomeVuelos
            // 
            this.pnlHomeVuelos.Controls.Add(this.uC_VuelosVuelo1);
            this.pnlHomeVuelos.Controls.Add(this.uC_VuelosAvion1);
            this.pnlHomeVuelos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHomeVuelos.Location = new System.Drawing.Point(0, 64);
            this.pnlHomeVuelos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlHomeVuelos.Name = "pnlHomeVuelos";
            this.pnlHomeVuelos.Size = new System.Drawing.Size(664, 376);
            this.pnlHomeVuelos.TabIndex = 5;
            // 
            // uC_VuelosVuelo1
            // 
            this.uC_VuelosVuelo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_VuelosVuelo1.Location = new System.Drawing.Point(0, 0);
            this.uC_VuelosVuelo1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_VuelosVuelo1.Name = "uC_VuelosVuelo1";
            this.uC_VuelosVuelo1.Size = new System.Drawing.Size(664, 376);
            this.uC_VuelosVuelo1.TabIndex = 1;
            // 
            // uC_VuelosAvion1
            // 
            this.uC_VuelosAvion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_VuelosAvion1.Location = new System.Drawing.Point(0, 0);
            this.uC_VuelosAvion1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_VuelosAvion1.Name = "uC_VuelosAvion1";
            this.uC_VuelosAvion1.Size = new System.Drawing.Size(664, 376);
            this.uC_VuelosAvion1.TabIndex = 0;
            // 
            // UC_VuelosHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlHomeVuelos);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_VuelosHome";
            this.Size = new System.Drawing.Size(664, 440);
            this.panel1.ResumeLayout(false);
            this.pnlHomeVuelos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlHomeVuelos;
        private UC_VuelosVuelo uC_VuelosVuelo1;
        private UC_VuelosAvion uC_VuelosAvion1;
    }
}

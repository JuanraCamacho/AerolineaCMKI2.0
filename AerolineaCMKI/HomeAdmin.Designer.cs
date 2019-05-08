namespace AerolineaCMKI
{
    partial class HomeAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CMKI = new System.Windows.Forms.Label();
            this.pbLogoCliente = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVuelos = new System.Windows.Forms.Button();
            this.btnPasajeros = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.uC_Pasajeros1 = new AerolineaCMKI.UC_Pasajeros();
            this.uC_VuelosHome1 = new AerolineaCMKI.UC_VuelosHome();
            this.uC_Reservaciones1 = new AerolineaCMKI.UC_Reservaciones();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoCliente)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Controls.Add(this.CMKI);
            this.pnlTop.Controls.Add(this.pbLogoCliente);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(851, 59);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTop_Paint);
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AerolineaCMKI.Properties.Resources.close;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(827, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CMKI
            // 
            this.CMKI.AutoSize = true;
            this.CMKI.BackColor = System.Drawing.Color.Transparent;
            this.CMKI.Font = new System.Drawing.Font("Bahnschrift", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMKI.ForeColor = System.Drawing.Color.White;
            this.CMKI.Location = new System.Drawing.Point(56, 11);
            this.CMKI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CMKI.Name = "CMKI";
            this.CMKI.Size = new System.Drawing.Size(84, 36);
            this.CMKI.TabIndex = 10;
            this.CMKI.Text = "CMKI";
            this.CMKI.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CMKI_MouseDown);
            // 
            // pbLogoCliente
            // 
            this.pbLogoCliente.Image = global::AerolineaCMKI.Properties.Resources.avion64;
            this.pbLogoCliente.InitialImage = null;
            this.pbLogoCliente.Location = new System.Drawing.Point(8, 8);
            this.pbLogoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogoCliente.Name = "pbLogoCliente";
            this.pbLogoCliente.Size = new System.Drawing.Size(44, 40);
            this.pbLogoCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoCliente.TabIndex = 11;
            this.pbLogoCliente.TabStop = false;
            this.pbLogoCliente.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbLogoCliente_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.btnVuelos);
            this.panel1.Controls.Add(this.btnPasajeros);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 440);
            this.panel1.TabIndex = 1;
            // 
            // btnVuelos
            // 
            this.btnVuelos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(151)))));
            this.btnVuelos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVuelos.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVuelos.Image = global::AerolineaCMKI.Properties.Resources.avionFly1;
            this.btnVuelos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVuelos.Location = new System.Drawing.Point(1, 210);
            this.btnVuelos.Margin = new System.Windows.Forms.Padding(2);
            this.btnVuelos.Name = "btnVuelos";
            this.btnVuelos.Size = new System.Drawing.Size(187, 65);
            this.btnVuelos.TabIndex = 3;
            this.btnVuelos.Text = "                             Vuelos";
            this.btnVuelos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVuelos.UseVisualStyleBackColor = false;
            this.btnVuelos.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPasajeros
            // 
            this.btnPasajeros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(151)))));
            this.btnPasajeros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPasajeros.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasajeros.Image = global::AerolineaCMKI.Properties.Resources.userS;
            this.btnPasajeros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPasajeros.Location = new System.Drawing.Point(1, 141);
            this.btnPasajeros.Margin = new System.Windows.Forms.Padding(2);
            this.btnPasajeros.Name = "btnPasajeros";
            this.btnPasajeros.Size = new System.Drawing.Size(187, 65);
            this.btnPasajeros.TabIndex = 2;
            this.btnPasajeros.Text = "       Pasajeros";
            this.btnPasajeros.UseVisualStyleBackColor = false;
            this.btnPasajeros.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(151)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::AerolineaCMKI.Properties.Resources.bitacora64;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 279);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "                  Reservaciones";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "        UserName       ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::AerolineaCMKI.Properties.Resources.admin1;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(187, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.BackColor = System.Drawing.Color.White;
            this.pnlGeneral.Controls.Add(this.uC_Pasajeros1);
            this.pnlGeneral.Controls.Add(this.uC_VuelosHome1);
            this.pnlGeneral.Controls.Add(this.uC_Reservaciones1);
            this.pnlGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneral.Location = new System.Drawing.Point(187, 59);
            this.pnlGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(664, 440);
            this.pnlGeneral.TabIndex = 2;
            // 
            // uC_Pasajeros1
            // 
            this.uC_Pasajeros1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Pasajeros1.Location = new System.Drawing.Point(0, 0);
            this.uC_Pasajeros1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_Pasajeros1.Name = "uC_Pasajeros1";
            this.uC_Pasajeros1.Size = new System.Drawing.Size(664, 440);
            this.uC_Pasajeros1.TabIndex = 6;
            this.uC_Pasajeros1.Load += new System.EventHandler(this.uC_Pasajeros1_Load);
            // 
            // uC_VuelosHome1
            // 
            this.uC_VuelosHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_VuelosHome1.Location = new System.Drawing.Point(0, 0);
            this.uC_VuelosHome1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uC_VuelosHome1.Name = "uC_VuelosHome1";
            this.uC_VuelosHome1.Size = new System.Drawing.Size(664, 440);
            this.uC_VuelosHome1.TabIndex = 5;
            // 
            // uC_Reservaciones1
            // 
            this.uC_Reservaciones1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Reservaciones1.Location = new System.Drawing.Point(0, 0);
            this.uC_Reservaciones1.Margin = new System.Windows.Forms.Padding(2);
            this.uC_Reservaciones1.Name = "uC_Reservaciones1";
            this.uC_Reservaciones1.Size = new System.Drawing.Size(664, 440);
            this.uC_Reservaciones1.TabIndex = 4;
            // 
            // HomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 499);
            this.Controls.Add(this.pnlGeneral);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomeAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeAdmin";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoCliente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CMKI;
        private System.Windows.Forms.PictureBox pbLogoCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnVuelos;
        private System.Windows.Forms.Button btnPasajeros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlGeneral;
        private UC_VuelosHome uC_Vuelos1;
        private UC_Reservaciones uC_Reservaciones1;
        private UC_VuelosHome uC_VuelosHome1;
        private UC_Pasajeros uC_Pasajeros1;
    }
}
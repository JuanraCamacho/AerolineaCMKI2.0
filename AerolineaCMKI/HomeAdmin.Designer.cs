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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.uC_Reservaciones1 = new AerolineaCMKI.UC_Reservaciones();
            this.uC_VuelosHome1 = new AerolineaCMKI.UC_VuelosHome();
            this.uC_Pasajeros1 = new AerolineaCMKI.UC_Pasajeros();
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
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1135, 73);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AerolineaCMKI.Properties.Resources.close;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(1103, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 27);
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
            this.CMKI.Location = new System.Drawing.Point(75, 13);
            this.CMKI.Name = "CMKI";
            this.CMKI.Size = new System.Drawing.Size(108, 46);
            this.CMKI.TabIndex = 10;
            this.CMKI.Text = "CMKI";
            this.CMKI.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CMKI_MouseDown);
            // 
            // pbLogoCliente
            // 
            this.pbLogoCliente.Image = global::AerolineaCMKI.Properties.Resources.avion64;
            this.pbLogoCliente.InitialImage = null;
            this.pbLogoCliente.Location = new System.Drawing.Point(10, 10);
            this.pbLogoCliente.Name = "pbLogoCliente";
            this.pbLogoCliente.Size = new System.Drawing.Size(59, 49);
            this.pbLogoCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoCliente.TabIndex = 11;
            this.pbLogoCliente.TabStop = false;
            this.pbLogoCliente.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbLogoCliente_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(53)))), ((int)(((byte)(108)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 541);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(151)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::AerolineaCMKI.Properties.Resources.avionFly1;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 331);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(249, 80);
            this.button3.TabIndex = 3;
            this.button3.Text = "                             Vuelos";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(151)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::AerolineaCMKI.Properties.Resources.userS;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(249, 80);
            this.button2.TabIndex = 2;
            this.button2.Text = "       Pasajeros";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(98)))), ((int)(((byte)(151)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::AerolineaCMKI.Properties.Resources.bitacora64;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 80);
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
            this.label1.Location = new System.Drawing.Point(0, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "        UserName       ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::AerolineaCMKI.Properties.Resources.admin1;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(249, 135);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.BackColor = System.Drawing.Color.White;
            this.pnlGeneral.Controls.Add(this.uC_Reservaciones1);
            this.pnlGeneral.Controls.Add(this.uC_VuelosHome1);
            this.pnlGeneral.Controls.Add(this.uC_Pasajeros1);
            this.pnlGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGeneral.Location = new System.Drawing.Point(249, 73);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(886, 541);
            this.pnlGeneral.TabIndex = 2;
            // 
            // uC_Reservaciones1
            // 
            this.uC_Reservaciones1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Reservaciones1.Location = new System.Drawing.Point(0, 0);
            this.uC_Reservaciones1.Name = "uC_Reservaciones1";
            this.uC_Reservaciones1.Size = new System.Drawing.Size(886, 541);
            this.uC_Reservaciones1.TabIndex = 4;
            // 
            // uC_VuelosHome1
            // 
            this.uC_VuelosHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_VuelosHome1.Location = new System.Drawing.Point(0, 0);
            this.uC_VuelosHome1.Name = "uC_VuelosHome1";
            this.uC_VuelosHome1.Size = new System.Drawing.Size(886, 541);
            this.uC_VuelosHome1.TabIndex = 3;
            // 
            // uC_Pasajeros1
            // 
            this.uC_Pasajeros1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Pasajeros1.Location = new System.Drawing.Point(0, 0);
            this.uC_Pasajeros1.Name = "uC_Pasajeros1";
            this.uC_Pasajeros1.Size = new System.Drawing.Size(886, 541);
            this.uC_Pasajeros1.TabIndex = 1;
            // 
            // HomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 614);
            this.Controls.Add(this.pnlGeneral);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlGeneral;
        private UC_Pasajeros uC_Pasajeros1;
        private UC_VuelosHome uC_Vuelos1;
        private UC_Reservaciones uC_Reservaciones1;
        private UC_VuelosHome uC_VuelosHome1;
    }
}
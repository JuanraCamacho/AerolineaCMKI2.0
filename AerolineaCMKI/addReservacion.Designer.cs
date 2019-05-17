namespace AerolineaCMKI
{
    partial class addReservacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addReservacion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAdd = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.cmbxAvion = new System.Windows.Forms.ComboBox();
            this.lblDescripcionDestino = new System.Windows.Forms.Label();
            this.lblAvion = new System.Windows.Forms.Label();
            this.pcbxGuardar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAsiento = new System.Windows.Forms.TextBox();
            this.txtFila = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 51);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AerolineaCMKI.Properties.Resources.close;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(777, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblAdd.Font = new System.Drawing.Font("Bahnschrift", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.ForeColor = System.Drawing.Color.White;
            this.lblAdd.Location = new System.Drawing.Point(141, 6);
            this.lblAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(214, 36);
            this.lblAdd.TabIndex = 11;
            this.lblAdd.Text = "Reservaciones";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(299, 83);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(279, 20);
            this.txtNombre.TabIndex = 12;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(299, 109);
            this.txtApellidos.MaxLength = 100;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(279, 20);
            this.txtApellidos.TabIndex = 13;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(299, 137);
            this.txttelefono.MaxLength = 10;
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(279, 20);
            this.txttelefono.TabIndex = 14;
            this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono_KeyPress);
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.BackColor = System.Drawing.Color.White;
            this.lblNombres.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.ForeColor = System.Drawing.Color.Black;
            this.lblNombres.Location = new System.Drawing.Point(163, 84);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(66, 17);
            this.lblNombres.TabIndex = 55;
            this.lblNombres.Text = "Nombres";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.BackColor = System.Drawing.Color.White;
            this.lblApellidos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.ForeColor = System.Drawing.Color.Black;
            this.lblApellidos.Location = new System.Drawing.Point(166, 112);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(63, 17);
            this.lblApellidos.TabIndex = 56;
            this.lblApellidos.Text = "Apelidos";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.White;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.Black;
            this.lblTelefono.Location = new System.Drawing.Point(167, 140);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(62, 17);
            this.lblTelefono.TabIndex = 57;
            this.lblTelefono.Text = "Telefono";
            // 
            // cmbxAvion
            // 
            this.cmbxAvion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxAvion.FormattingEnabled = true;
            this.cmbxAvion.Location = new System.Drawing.Point(299, 176);
            this.cmbxAvion.Name = "cmbxAvion";
            this.cmbxAvion.Size = new System.Drawing.Size(279, 21);
            this.cmbxAvion.TabIndex = 58;
            // 
            // lblDescripcionDestino
            // 
            this.lblDescripcionDestino.AutoSize = true;
            this.lblDescripcionDestino.BackColor = System.Drawing.Color.White;
            this.lblDescripcionDestino.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionDestino.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcionDestino.Location = new System.Drawing.Point(163, 218);
            this.lblDescripcionDestino.Name = "lblDescripcionDestino";
            this.lblDescripcionDestino.Size = new System.Drawing.Size(120, 17);
            this.lblDescripcionDestino.TabIndex = 60;
            this.lblDescripcionDestino.Text = "ASIENTO(Numero)";
            // 
            // lblAvion
            // 
            this.lblAvion.AutoSize = true;
            this.lblAvion.BackColor = System.Drawing.Color.White;
            this.lblAvion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvion.ForeColor = System.Drawing.Color.Black;
            this.lblAvion.Location = new System.Drawing.Point(167, 180);
            this.lblAvion.Name = "lblAvion";
            this.lblAvion.Size = new System.Drawing.Size(45, 17);
            this.lblAvion.TabIndex = 61;
            this.lblAvion.Text = "Vuelo";
            // 
            // pcbxGuardar
            // 
            this.pcbxGuardar.Image = ((System.Drawing.Image)(resources.GetObject("pcbxGuardar.Image")));
            this.pcbxGuardar.Location = new System.Drawing.Point(434, 294);
            this.pcbxGuardar.Name = "pcbxGuardar";
            this.pcbxGuardar.Size = new System.Drawing.Size(39, 41);
            this.pcbxGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxGuardar.TabIndex = 62;
            this.pcbxGuardar.TabStop = false;
            this.pcbxGuardar.Click += new System.EventHandler(this.pcbxGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(163, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "FILA(letra)";
            // 
            // txtAsiento
            // 
            this.txtAsiento.Location = new System.Drawing.Point(299, 217);
            this.txtAsiento.MaxLength = 2;
            this.txtAsiento.Name = "txtAsiento";
            this.txtAsiento.Size = new System.Drawing.Size(279, 20);
            this.txtAsiento.TabIndex = 64;
            this.txtAsiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAsiento_KeyPress);
            // 
            // txtFila
            // 
            this.txtFila.Location = new System.Drawing.Point(299, 257);
            this.txtFila.MaxLength = 1;
            this.txtFila.Name = "txtFila";
            this.txtFila.Size = new System.Drawing.Size(279, 20);
            this.txtFila.TabIndex = 65;
            this.txtFila.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFila_KeyPress);
            // 
            // addReservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 468);
            this.Controls.Add(this.txtFila);
            this.Controls.Add(this.txtAsiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbxGuardar);
            this.Controls.Add(this.lblAvion);
            this.Controls.Add(this.lblDescripcionDestino);
            this.Controls.Add(this.cmbxAvion);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "addReservacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addReservacion";
            this.Load += new System.EventHandler(this.addReservacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxGuardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtApellidos;
        public System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.ComboBox cmbxAvion;
        private System.Windows.Forms.Label lblDescripcionDestino;
        private System.Windows.Forms.Label lblAvion;
        private System.Windows.Forms.PictureBox pcbxGuardar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtAsiento;
        public System.Windows.Forms.TextBox txtFila;
    }
}
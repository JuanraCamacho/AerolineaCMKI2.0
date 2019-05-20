namespace AerolineaCMKI
{
    partial class UC_VuelosVuelos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_VuelosVuelos));
            this.label1 = new System.Windows.Forms.Label();
            this.pcbxEditar = new System.Windows.Forms.PictureBox();
            this.pcbxEliminar = new System.Windows.Forms.PictureBox();
            this.txtfecsalida = new System.Windows.Forms.TextBox();
            this.txtFecllegada = new System.Windows.Forms.TextBox();
            this.txtruta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.dtgvVuelosAvion = new System.Windows.Forms.DataGridView();
            this.pcbxGuardar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbxAvion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVuelosAvion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 319);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vuelos";
            // 
            // pcbxEditar
            // 
            this.pcbxEditar.Image = global::AerolineaCMKI.Properties.Resources.edit;
            this.pcbxEditar.Location = new System.Drawing.Point(56, 271);
            this.pcbxEditar.Margin = new System.Windows.Forms.Padding(2);
            this.pcbxEditar.Name = "pcbxEditar";
            this.pcbxEditar.Size = new System.Drawing.Size(50, 41);
            this.pcbxEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxEditar.TabIndex = 8;
            this.pcbxEditar.TabStop = false;
            this.pcbxEditar.Click += new System.EventHandler(this.pcbxEditar_Click);
            // 
            // pcbxEliminar
            // 
            this.pcbxEliminar.Image = global::AerolineaCMKI.Properties.Resources.delete;
            this.pcbxEliminar.Location = new System.Drawing.Point(352, 271);
            this.pcbxEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.pcbxEliminar.Name = "pcbxEliminar";
            this.pcbxEliminar.Size = new System.Drawing.Size(39, 41);
            this.pcbxEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxEliminar.TabIndex = 7;
            this.pcbxEliminar.TabStop = false;
            this.pcbxEliminar.Click += new System.EventHandler(this.pcbxEliminar_Click);
            // 
            // txtfecsalida
            // 
            this.txtfecsalida.Location = new System.Drawing.Point(513, 78);
            this.txtfecsalida.Name = "txtfecsalida";
            this.txtfecsalida.Size = new System.Drawing.Size(137, 20);
            this.txtfecsalida.TabIndex = 59;
            // 
            // txtFecllegada
            // 
            this.txtFecllegada.Location = new System.Drawing.Point(513, 131);
            this.txtFecllegada.Name = "txtFecllegada";
            this.txtFecllegada.Size = new System.Drawing.Size(137, 20);
            this.txtFecllegada.TabIndex = 58;
            // 
            // txtruta
            // 
            this.txtruta.Location = new System.Drawing.Point(513, 165);
            this.txtruta.Name = "txtruta";
            this.txtruta.Size = new System.Drawing.Size(137, 20);
            this.txtruta.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(411, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 56;
            this.label7.Text = "RUTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(411, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 34);
            this.label2.TabIndex = 55;
            this.label2.Text = "FECHA\r\nDE LLEGADA";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.BackColor = System.Drawing.Color.White;
            this.lblnombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.Black;
            this.lblnombre.Location = new System.Drawing.Point(411, 64);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(72, 34);
            this.lblnombre.TabIndex = 54;
            this.lblnombre.Text = "FECHA\r\nDE SALIDA";
            // 
            // dtgvVuelosAvion
            // 
            this.dtgvVuelosAvion.AllowUserToAddRows = false;
            this.dtgvVuelosAvion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvVuelosAvion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvVuelosAvion.BackgroundColor = System.Drawing.Color.White;
            this.dtgvVuelosAvion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvVuelosAvion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvVuelosAvion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvVuelosAvion.ColumnHeadersHeight = 30;
            this.dtgvVuelosAvion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvVuelosAvion.EnableHeadersVisualStyles = false;
            this.dtgvVuelosAvion.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgvVuelosAvion.Location = new System.Drawing.Point(56, 38);
            this.dtgvVuelosAvion.Name = "dtgvVuelosAvion";
            this.dtgvVuelosAvion.ReadOnly = true;
            this.dtgvVuelosAvion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvVuelosAvion.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvVuelosAvion.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvVuelosAvion.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvVuelosAvion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvVuelosAvion.Size = new System.Drawing.Size(335, 202);
            this.dtgvVuelosAvion.TabIndex = 53;
            // 
            // pcbxGuardar
            // 
            this.pcbxGuardar.Image = ((System.Drawing.Image)(resources.GetObject("pcbxGuardar.Image")));
            this.pcbxGuardar.Location = new System.Drawing.Point(561, 271);
            this.pcbxGuardar.Name = "pcbxGuardar";
            this.pcbxGuardar.Size = new System.Drawing.Size(39, 41);
            this.pcbxGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxGuardar.TabIndex = 60;
            this.pcbxGuardar.TabStop = false;
            this.pcbxGuardar.Click += new System.EventHandler(this.pcbxGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(411, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 61;
            this.label3.Text = "AVION";
            // 
            // cmbxAvion
            // 
            this.cmbxAvion.FormattingEnabled = true;
            this.cmbxAvion.Location = new System.Drawing.Point(513, 200);
            this.cmbxAvion.Name = "cmbxAvion";
            this.cmbxAvion.Size = new System.Drawing.Size(137, 21);
            this.cmbxAvion.TabIndex = 62;
            // 
            // UC_VuelosVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbxAvion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pcbxGuardar);
            this.Controls.Add(this.txtfecsalida);
            this.Controls.Add(this.txtFecllegada);
            this.Controls.Add(this.txtruta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.dtgvVuelosAvion);
            this.Controls.Add(this.pcbxEditar);
            this.Controls.Add(this.pcbxEliminar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_VuelosVuelos";
            this.Size = new System.Drawing.Size(664, 375);
            this.Load += new System.EventHandler(this.UC_VuelosAvion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVuelosAvion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxGuardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcbxEditar;
        private System.Windows.Forms.PictureBox pcbxEliminar;
        private System.Windows.Forms.TextBox txtfecsalida;
        private System.Windows.Forms.TextBox txtFecllegada;
        private System.Windows.Forms.TextBox txtruta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.DataGridView dtgvVuelosAvion;
        private System.Windows.Forms.PictureBox pcbxGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbxAvion;
    }
}

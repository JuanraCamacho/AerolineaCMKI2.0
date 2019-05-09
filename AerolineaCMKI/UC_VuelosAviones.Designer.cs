namespace AerolineaCMKI
{
    partial class UC_VuelosAviones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_VuelosAviones));
            this.ptbEditar = new System.Windows.Forms.PictureBox();
            this.pcDelete = new System.Windows.Forms.PictureBox();
            this.dtgvVuelosVuelo = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtAsiento = new System.Windows.Forms.TextBox();
            this.txtFila = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVuelosVuelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbEditar
            // 
            this.ptbEditar.Image = global::AerolineaCMKI.Properties.Resources.edit;
            this.ptbEditar.Location = new System.Drawing.Point(14, 257);
            this.ptbEditar.Margin = new System.Windows.Forms.Padding(2);
            this.ptbEditar.Name = "ptbEditar";
            this.ptbEditar.Size = new System.Drawing.Size(50, 41);
            this.ptbEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbEditar.TabIndex = 8;
            this.ptbEditar.TabStop = false;
            this.ptbEditar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pcDelete
            // 
            this.pcDelete.Image = global::AerolineaCMKI.Properties.Resources.delete;
            this.pcDelete.Location = new System.Drawing.Point(344, 257);
            this.pcDelete.Margin = new System.Windows.Forms.Padding(2);
            this.pcDelete.Name = "pcDelete";
            this.pcDelete.Size = new System.Drawing.Size(39, 41);
            this.pcDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcDelete.TabIndex = 7;
            this.pcDelete.TabStop = false;
            this.pcDelete.Click += new System.EventHandler(this.pcDelete_Click);
            // 
            // dtgvVuelosVuelo
            // 
            this.dtgvVuelosVuelo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvVuelosVuelo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvVuelosVuelo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvVuelosVuelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvVuelosVuelo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvVuelosVuelo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvVuelosVuelo.ColumnHeadersHeight = 30;
            this.dtgvVuelosVuelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvVuelosVuelo.EnableHeadersVisualStyles = false;
            this.dtgvVuelosVuelo.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgvVuelosVuelo.Location = new System.Drawing.Point(67, 27);
            this.dtgvVuelosVuelo.Name = "dtgvVuelosVuelo";
            this.dtgvVuelosVuelo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvVuelosVuelo.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvVuelosVuelo.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvVuelosVuelo.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvVuelosVuelo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvVuelosVuelo.Size = new System.Drawing.Size(335, 202);
            this.dtgvVuelosVuelo.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(422, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "DESCRIPCION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(422, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "ASIENTO";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.BackColor = System.Drawing.SystemColors.Control;
            this.lblnombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.Black;
            this.lblnombre.Location = new System.Drawing.Point(422, 108);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(32, 17);
            this.lblnombre.TabIndex = 43;
            this.lblnombre.Text = "FILA";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(549, 257);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 49;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(524, 189);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(137, 20);
            this.txtDescripcion.TabIndex = 50;
            // 
            // txtAsiento
            // 
            this.txtAsiento.Location = new System.Drawing.Point(524, 151);
            this.txtAsiento.Name = "txtAsiento";
            this.txtAsiento.Size = new System.Drawing.Size(137, 20);
            this.txtAsiento.TabIndex = 51;
            // 
            // txtFila
            // 
            this.txtFila.Location = new System.Drawing.Point(524, 105);
            this.txtFila.Name = "txtFila";
            this.txtFila.Size = new System.Drawing.Size(137, 20);
            this.txtFila.TabIndex = 52;
            // 
            // UC_VuelosVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtFila);
            this.Controls.Add(this.txtAsiento);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.dtgvVuelosVuelo);
            this.Controls.Add(this.ptbEditar);
            this.Controls.Add(this.pcDelete);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_VuelosVuelo";
            this.Size = new System.Drawing.Size(664, 375);
            this.Load += new System.EventHandler(this.UC_VuelosVuelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVuelosVuelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ptbEditar;
        private System.Windows.Forms.PictureBox pcDelete;
        private System.Windows.Forms.DataGridView dtgvVuelosVuelo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtAsiento;
        private System.Windows.Forms.TextBox txtFila;
    }
}

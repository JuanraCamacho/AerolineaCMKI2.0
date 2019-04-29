namespace AerolineaCMKI
{
    partial class UC_Reservaciones
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
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pbEdit = new System.Windows.Forms.PictureBox();
            this.pbDelete = new System.Windows.Forms.PictureBox();
            this.dtgvReservaciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReservaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAdd
            // 
            this.pbAdd.Image = global::AerolineaCMKI.Properties.Resources.add;
            this.pbAdd.Location = new System.Drawing.Point(453, 21);
            this.pbAdd.Margin = new System.Windows.Forms.Padding(2);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(47, 41);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdd.TabIndex = 6;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // pbEdit
            // 
            this.pbEdit.Image = global::AerolineaCMKI.Properties.Resources.edit;
            this.pbEdit.Location = new System.Drawing.Point(524, 21);
            this.pbEdit.Margin = new System.Windows.Forms.Padding(2);
            this.pbEdit.Name = "pbEdit";
            this.pbEdit.Size = new System.Drawing.Size(50, 41);
            this.pbEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEdit.TabIndex = 5;
            this.pbEdit.TabStop = false;
            // 
            // pbDelete
            // 
            this.pbDelete.Image = global::AerolineaCMKI.Properties.Resources.delete;
            this.pbDelete.Location = new System.Drawing.Point(602, 21);
            this.pbDelete.Margin = new System.Windows.Forms.Padding(2);
            this.pbDelete.Name = "pbDelete";
            this.pbDelete.Size = new System.Drawing.Size(39, 41);
            this.pbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDelete.TabIndex = 4;
            this.pbDelete.TabStop = false;
            // 
            // dtgvReservaciones
            // 
            this.dtgvReservaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvReservaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvReservaciones.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvReservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvReservaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvReservaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvReservaciones.ColumnHeadersHeight = 30;
            this.dtgvReservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvReservaciones.EnableHeadersVisualStyles = false;
            this.dtgvReservaciones.GridColor = System.Drawing.Color.SteelBlue;
            this.dtgvReservaciones.Location = new System.Drawing.Point(28, 84);
            this.dtgvReservaciones.Name = "dtgvReservaciones";
            this.dtgvReservaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvReservaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvReservaciones.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvReservaciones.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvReservaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvReservaciones.Size = new System.Drawing.Size(445, 277);
            this.dtgvReservaciones.TabIndex = 36;
            // 
            // UC_Reservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgvReservaciones);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.pbEdit);
            this.Controls.Add(this.pbDelete);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UC_Reservaciones";
            this.Size = new System.Drawing.Size(664, 440);
            this.Load += new System.EventHandler(this.UC_Reservaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReservaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.PictureBox pbEdit;
        private System.Windows.Forms.PictureBox pbDelete;
        private System.Windows.Forms.DataGridView dtgvReservaciones;
    }
}

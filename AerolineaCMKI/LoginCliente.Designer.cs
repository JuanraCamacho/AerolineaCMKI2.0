namespace AerolineaCMKI
{
    partial class LoginCliente
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rayaLogin1 = new System.Windows.Forms.Panel();
            this.rayaLogin2 = new System.Windows.Forms.Panel();
            this.CMKI = new System.Windows.Forms.Label();
            this.pbLogoCliente = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // rayaLogin1
            // 
            this.rayaLogin1.BackColor = System.Drawing.Color.Black;
            this.rayaLogin1.Location = new System.Drawing.Point(80, 324);
            this.rayaLogin1.Name = "rayaLogin1";
            this.rayaLogin1.Size = new System.Drawing.Size(220, 2);
            this.rayaLogin1.TabIndex = 6;
            // 
            // rayaLogin2
            // 
            this.rayaLogin2.BackColor = System.Drawing.Color.Black;
            this.rayaLogin2.Location = new System.Drawing.Point(80, 414);
            this.rayaLogin2.Name = "rayaLogin2";
            this.rayaLogin2.Size = new System.Drawing.Size(220, 2);
            this.rayaLogin2.TabIndex = 7;
            // 
            // CMKI
            // 
            this.CMKI.AutoSize = true;
            this.CMKI.BackColor = System.Drawing.Color.Transparent;
            this.CMKI.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMKI.ForeColor = System.Drawing.Color.Black;
            this.CMKI.Location = new System.Drawing.Point(287, 34);
            this.CMKI.Name = "CMKI";
            this.CMKI.Size = new System.Drawing.Size(84, 36);
            this.CMKI.TabIndex = 9;
            this.CMKI.Text = "CMKI";
            // 
            // pbLogoCliente
            // 
            this.pbLogoCliente.Image = global::AerolineaCMKI.Properties.Resources.avion64;
            this.pbLogoCliente.InitialImage = null;
            this.pbLogoCliente.Location = new System.Drawing.Point(205, 9);
            this.pbLogoCliente.Name = "pbLogoCliente";
            this.pbLogoCliente.Size = new System.Drawing.Size(64, 64);
            this.pbLogoCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLogoCliente.TabIndex = 8;
            this.pbLogoCliente.TabStop = false;
            // 
            // pbUser
            // 
            this.pbUser.Image = global::AerolineaCMKI.Properties.Resources.man1;
            this.pbUser.InitialImage = null;
            this.pbUser.Location = new System.Drawing.Point(103, 130);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(128, 128);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbUser.TabIndex = 1;
            this.pbUser.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(80, 368);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 2);
            this.panel1.TabIndex = 7;
            // 
            // LoginCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(192)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(382, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CMKI);
            this.Controls.Add(this.pbLogoCliente);
            this.Controls.Add(this.rayaLogin2);
            this.Controls.Add(this.rayaLogin1);
            this.Controls.Add(this.pbUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CMKI";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Panel rayaLogin1;
        private System.Windows.Forms.Panel rayaLogin2;
        private System.Windows.Forms.Label CMKI;
        private System.Windows.Forms.PictureBox pbLogoCliente;
        private System.Windows.Forms.Panel panel1;
    }
}
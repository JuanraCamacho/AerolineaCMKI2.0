﻿namespace AerolineaCMKI
{
    partial class Login
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
            this.SoyCliente = new System.Windows.Forms.Label();
            this.rayaLogin1 = new System.Windows.Forms.Panel();
            this.rayaLogin2 = new System.Windows.Forms.Panel();
            this.CMKI = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbCandado = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCandado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // SoyCliente
            // 
            this.SoyCliente.AutoSize = true;
            this.SoyCliente.BackColor = System.Drawing.Color.Transparent;
            this.SoyCliente.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 11F);
            this.SoyCliente.ForeColor = System.Drawing.Color.Black;
            this.SoyCliente.Location = new System.Drawing.Point(292, 471);
            this.SoyCliente.Name = "SoyCliente";
            this.SoyCliente.Size = new System.Drawing.Size(78, 23);
            this.SoyCliente.TabIndex = 3;
            this.SoyCliente.Text = "Soy Cliente";
            this.SoyCliente.Click += new System.EventHandler(this.SoyCliente_Click);
            // 
            // rayaLogin1
            // 
            this.rayaLogin1.BackColor = System.Drawing.Color.Black;
            this.rayaLogin1.Location = new System.Drawing.Point(115, 307);
            this.rayaLogin1.Name = "rayaLogin1";
            this.rayaLogin1.Size = new System.Drawing.Size(220, 2);
            this.rayaLogin1.TabIndex = 6;
            // 
            // rayaLogin2
            // 
            this.rayaLogin2.BackColor = System.Drawing.Color.Black;
            this.rayaLogin2.Location = new System.Drawing.Point(115, 397);
            this.rayaLogin2.Name = "rayaLogin2";
            this.rayaLogin2.Size = new System.Drawing.Size(220, 2);
            this.rayaLogin2.TabIndex = 7;
            // 
            // CMKI
            // 
            this.CMKI.AutoSize = true;
            this.CMKI.BackColor = System.Drawing.Color.Transparent;
            this.CMKI.Font = new System.Drawing.Font("Bahnschrift", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMKI.ForeColor = System.Drawing.Color.Black;
            this.CMKI.Location = new System.Drawing.Point(128, 152);
            this.CMKI.Name = "CMKI";
            this.CMKI.Size = new System.Drawing.Size(108, 46);
            this.CMKI.TabIndex = 9;
            this.CMKI.Text = "CMKI";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::AerolineaCMKI.Properties.Resources.avion1001;
            this.pbLogo.InitialImage = null;
            this.pbLogo.Location = new System.Drawing.Point(110, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(100, 100);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLogo.TabIndex = 8;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // pbCandado
            // 
            this.pbCandado.Image = global::AerolineaCMKI.Properties.Resources.lockPRO;
            this.pbCandado.InitialImage = null;
            this.pbCandado.Location = new System.Drawing.Point(26, 324);
            this.pbCandado.Name = "pbCandado";
            this.pbCandado.Size = new System.Drawing.Size(64, 64);
            this.pbCandado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCandado.TabIndex = 2;
            this.pbCandado.TabStop = false;
            // 
            // pbUser
            // 
            this.pbUser.Image = global::AerolineaCMKI.Properties.Resources.userPRO;
            this.pbUser.InitialImage = null;
            this.pbUser.Location = new System.Drawing.Point(26, 231);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(64, 64);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbUser.TabIndex = 1;
            this.pbUser.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(192)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(382, 503);
            this.Controls.Add(this.CMKI);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.rayaLogin2);
            this.Controls.Add(this.rayaLogin1);
            this.Controls.Add(this.SoyCliente);
            this.Controls.Add(this.pbCandado);
            this.Controls.Add(this.pbUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CMKI";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCandado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.PictureBox pbCandado;
        private System.Windows.Forms.Label SoyCliente;
        private System.Windows.Forms.Panel rayaLogin1;
        private System.Windows.Forms.Panel rayaLogin2;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label CMKI;
    }
}


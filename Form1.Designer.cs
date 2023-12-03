namespace Ejemplo_5
{
    partial class frmEjemplo5
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
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.cmdMayor = new System.Windows.Forms.Button();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.cmdSalida = new System.Windows.Forms.Button();
            this.lblMayMen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(44, 45);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(69, 24);
            this.lblEdad.TabIndex = 0;
            this.lblEdad.Text = "Edad:";
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(119, 45);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 26);
            this.txtEdad.TabIndex = 1;
            // 
            // cmdMayor
            // 
            this.cmdMayor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMayor.Location = new System.Drawing.Point(48, 164);
            this.cmdMayor.Name = "cmdMayor";
            this.cmdMayor.Size = new System.Drawing.Size(318, 29);
            this.cmdMayor.TabIndex = 2;
            this.cmdMayor.Text = "&Mayor";
            this.cmdMayor.UseVisualStyleBackColor = false;
            this.cmdMayor.Click += new System.EventHandler(this.cmdMayor_Click);
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLimpiar.Location = new System.Drawing.Point(48, 199);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(318, 29);
            this.cmdLimpiar.TabIndex = 3;
            this.cmdLimpiar.Text = "&Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = false;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // cmdSalida
            // 
            this.cmdSalida.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalida.Location = new System.Drawing.Point(48, 234);
            this.cmdSalida.Name = "cmdSalida";
            this.cmdSalida.Size = new System.Drawing.Size(318, 29);
            this.cmdSalida.TabIndex = 4;
            this.cmdSalida.Text = "&Salida";
            this.cmdSalida.UseVisualStyleBackColor = false;
            this.cmdSalida.Click += new System.EventHandler(this.cmdSalida_Click);
            // 
            // lblMayMen
            // 
            this.lblMayMen.AutoSize = true;
            this.lblMayMen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMayMen.Location = new System.Drawing.Point(113, 106);
            this.lblMayMen.Name = "lblMayMen";
            this.lblMayMen.Size = new System.Drawing.Size(0, 32);
            this.lblMayMen.TabIndex = 5;
            // 
            // frmEjemplo5
            // 
            this.AcceptButton = this.cmdMayor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CancelButton = this.cmdSalida;
            this.ClientSize = new System.Drawing.Size(433, 345);
            this.Controls.Add(this.lblMayMen);
            this.Controls.Add(this.cmdSalida);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.cmdMayor);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lblEdad);
            this.Name = "frmEjemplo5";
            this.Text = "Ejemplo 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button cmdMayor;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Button cmdSalida;
        private System.Windows.Forms.Label lblMayMen;
    }
}


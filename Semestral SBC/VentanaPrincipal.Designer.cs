namespace Semestral_SBC
{
    partial class VentanaPrincipal
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
            this.panelPrinsipal = new System.Windows.Forms.Panel();
            this.buttonSiguiente = new System.Windows.Forms.Button();
            this.buttonInicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelPrinsipal
            // 
            this.panelPrinsipal.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.panelPrinsipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrinsipal.Location = new System.Drawing.Point(12, 12);
            this.panelPrinsipal.Name = "panelPrinsipal";
            this.panelPrinsipal.Size = new System.Drawing.Size(460, 364);
            this.panelPrinsipal.TabIndex = 6;
            // 
            // buttonSiguiente
            // 
            this.buttonSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSiguiente.Location = new System.Drawing.Point(332, 399);
            this.buttonSiguiente.Name = "buttonSiguiente";
            this.buttonSiguiente.Size = new System.Drawing.Size(120, 36);
            this.buttonSiguiente.TabIndex = 5;
            this.buttonSiguiente.Text = "Siguiente";
            this.buttonSiguiente.UseVisualStyleBackColor = true;
            this.buttonSiguiente.Click += new System.EventHandler(this.buttonSiguiente_Click);
            // 
            // buttonInicio
            // 
            this.buttonInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInicio.Location = new System.Drawing.Point(332, 399);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(120, 36);
            this.buttonInicio.TabIndex = 7;
            this.buttonInicio.Text = "Volver a Inicio";
            this.buttonInicio.UseVisualStyleBackColor = true;
            this.buttonInicio.Visible = false;
            this.buttonInicio.Click += new System.EventHandler(this.buttonInicio_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.buttonInicio);
            this.Controls.Add(this.buttonSiguiente);
            this.Controls.Add(this.panelPrinsipal);
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SE de dIAgnostico";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panelPrinsipal;
        private System.Windows.Forms.Button buttonSiguiente;
        private System.Windows.Forms.Button buttonInicio;
    }
}


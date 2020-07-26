namespace Semestral_SBC.Ventanas
{
    partial class Resultados
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
            this.labelTituloResultados = new System.Windows.Forms.Label();
            this.labelTituloRecomendaciones = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.labelRecomendaciones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTituloResultados
            // 
            this.labelTituloResultados.AutoSize = true;
            this.labelTituloResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloResultados.Location = new System.Drawing.Point(104, 30);
            this.labelTituloResultados.Name = "labelTituloResultados";
            this.labelTituloResultados.Size = new System.Drawing.Size(220, 46);
            this.labelTituloResultados.TabIndex = 6;
            this.labelTituloResultados.Text = "Resultados";
            // 
            // labelTituloRecomendaciones
            // 
            this.labelTituloRecomendaciones.AutoSize = true;
            this.labelTituloRecomendaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloRecomendaciones.Location = new System.Drawing.Point(44, 164);
            this.labelTituloRecomendaciones.Name = "labelTituloRecomendaciones";
            this.labelTituloRecomendaciones.Size = new System.Drawing.Size(353, 46);
            this.labelTituloRecomendaciones.TabIndex = 7;
            this.labelTituloRecomendaciones.Text = "Recomendaciones";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(26, 88);
            this.labelResultado.MaximumSize = new System.Drawing.Size(400, 0);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(70, 25);
            this.labelResultado.TabIndex = 8;
            this.labelResultado.Text = "label2";
            // 
            // labelRecomendaciones
            // 
            this.labelRecomendaciones.AutoSize = true;
            this.labelRecomendaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecomendaciones.Location = new System.Drawing.Point(26, 228);
            this.labelRecomendaciones.MaximumSize = new System.Drawing.Size(400, 0);
            this.labelRecomendaciones.Name = "labelRecomendaciones";
            this.labelRecomendaciones.Size = new System.Drawing.Size(70, 25);
            this.labelRecomendaciones.TabIndex = 9;
            this.labelRecomendaciones.Text = "label2";
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 325);
            this.Controls.Add(this.labelRecomendaciones);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelTituloRecomendaciones);
            this.Controls.Add(this.labelTituloResultados);
            this.Name = "Resultados";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTituloResultados;
        private System.Windows.Forms.Label labelTituloRecomendaciones;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label labelRecomendaciones;
    }
}
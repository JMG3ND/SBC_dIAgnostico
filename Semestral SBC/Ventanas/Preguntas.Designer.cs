namespace Semestral_SBC.Ventanas
{
    partial class Preguntas
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
            this.labelPreguntas = new System.Windows.Forms.Label();
            this.labelEnunciadoDePreguntas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPreguntas
            // 
            this.labelPreguntas.AutoSize = true;
            this.labelPreguntas.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreguntas.Location = new System.Drawing.Point(105, 30);
            this.labelPreguntas.Name = "labelPreguntas";
            this.labelPreguntas.Size = new System.Drawing.Size(384, 46);
            this.labelPreguntas.TabIndex = 3;
            this.labelPreguntas.Text = "Número de pregunta";
            // 
            // labelEnunciadoDePreguntas
            // 
            this.labelEnunciadoDePreguntas.AutoSize = true;
            this.labelEnunciadoDePreguntas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnunciadoDePreguntas.Location = new System.Drawing.Point(12, 107);
            this.labelEnunciadoDePreguntas.MaximumSize = new System.Drawing.Size(440, 0);
            this.labelEnunciadoDePreguntas.Name = "labelEnunciadoDePreguntas";
            this.labelEnunciadoDePreguntas.Size = new System.Drawing.Size(102, 24);
            this.labelEnunciadoDePreguntas.TabIndex = 4;
            this.labelEnunciadoDePreguntas.Text = "Enunciado";
            // 
            // Preguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.labelPreguntas);
            this.Controls.Add(this.labelEnunciadoDePreguntas);
            this.Name = "Preguntas";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPreguntas;
        private System.Windows.Forms.Label labelEnunciadoDePreguntas;
    }
}
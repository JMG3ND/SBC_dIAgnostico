namespace Semestral_SBC.Ventanas
{
    partial class Datos
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
            this.comboBoxDiagnosticos = new System.Windows.Forms.ComboBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelDiagnosticos = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxDiagnosticos
            // 
            this.comboBoxDiagnosticos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiagnosticos.FormattingEnabled = true;
            this.comboBoxDiagnosticos.Location = new System.Drawing.Point(18, 257);
            this.comboBoxDiagnosticos.Name = "comboBoxDiagnosticos";
            this.comboBoxDiagnosticos.Size = new System.Drawing.Size(416, 21);
            this.comboBoxDiagnosticos.TabIndex = 9;
            this.comboBoxDiagnosticos.SelectedIndexChanged += new System.EventHandler(this.comboBoxDiagnosticos_SelectedIndexChanged);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(55, 46);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(356, 46);
            this.labelTitulo.TabIndex = 5;
            this.labelTitulo.Text = "Datos del Paciente";
            // 
            // labelDiagnosticos
            // 
            this.labelDiagnosticos.AutoSize = true;
            this.labelDiagnosticos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiagnosticos.Location = new System.Drawing.Point(14, 230);
            this.labelDiagnosticos.Name = "labelDiagnosticos";
            this.labelDiagnosticos.Size = new System.Drawing.Size(290, 24);
            this.labelDiagnosticos.TabIndex = 8;
            this.labelDiagnosticos.Text = "Seleccione posibles diagnosticos";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(18, 157);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(416, 20);
            this.textBoxNombre.TabIndex = 6;
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(14, 130);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(193, 24);
            this.labelNombre.TabIndex = 7;
            this.labelNombre.Text = "Nombre del Paciente:";
            // 
            // Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.comboBoxDiagnosticos);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelDiagnosticos);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.Name = "Datos";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDiagnosticos;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelDiagnosticos;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNombre;
    }
}
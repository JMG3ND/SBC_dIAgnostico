using Semestral_SBC.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semestral_SBC.Ventanas
{
    public partial class Preguntas : Form
    {
        public float puntaje = 0;
        List<RadioButton> opcionesrespuestas = new List<RadioButton>();
        public Preguntas(string pregunta, List<String> respuestas,List<float> pesos, int enumeracion)
        {
            InitializeComponent();
            this.labelEnunciadoDePreguntas.Text = pregunta;
            this.labelPreguntas.Text = "Pregunta N" + enumeracion;

            int y = 239;
            for (int x = 0; x < respuestas.Count; x++, y += 30)
            {
                radioButtonRespuestas radioButtonRespuesta = new radioButtonRespuestas()
                {
                    AutoSize = true,
                    Location = new Point(50, y),
                    Name = respuestas[x],
                    Size = new Size(85, 17),
                    TabIndex = 5,
                    TabStop = true,
                    Text = respuestas[x],
                    UseVisualStyleBackColor = true,
                    pesoRespuesta = pesos[x],
                };

                labelEnunciadoDePreguntas.Width = 100; 

                radioButtonRespuesta.CheckedChanged += new EventHandler(this.radioButtonRespuesta_CheckedChanged);

                opcionesrespuestas.Add(radioButtonRespuesta);
                this.Controls.Add(opcionesrespuestas[x]);
            }
        }

        private void radioButtonRespuesta_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonRespuestas rad = (radioButtonRespuestas) sender;
            if (rad.Checked)
            {
               puntaje = rad.pesoRespuesta;
            }
        }
    }
}

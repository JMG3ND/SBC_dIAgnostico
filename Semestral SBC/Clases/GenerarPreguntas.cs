using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Semestral_SBC.Ventanas;
using System.Windows.Forms;

namespace Semestral_SBC
{
    class GenerarPreguntas
    {
        public List<Preguntas> Ventanas = new List<Preguntas>();
        int numero_de_preguntas;
        public GenerarPreguntas(string testActivo)
        {
            try
            {
                using (StreamReader lector = new StreamReader("Test\\"+ testActivo +".txt"))
                {
                    numero_de_preguntas = int.Parse(lector.ReadLine());
                    for (int x = 0; x < numero_de_preguntas; x++)
                    {
                        string pregunta = lector.ReadLine();
                        int numero_de_respuestas = int.Parse(lector.ReadLine());
                        List<String> respuestas = new List<string>();
                        List<float> peso = new List<float>();

                        for (int y = 0; y < numero_de_respuestas; y++)
                        {
                            respuestas.Add(lector.ReadLine());
                            peso.Add(float.Parse(lector.ReadLine()));
                        }
                        Preguntas ventana = new Preguntas(pregunta, respuestas,peso , x+1);
                        Ventanas.Add(ventana);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error al leer archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}

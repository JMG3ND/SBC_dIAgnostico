using Semestral_SBC.Ventanas;
using System;
using SbsSW.SwiPlCs;
using System.Windows.Forms;

namespace Semestral_SBC
{
    public partial class VentanaPrincipal : Form
    {
        private Form formularioactual;
        GenerarPreguntas Preguntas;
        Datos Datos = new Datos();
        Resultados resultados;
        int numerodepregunta = 0;
        int limitedepregunta;

        public VentanaPrincipal()
        {
            InitializeComponent();
            abrirformulario(Datos);
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            retorno:
            if (limitedepregunta > 0)
            {
                if (numerodepregunta < limitedepregunta)
                {
                    pasarPregunta();
                }
                else
                {
                    buttonSiguiente.Visible = false;
                    buttonInicio.Visible = true;
                    evaluacion();
                }
            }
            else
            {
                if (Datos.testelegido != "" && Datos.nombre != "")
                {
                    Preguntas = new GenerarPreguntas(Datos.testelegido);
                    limitedepregunta = Preguntas.Ventanas.Count;
                    goto retorno;
                }
                else
                {
                    MessageBox.Show("Debe llenar todos los campos", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pasarPregunta()
        {
            abrirformulario(Preguntas.Ventanas[numerodepregunta]);
            numerodepregunta++;
        }

        private void evaluacion()
        {
            float Sumapuntaje = 0;
            int nivel = 0;
            for (int x = 0; x < Preguntas.Ventanas.Count; x++)
            {
                Sumapuntaje += Preguntas.Ventanas[x].puntaje;
            }

            PlQuery cargar = new PlQuery("cargar(\"SBC.bd\")");

            cargar.NextSolution();
            PlQuery consulta = new PlQuery("gravedad(\"" + Datos.testelegido + "\"," + (int)Sumapuntaje + ", Nivel)");
            foreach (PlQueryVariables respuestas in consulta.SolutionVariables)
            {
                nivel = int.Parse(respuestas["Nivel"].ToString());
            }
            resultados = new Resultados(nivel , Datos.testelegido);
            abrirformulario(resultados);
            
        }

        private void abrirformulario(Form formulariohijo)
        {
            if (formularioactual != null)
            {
                formularioactual.Close();
            }
            formularioactual = formulariohijo;
            formulariohijo.TopLevel = false;
            formulariohijo.FormBorderStyle = FormBorderStyle.None;
            formulariohijo.Dock = DockStyle.Fill;
            panelPrinsipal.Controls.Add(formulariohijo);
            panelPrinsipal.Tag = formulariohijo;
            formulariohijo.BringToFront();
            formulariohijo.Show();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            Environment.SetEnvironmentVariable("Path", @"C:\\Program Files (x86)\\swipl\\bin");
            string[] p = { "-q", "-f", @"SBC.pl" };
            PlEngine.Initialize(p);
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}

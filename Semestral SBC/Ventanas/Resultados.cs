using System.Windows.Forms;
using System.IO;

namespace Semestral_SBC.Ventanas
{
    public partial class Resultados : Form
    {
        public Resultados(int nivel,string testelegido)
        {
            InitializeComponent();
            using (StreamReader lector = new StreamReader("Test\\Diagnóstico " + testelegido + ".txt"))
            {
                while(lector.Peek() >= 0)
                {
                    if(int.Parse(lector.ReadLine()) == nivel)
                    {
                        labelResultado.Text = lector.ReadLine().ToString(); 
                        labelRecomendaciones.Text = lector.ReadLine().ToString();
                        break;
                    }
                    else
                    {
                        lector.ReadLine();
                        lector.ReadLine();
                    }
                }
            }

        }
    }
}

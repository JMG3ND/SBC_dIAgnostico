using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Semestral_SBC.Ventanas
{
    public partial class Datos : Form
    {
        public static string testelegido = "";
        public static string nombre = "";
        public Datos()
        {
            InitializeComponent();
            using (StreamReader lector = new StreamReader("Test\\Test disponibles.txt"))
            {
                while (lector.Peek() >= 0)
                    comboBoxDiagnosticos.Items.Add(lector.ReadLine());
            }
        }

        private void comboBoxDiagnosticos_SelectedIndexChanged(object sender, EventArgs e)
        {
            testelegido = comboBoxDiagnosticos.Text;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            nombre = textBoxNombre.Text;
        }
    }
}

using System.Windows.Forms;

namespace Semestral_SBC.Clases
{
    class radioButtonRespuestas : RadioButton
    {
        float peso = 0;

        public float pesoRespuesta
        {
            get { return peso; }
            set { peso = value; }
        }
    }
}

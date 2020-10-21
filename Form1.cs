using System;
using System.Windows.Forms;

namespace FormArregloUnidimensionalG3
{
    public partial class Form1 : Form
    {
        Matriz miMatriz;
        int indice = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDefinirTamaño_Click(object sender, EventArgs e)
        {

            int n = int.Parse(txtbTotalElementos.Text);
            miMatriz = new Matriz(n);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {


        }
    }
}

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
            indice = 0;
            int n = int.Parse(txtbTotalElementos.Text);
            miMatriz = new Matriz(n);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            float elemento = 0;
            if ( chkAleatorio.Checked)
            {
                Random aleatorio = new Random();
                elemento=  (float)aleatorio.NextDouble()*1000;
                               
            }
            else
            {
                elemento = float.Parse(txtbElemento.Text);               
            }
            miMatriz.Agregar(elemento, indice++);
            lbMatriz.Text = miMatriz.ToString();

        }
    }
}

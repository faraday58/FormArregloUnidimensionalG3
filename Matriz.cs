
using System.Windows.Forms;

namespace FormArregloUnidimensionalG3
{
    class Matriz
    {
        public float[] A;
        private int n;
        private int indice;

        /// <summary>
        /// Constructor del arreglo de números flotantes
        /// </summary>
        /// <param name="n">Es el tamaño del arreglo</param>
        public Matriz(int n)
        {
            N = n;
            A = new float[N];
        }

        public int N { 
            get => n;
            set
            {
                if( value < 2  )
                {
                    n = 2;
                }
                else
                {
                    n = value;
                }                    
            }
        }

        public int Indice { 
            get => indice;
            set
            {
                if( value < 0 || value >= N)
                {
                    indice = 0;
                }
                else
                {
                    indice = value;
                }
                
            }
        }

        public void Agregar(float elemento,int indice)
        {
            Indice = indice;
            A[Indice] = elemento;
        }

        //10 20 30
        public override string ToString()
        {
            string A = "";
            foreach(float elemento in this.A     )
            {
                if (A=="")
                {
                    A = A + elemento; //10
                }else
                {
                    A = A + " , " + elemento;
                }                
            }
            return A;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritmo2
{
    class NumerosPrimos
    {
        public int limite { get; set; }
        public int[] index = new int[4];

        public NumerosPrimos()
        {
            index[0] = 2;
            index[1] = 3;
            index[2] = 5;
            index[3] = 7;
        }

        public void CalcularNumerosPrimos()
        {
            for (int l = 1; l <= limite; l++)
            {
                bool primo = true;
                for (int i = 0; i < 4; i++)
                {
                    int resto = l % index[i];

                    if (l != index[i] && resto == 0)
                    {
                        primo = false;
                        break;
                    }
                }
                if (primo == true)
                    Console.WriteLine(l);
            }
        }
    }
}

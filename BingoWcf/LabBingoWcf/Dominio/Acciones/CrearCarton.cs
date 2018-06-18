using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoWcf.Dominio.Acciones
{
    public class CrearCarton
    {
        public int[,] CrearMatrizCarton()
        {
            Random rnd = new Random();
            int cont = 1;
            int cont2 = 15;
            int numero;
            int[,] laMatriz = new int[5, 5];
            bool band = true;
            //laMatriz[0, 0] = 3;
            //laMatriz[0, 1] = 5;
            //laMatriz[0, 2] = 4;
            //laMatriz[0, 3] = 1;
            //laMatriz[0, 4] = 2;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    numero = rnd.Next(cont, cont2);
                    for (int a = 0; a < 5; a++)
                    {
                        for (int b = 0; b < 5; b++)
                        {
                            if (laMatriz[b, a] == numero)
                            {
                                j--;
                                band = false;
                                break;
                            }
                        }
                    }
                    if (band == true)
                    {
                        laMatriz[j, i] = numero;
                    }
                    else
                    {
                        band = true;
                    }
                }
                cont += 15;
                cont2 += 15;
            }
            return laMatriz;
        }
    }
}

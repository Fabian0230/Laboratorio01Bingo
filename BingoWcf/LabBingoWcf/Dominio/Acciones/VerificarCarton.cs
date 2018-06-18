using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoWcf.Dominio.Acciones
{
    public class VerificarCarton
    {
        public bool verificaMatriz(List<int> num, int[,] matrizCarton, int[,] matrizJuego)
        {
            int[,] laMatriz = new int[5, 5];
            int[,] tipoJuego = new int[5, 5];
            laMatriz = matrizCarton;
            tipoJuego = matrizJuego;
            int count = 0;
            int count2 = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (tipoJuego[i, j] == 1)
                    {
                        count++;
                    }
                }
            }
            for (int a = 0; a < 5; a++)
            {
                for (int b = 0; b < 5; b++)
                {
                    for (int c = 0; c < num.Count; c++)
                    {
                        if (laMatriz[a, b] == num.ElementAt(c) && tipoJuego[a, b] == 1)
                        {
                            count2++;
                        }
                    }
                }
            }
            if (count2 == count)
            {
                return true;
            }
            return false;
        }
    }
}

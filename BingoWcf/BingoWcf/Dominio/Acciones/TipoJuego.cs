using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoWcf.Dominio.Acciones
{
    public class TipoJuego
    {
        //Tipo de juego #1 primera fila
        public int[,] Juego1()
        {
            int[,] laMatriz = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        laMatriz[i, j] = 1;
                    }
                    else if (i == 0 && j == 1)
                    {
                        laMatriz[i, j] = 1;
                    }
                    else if (i == 0 && j == 2)
                    {
                        laMatriz[i, j] = 1;
                    }
                    else if (i == 0 && j == 3)
                    {
                        laMatriz[i, j] = 1;
                    }
                    else if (i == 0 && j == 4)
                    {
                        laMatriz[i, j] = 1;
                    }
                    else
                    {
                        laMatriz[i, j] = 0;
                    }
                }
            }
            return laMatriz;
        }

        //Tipo de juego #2 cuatro esquinas
        public int[,] Juego2()
        {
            int[,] laMatriz = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        laMatriz[i, j] = 1;
                    }
                    else if (i == 0 && j == 4)
                    {
                        laMatriz[i, j] = 1;
                    }
                    else if (i == 4 && j == 0)
                    {
                        laMatriz[i, j] = 1;
                    }
                    else if (i == 4 && j == 4)
                    {
                        laMatriz[i, j] = 1;
                    }
                    else
                    {
                        laMatriz[i, j] = 0;
                    }
                }
            }
            return laMatriz;
        }

        //Tipo de juego #3 "X"
        public int[,] Juego3()
        {
            int[,] laMatriz = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        laMatriz[i, j] = 1;
                    }
                    else if (i == 1 && j == 1)
                    {
                        laMatriz[i, j] = 1;
                    }
                    else if (i == 2 && j == 2)
                    {
                        laMatriz[i, j] = 1;
                    }
                    else if (i == 3 && j == 3)
                    {
                        laMatriz[i, j] = 1;
                    }
                    else if (i == 4 && j == 4)
                    {
                        laMatriz[i, j] = 1;
                    }
                    else if (i == 0 && j == 4)
                    {
                        laMatriz[i, j] = 1;
                    }
                    else if (i == 1 && j == 3)
                    {
                        laMatriz[i, j] = 1;
                    }
                    else if (i == 3 && j == 1)
                    {
                        laMatriz[i, j] = 1;
                    }
                    else if (i == 4 && j == 0)
                    {
                        laMatriz[i, j] = 1;
                    }
                    else
                    {
                        laMatriz[i, j] = 0;
                    }
                }
            }
            return laMatriz;
        }

        //tipo de juego #4 "Centro"
        public int[,] Juego4()
        {
            int[,] laMatriz = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == 2 && j == 2)
                    {
                        laMatriz[i, j] = 1;
                    }
                    else
                    {
                        laMatriz[i, j] = 0;
                    }
                }
            }
            return laMatriz;
        }
    }
}

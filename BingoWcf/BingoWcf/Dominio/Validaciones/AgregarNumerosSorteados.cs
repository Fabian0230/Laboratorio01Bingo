using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoWcf.Dominio.Validaciones
{
    public class AgregarNumerosSorteados
    {
        public void agregarNumerosSinRepetir(List<int> numeros)
        {

            Random rnd2 = new Random();
            bool bandera1 = true;
            int cont = 1;
            int cont2 = 75;
            int numeroJugado;
            for (int i = 0; i < 25; i++)
            {
                numeroJugado = rnd2.Next(cont, cont2);
                if (numeros.Count == 0)
                {
                    numeros.Add(numeroJugado);
                }
                else
                {
                    for (int j = 0; j < numeros.Count; j++)
                    {
                        if (numeroJugado == numeros.ElementAt(j))
                        {
                            i--;
                            bandera1 = false;
                            break;
                        }
                    }
                    if (bandera1 == true)
                    {
                        numeros.Add(numeroJugado);
                    }
                    else
                    {
                        bandera1 = true;
                    }
                }
            }

        }
    }
}

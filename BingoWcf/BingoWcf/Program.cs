using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoWcf
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration section
            BingoWcf.Dominio.Especificaciones.RealiceMatriz rc = new BingoWcf.Dominio.Especificaciones.RealiceMatriz();
            BingoWcf.Dominio.Especificaciones.RealiceTipoJuego rt = new BingoWcf.Dominio.Especificaciones.RealiceTipoJuego();
            BingoWcf.Dominio.Especificaciones.RealiceVerificarCarton rv = new BingoWcf.Dominio.Especificaciones.RealiceVerificarCarton();
            BingoWcf.Dominio.Especificaciones.RealiceSortearNumeros rn = new BingoWcf.Dominio.Especificaciones.RealiceSortearNumeros();
            BingoWcf.Dominio.Acciones.CrearCarton c = new BingoWcf.Dominio.Acciones.CrearCarton();
            BingoWcf.Dominio.Acciones.CantidadCartones cant = new BingoWcf.Dominio.Acciones.CantidadCartones();
            List<int[,]> cartonesCreados = new List<int[,]>();
            List<int> listaNumerosSorteados = new List<int>();
            int[,] carton = new int[5, 5];
            int[,] juegoSeleccionado = new int[5, 5];
            int tipoJuego = 0;
            int cantidadCartones = 0;
            bool verificaCarton;
            int numeroBingo;
            int noGana = 0;

            //Executing section
            Console.WriteLine("Comienza el juego");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Cantidad de cartones de bingo: ");
            cantidadCartones = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Creando cartones de bingo!!!");
            Console.WriteLine("------------------------------");
            cartonesCreados = cant.cantidadCartones(cantidadCartones);
            Console.WriteLine("Seleccione el tipo de juego:\n"
                                + "1.Primera fila.\n"
                                + "2.Cuatro esquinas.\n"
                                + "3.X.\n"
                                + "4.Centro.");
            Console.WriteLine("Seleccione una opcion:");
            //Tipo de juego Selection
            while (tipoJuego <= 0 || tipoJuego > 4)
            {
                tipoJuego = Convert.ToInt16(Console.ReadLine());
                switch (tipoJuego)
                {
                    case 1:
                        juegoSeleccionado = rt.RealizarTipoJuego1();
                        break;
                    case 2:
                        juegoSeleccionado = rt.RealizarTipoJuego2();
                        break;
                    case 3:
                        juegoSeleccionado = rt.RealizarTipoJuego3();
                        break;
                    case 4:
                        juegoSeleccionado = rt.RealizarTipoJuego4();
                        break;
                    default:
                        Console.WriteLine("Seleccione una opcion correcta!");
                        break;
                }

            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Generando lista de numeros al azar\n" + "Numeros generados");
            listaNumerosSorteados = rn.RealizarSortearNumeros();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Verificando los cartones en busca de ganador");
            Console.WriteLine("------------------------------");
            for (int o = 0; o < cartonesCreados.Count; o++)
            {
                numeroBingo = o;
                numeroBingo++;
                verificaCarton = rv.RealizarVerificarCarton(listaNumerosSorteados, cartonesCreados[o], juegoSeleccionado);
                if (verificaCarton)
                {
                    Console.WriteLine("Felicidades bingo " + numeroBingo+" gano!");
                    //break;
                }
                else
                {
                    noGana++;
                }
            }
            if (noGana == cartonesCreados.Count)
            {
                Console.WriteLine("No existe ganador en los cartones de juego!");
            }
            Console.ReadKey();
        }
    }
}


//Para imprimir matriz
////Impreme la matriz
////for (int i = 0; i < 5; i++)
////{
////    for (int j = 0; j < 5; j++)
////    {
////        Console.Write(CrearMatrizCarton().GetValue(i,j)+ " "); //Escribe en una sola linea 
////    }
////    Console.WriteLine(); //Genera el salto de linea 
////}

////for(int i = 0; i < 5; i++) 
////{
////    for (int j = 0; j < 5; j++)
////    {
////        Console.Write(laMatriz[i,j] + " "); //Escribe en una sola linea 
////    }
////    Console.WriteLine(); //Genera el salto de linea 
////}

//for(int i = 0; i < c.cantidadCartones().Count; i++)
//{
//    for (int a = 0; a < 5; a++)
//    {
//        for (int b = 0; b < 5; b++)
//        {
//            Console.Write(c.cantidadCartones()[0].GetValue(a,b)+ " ");
//            //Console.Write(CrearMatrizCarton().GetValue(i, j) + " "); //Escribe en una sola linea 
//        }
//        Console.WriteLine(); //Genera el salto de linea 
//    }
//}

// Cartones que hay en la lista 
//for (int i = 0; i < cartonesCreados.Count; i++)
//{
//    numeroBingo = i;
//    numeroBingo++;
//    Console.WriteLine("Bingo " + numeroBingo);
//    for (int a = 0; a < 5; a++)
//    {
//        for (int b = 0; b < 5; b++)
//        {
//            Console.Write(cartonesCreados[i].GetValue(a,b)+"|");
//            //Console.Write(c.cantidadCartones()[0].GetValue(a, b) + " ");
//            //Console.Write(CrearMatrizCarton().GetValue(i, j) + " "); //Escribe en una sola linea 
//        }
//        Console.WriteLine(); //Genera el salto de linea 
//    }
//    Console.WriteLine("---------------");
//}


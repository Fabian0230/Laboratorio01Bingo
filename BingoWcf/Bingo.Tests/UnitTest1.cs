using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bingo.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CantidadCartones()
        {
            // prepara el escenario
            var elServicio = new BingoWcf.Dominio.Acciones.CrearCarton();
            int num = 10;
            var elServicio2 = new BingoWcf.Dominio.Especificaciones.RealiceMatriz();
            int expectedResult;
            int realResult;
            List<int[,]> cartonesResult = new List<int[,]>();
            List<int[,]> cartonesExpected = new List<int[,]>();
            for(int i = 0; i < 10; i++)
            {
                cartonesExpected.Add(elServicio.CrearMatrizCarton());
            }
            expectedResult = cartonesExpected.Count;
            // invoca al método
            cartonesResult = elServicio2.RealizarMatriz(num);
            realResult = cartonesResult.Count;


            // verifica resultados
            Assert.AreEqual(expectedResult, realResult);
        }

        [TestMethod]
        public void tipoJuego()
        {
            //prepara el escenario
            var elServicio = new BingoWcf.Dominio.Especificaciones.RealiceTipoJuego();
            var elServicio2 = new BingoWcf.Dominio.Especificaciones.RealiceVerificarCarton();
            int[,] laMatriz= new int[5,5];
            int[,] tipoJuego = elServicio.RealizarTipoJuego4();
            bool expectedResult=true;
            bool realResult;
            List<int> listaNumeros = new List<int>();
            listaNumeros.Add(5);
            listaNumeros.Add(1);
            for (int i = 0; i < 5; i++)
            {
                for(int j=0;j<5; j++)
                {
                    if (i == 2 && j == 2)
                    {
                        laMatriz[i, j] =listaNumeros[0];
                    }
                    else
                    {
                        laMatriz[i, j] = listaNumeros[1];
                    }
                }
            }
            //invoca el método
            realResult=elServicio2.RealizarVerificarCarton(listaNumeros, laMatriz, tipoJuego);
            //verifica resultados
            Assert.AreEqual(expectedResult, realResult);
        }

        [TestMethod]
        public void CartonesDistintos()
        {
            //prepara el escenario
            var elServicio = new BingoWcf.Dominio.Especificaciones.RealiceMatriz();
            bool expectedResult = true;
            bool realResult=false;
            List<int[,]> listaCartones = new List<int[,]>();
            int[,] matriz1= new int[5,5];
            int[,] matriz2= new int[5, 5];
            //invoca el método
            listaCartones = elServicio.RealizarMatriz(2);
            matriz1= listaCartones[0];
            matriz2 = listaCartones[1];
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    if (matriz1[i,j]!=matriz2[i,j])
                    {
                        realResult = true;
                    }
                    else
                    {
                        realResult = false;
                    }
                }
            }
            //verifica el resultado
            Assert.AreEqual(expectedResult, realResult);
        }
    }
}

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
            var elServicio2 = new BingoWcf.Dominio.Acciones.CantidadCartones();
            int expectedResult;
            int realResult;
            List<int[,]> cartonesResult = new List<int[,]>();
            List<int[,]> cartonesExpected = new List<int[,]>();
            cartonesExpected.Add(elServicio.CrearMatrizCarton());
            cartonesExpected.Add(elServicio.CrearMatrizCarton());
            cartonesExpected.Add(elServicio.CrearMatrizCarton());
            cartonesExpected.Add(elServicio.CrearMatrizCarton());
            cartonesExpected.Add(elServicio.CrearMatrizCarton());
            cartonesExpected.Add(elServicio.CrearMatrizCarton());
            cartonesExpected.Add(elServicio.CrearMatrizCarton());
            cartonesExpected.Add(elServicio.CrearMatrizCarton());
            cartonesExpected.Add(elServicio.CrearMatrizCarton());
            cartonesExpected.Add(elServicio.CrearMatrizCarton());
            expectedResult = cartonesExpected.Count;
            // invoca al método
            cartonesResult = elServicio2.cantidadCartones(num);
            realResult = cartonesResult.Count;


            // verifica resultados
            Assert.AreEqual(expectedResult, realResult);
        }
    }
}

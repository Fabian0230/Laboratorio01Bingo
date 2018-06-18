using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoWcf.Dominio.Especificaciones
{
    public class RealiceMatriz
    {
        public int[,] RealizarMatriz()
        {
            int[,] laMatriz;
            var laAccion = new Acciones.CrearCarton();
            laMatriz = laAccion.CrearMatrizCarton();
            return laMatriz;
        }
    }
}

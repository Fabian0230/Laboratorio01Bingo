using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoWcf.Dominio.Especificaciones
{
    public class RealiceMatriz
    {
        public List<int[,]> RealizarMatriz(int cantidadCartones)
        {
            List<int[,]> laMatriz;
            var laAccion = new Acciones.CantidadCartones();
            laMatriz = laAccion.cantidadCartones(cantidadCartones);
            return laMatriz;
        }
    }
}

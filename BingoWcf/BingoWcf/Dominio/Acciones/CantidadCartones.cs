using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoWcf.Dominio.Acciones
{
    public class CantidadCartones
    {
        Especificaciones.RealiceMatriz rm = new Especificaciones.RealiceMatriz();
        public List<int[,]> cantidadCartones(int cantidad)
        {
            List<int[,]> cartones = new List<int[,]>();
            for (int i = 0; i < cantidad; i++)
            {
                cartones.Add(rm.RealizarMatriz());
            }
            return cartones;
        }
    }
}

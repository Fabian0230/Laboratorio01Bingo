using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoWcf.Dominio.Acciones
{
    public class CantidadCartones
    {
        CrearCarton rm = new CrearCarton();
        public List<int[,]> cantidadCartones(int cantidad)
        {
            List<int[,]> cartones = new List<int[,]>();
            for (int i = 0; i < cantidad; i++)
            {
                cartones.Add(rm.CrearMatrizCarton());
            }
            return cartones;
        }
    }
}

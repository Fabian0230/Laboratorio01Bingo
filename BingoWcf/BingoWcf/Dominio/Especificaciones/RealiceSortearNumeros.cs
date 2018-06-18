using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoWcf.Dominio.Especificaciones
{
    public class RealiceSortearNumeros
    {
        public List<int> RealizarSortearNumeros()
        {
            List<int> laLista;
            var laAccion = new Dominio.Acciones.SortearNumeros();
            laLista = laAccion.listaNumeros();
            return laLista;
        }
    }
}

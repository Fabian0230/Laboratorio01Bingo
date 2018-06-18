using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoWcf.Dominio.Especificaciones
{
    public class RealiceTipoJuego
    {
        public int[,] RealizarTipoJuego1()
        {
            int[,] laMatriz;
            var laAccion = new Dominio.Acciones.TipoJuego();
            laMatriz = laAccion.Juego1();
            return laMatriz;
        }

        public int[,] RealizarTipoJuego2()
        {
            int[,] laMatriz;
            var laAccion = new Dominio.Acciones.TipoJuego();
            laMatriz = laAccion.Juego2();
            return laMatriz;
        }

        public int[,] RealizarTipoJuego3()
        {
            int[,] laMatriz;
            var laAccion = new Dominio.Acciones.TipoJuego();
            laMatriz = laAccion.Juego3();
            return laMatriz;
        }

        public int[,] RealizarTipoJuego4()
        {
            int[,] laMatriz;
            var laAccion = new Dominio.Acciones.TipoJuego();
            laMatriz = laAccion.Juego4();
            return laMatriz;
        }
    }
}

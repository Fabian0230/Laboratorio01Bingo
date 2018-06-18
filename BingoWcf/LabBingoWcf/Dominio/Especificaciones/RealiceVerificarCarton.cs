using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoWcf.Dominio.Especificaciones
{
    public class RealiceVerificarCarton
    {
        public bool RealizarVerificarCarton(List<int> num, int[,] matrizCarton, int[,] matrizJuego)
        {
            bool verificaCarton;
            var laAccion = new Dominio.Acciones.VerificarCarton();
            verificaCarton = laAccion.verificaMatriz(num, matrizCarton, matrizJuego);
            return verificaCarton;
        }
    }
}

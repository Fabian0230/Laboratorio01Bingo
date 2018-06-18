using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoWcf.Dominio.Acciones
{
    public class SortearNumeros
    {
        public List<int> listaNumeros()
        {

            Validaciones.AgregarNumerosSorteados agrega = new Validaciones.AgregarNumerosSorteados();
            List<int> numeros = new List<int>();
            //numeros.Add(1);
            //numeros.Add(3);
            //numeros.Add(5);
            //numeros.Add(2);
            //numeros.Add(4);
            //Llena la lista de numeros
            agrega.agregarNumerosSinRepetir(numeros);

            return numeros;
        }
    }
}

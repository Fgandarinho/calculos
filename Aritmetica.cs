using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{

    /// <summary>
    /// Implmenta operaçõe aritméticas
    /// </summary>

    internal class Aritmetica
    {
        public int Somar(int x, int y)
        {
            int soma = 0;
            soma = x + y;
            return soma;
        
        }
        public int Subtrair(int x, int y)
        {
            int subtracao = 0;
            subtracao = x - y;
            return subtracao;
        }



    }
}

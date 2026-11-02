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
        
        /// <summary>
        /// Operação soma
        /// </summary>
        /// <returns>Retorna a soma de dois números</returns>
        public static int Somar(int x, int y)
        {
            int soma = 0;
            soma = x + y;
            return soma;
        
        }

        /// <summary>
        /// Operação de subtração
        /// </summary>
        /// <returns>Retorna a subtração de dois números</returns>
        public static int Subtrair(int x, int y)
        {
            int subtracao = 0;
            subtracao = x - y;
            return subtracao;
        }

        /// <summary>
        /// Operação de multiplicação
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int Multiplicar(int x, int y)
        {
            return x * y;
        }
    }
}

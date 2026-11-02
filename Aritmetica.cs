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
        /// Tipo de conversão
        /// </summary>        
        public enum ConversaoTemperatura
        {

            Nulo=0, CelciusFahrenheit, FahrenheitCelcius
        }




        /// <summary>
        /// Operação soma
        /// </summary>
        /// <returns>Retorna a soma de dois números</returns>
        public int Somar(int x, int y)
        {
            int soma = 0;
            soma = x + y;
            return soma;
        
        }

        /// <summary>
        /// Operação de subtração
        /// </summary>
        /// <returns>Retorna a subtração de dois números</returns>
        public int Subtrair(int x, int y)
        {
            int subtracao = 0;
            subtracao = x - y;
            return subtracao;
        }

        /// <summary>
        /// Conversão de temperatura
        /// </summary>
        /// <param name="conversao"> A conversão a efetuar</param>
        /// <param name="temperatura"> A tempertura a converter</param>
        /// <returns>resultado da conversão</returns>
        public double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelciusFahrenheit)
            {
                return (temperatura * 1.800 + 32);

            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelcius)
            {
                return ((temperatura - 32) / 1.8000));
            }
            return -1;
        }


    }
}

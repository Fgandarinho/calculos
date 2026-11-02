using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Esta classe implementa operaçõies de conversãoi
    /// </summary>
    internal static class Conversoes
    {
        /// <summary>
        /// Tipo de conversão
        /// </summary>        
        public enum ConversaoTemperatura
        {

            Nulo = 0, CelciusFahrenheit, FahrenheitCelcius
        }

        /// <summary>
        /// Conversão de temperatura
        /// </summary>
        /// <param name="conversao"> A conversão a efetuar</param>
        /// <param name="temperatura"> A tempertura a converter</param>
        /// <returns>resultado da conversão</returns>
        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelciusFahrenheit)
            {
                return (temperatura * 1.800 + 32);

            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelcius)
            {
                return ((temperatura - 32) / 1.8000);
            }
            return -1;
        }


    }
}

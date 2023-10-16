using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementa operações aritmeticas
    /// </summary>
    internal static class Aritmetica
    { 
    /// <summary>
    /// Operação Soma
    /// </summary>
    /// <returns> Retorna a soma de dois numeros</returns>
        public static int Somar(int x, int y)
        {
            return x + y;
        }
        /// <summary>
        /// Operação de Subtração
        /// </summary>
        /// <returns> Retorna o resultado da subtração de dois numeros</returns>
        public static int Subtrair(int x, int y)
        {
            return x - y;
        }   
    }
}

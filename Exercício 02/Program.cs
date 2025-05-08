using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_02
{ /* Atividae 02
   * numero par ou impar
   */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um numero inteiro");
            int num1 = Convert.ToInt16(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine($" O {num1} É PAR");
            }
            else 
            {
                Console.WriteLine($"O {num1} É IMPAR");
            }
            Console.ReadKey();
        }
    }
}

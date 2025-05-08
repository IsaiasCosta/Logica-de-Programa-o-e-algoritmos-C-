using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_07 {
    internal class Program {
        /*ATIVIDADE 07
         * Peça 3 numeros inteiros e retorne o menor
         */
        static void Main(string[] args) {
            int num1, num2, num3, menorNumero;
            Console.WriteLine("Entre com 1° número");
            num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Entre com 2° número");
            num2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Entre com 3° número");
            num3 = Convert.ToInt16(Console.ReadLine());

            menorNumero = (num1 < num2 && num1 < num3) ? num1
                          : (num2 < num1 && num2 < num3) ? num2
                          : num3;

            Console.WriteLine($"o menor número é {menorNumero}");
            Console.ReadKey();
        }

    }
}

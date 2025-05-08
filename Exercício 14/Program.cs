using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_14 {
    internal class Program {
        /*
         ATIVIDADE 14
        Peça 2 números, em seguida exiba os valoress entre os números informados.
        Exemplo: se informado 2 e 5, o retorno será: 2,3,4,5.
        */
        static void Main(string[] args) {
            Console.WriteLine("Entre com om   1° número");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Entre com om   2° número");
            int num2 = Convert.ToInt16(Console.ReadLine());
            for (int i = num1; i <= num2; i++)
            {
                Console.Write($"{i} - ");
            }
            Console.ReadKey();
        }
    }
}

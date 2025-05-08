using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_06 {
    internal class Program {/*ATIVIDADE 06
      * 
      * Peça um número inteiro, retorne se ele positivo, neutro ou negativo
      */
        static void Main(string[] args) {
            Console.WriteLine("Entre com um número inteiro ");
            int numero = Convert.ToInt16(Console.ReadLine());

            int compareNumero = numero > 0 ? 1 : numero < 0 ? 2 : 3;

            switch (compareNumero) {
                case 1:
                    Console.WriteLine($"{numero} é positivo");
                    break;
                case 2:
                    Console.WriteLine($"{numero} é negativo");
                    break;
                case 3:
                    Console.WriteLine($"{numero} é neutro");
                    break;
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_10 {
    internal class Program {
        /*
         ATIVIDADE 10
         Peça um valor monetario, em seguida escolha o tipo de conversão.
         Real para Dólar.
         Dólar par Real
         Retorne o valor convertido*/
        static void Main(string[] args) {
            decimal moedaUSD = 5.65M;
            Console.WriteLine("Informe um valor monetario ");
            decimal moeda = Convert.ToDecimal(Console.ReadLine());
            decimal converDolarReal = moeda * moedaUSD;
            decimal converRealDolar = moeda / moedaUSD;
            Console.WriteLine($"Escolha o tipo de conversão\n[1: conversão de Real para Dólar]\n[2: conversão de Dólar para Real ]");
            int conversor = Convert.ToInt16(Console.ReadLine());
            switch (conversor)
            {
                case 1:
                    Console.WriteLine($" USD {converDolarReal.ToString("F2")} ");
                    break;
                case 2:
                    Console.WriteLine($" BRL {converRealDolar.ToString("F2")} ");
                    break;
                default:
                    Console.WriteLine("Moeda indisponivel paar conversão");
                    break;
            }

            Console.ReadKey();
        }
    }
}

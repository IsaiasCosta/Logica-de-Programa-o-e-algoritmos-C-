using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_24 {
    internal class Program {
        static void Main(string[] args) {

            int[] numero = new int[5];
            double media = 0;
            int soma = 0;
            for (int i = 0; i < numero.Length; i++)
            {
                Console.WriteLine($"Numeros da posição {i + 1}");
                numero[i] = Convert.ToInt16(Console.ReadLine());
                soma += numero[i];
                media = soma / 5.0;
            }
            Console.WriteLine($"Média {media}");
            for (int i = 0; i < numero.Length; i++)
            {
                if (numero[i] >= media)
                {
                    Console.WriteLine($"Número: {numero[i]} é igual ou maior que a média {media}");
                }

            }
            Console.ReadKey();
        }
    }
}

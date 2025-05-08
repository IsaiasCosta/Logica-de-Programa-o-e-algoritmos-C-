using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_25 {
    internal class Program {
        static void Main(string[] args) {

            int[] num = new int[5];

            Console.Write("Entre com  5 números inteiro = ");
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt16(Console.ReadLine());
                if (num[i] == 5)
                {
                    Console.Write($"N° 5 esta na  Posição: {i} ");
                }
                else
                {
                    Console.Write($"Númro 5 não foi encontrado = ");
                }
            }


            Console.ReadKey();
        }
    }
}

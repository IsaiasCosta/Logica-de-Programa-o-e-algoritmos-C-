using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_01
{
    public class Program
    {
        /* ATIVIDAE 01
           Peça dois numeros inteiros, se forem iguais realize uma soma,
           se forem diferentes realize a multiplicação
        */
        static void Main(string[] args)
        {


            Console.WriteLine("Entre com o 1° numero inteiro");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o 2° numero inteiro");
            int num2 = int.Parse(Console.ReadLine());


            if (num1 == num2)
            {
                Console.WriteLine("Soma = " + (num1 + num2));
            }
            else
            {
                Console.WriteLine($"Multicação ="+ (num1 * num2));
            }
            Console.ReadKey();
        }
    }
}

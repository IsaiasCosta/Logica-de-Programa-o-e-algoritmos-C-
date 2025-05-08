using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_11 {
    internal class Program {
        /*ATIVIDADE
            Peça um número inteiro e retorne a tabuada.*/
        static void Main(string[] args) {

            Console.WriteLine("Entre com um numero inteiro");
            int num = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("--------------Tabuada Soma");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} + {i} = {num + i}");

            }
            Console.WriteLine("---------------Tabuada subtração");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} - {i} = {num - i}");

            }
            Console.WriteLine("--------------Tabuada Divisão ");
            for (int i = 1; i <= 10; i++)
            {
                int div = num / i;
                if (i == 0)
                    Console.WriteLine("Não é possivel dividir por zero");
                else
                {
                    Console.WriteLine($"{num} ÷ {i} = {num / i}");
                }

            }
            Console.WriteLine("-----------------Tabuada Multiplicação");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }

            Console.ReadKey();
        }
    }
}

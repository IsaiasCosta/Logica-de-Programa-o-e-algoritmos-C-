using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_15 {
    internal class Program {
        /*ATIVIDADE 15
         Será gerado aleatoreiamente um número entre 1 e 10.
         Enquanto o usuario não acertar o número, peça para informar um valor.
        */

        //Gerar número aleatorio
        //  Random random = new Random();

        //Armazenar um número aleatorio entre 1 e 10
        // int numeroAleatorio = random.Next(1, 11);
        //Exibir o nuero aleatorio
        // Console.WriteLine(numeroAleatorio);
        static void Main(string[] args) {
            Random random = new Random();
            string sair;

            do
            {
                int num;
                do
                {
                    Console.WriteLine("Entre com um número inteiro de 1 a 10");
                    num = Convert.ToInt16(Console.ReadLine());
                    if (num > 10)
                    {
                        Console.WriteLine($"{num} invalido");
                    }

                } while (num < 1 || num > 10);


                int aleatorio = random.Next(1, 11);

                int sorteio = (num != aleatorio) ? 1 : 2;
                switch (sorteio)
                {
                    case 1:
                        Console.WriteLine($"n° informado {num} - n° sorteado {aleatorio} não foi dessa vez");
                        break;
                    case 2:
                        Console.WriteLine($"n° informado {num} - n° sorteado {aleatorio} acertou");
                        break;
                    default:
                        Console.WriteLine($"Número inválido {num}");
                        break;
                }
                Console.WriteLine("Deseja tentar novamente? Entre com um novo número ou digite 'sair' para encerrar:");
                sair = Console.ReadLine();
            } while (sair.ToLower() != "sair");

            Console.ReadKey();
        }
    }
}

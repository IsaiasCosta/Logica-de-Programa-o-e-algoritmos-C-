using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_22 {
    internal class Program {
        /*ATIVIDADE 22
         Crie um vetor com 5 nomes.
        Sera ´pedidoum nome aleatoerio, retorn se o nome existe no vetor.
        */
        static void Main(string[] args) {

            string[] nomes = { "Julia", "Alfredo", "Gal", "Fred", "Nadia" };

            Console.WriteLine("Informe um nome aleatório");
            string nomeAleatorio = Console.ReadLine();

                if (nomes.Contains(nomeAleatorio))
                {
                    Console.WriteLine($"Nome aleatório {nomeAleatorio} existe na lista");
                }
                else { Console.WriteLine($"Nome aleatório não existe na lista "); }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_23 {
    internal class Program {
        /*ATIVIDADE*
         * PEÇA CINCO NOMES E ADICIONE CADA NOME E UMA POSIÇÃO DO VETOR.
         * dEPOSI EXIBA CADA NOME INFORMADO
         */
        static void Main(string[] args) {

            string[] nomes = new string[5];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Nome da posição: {i + 1}");
                nomes[i] = Console.ReadLine(); ;
            }
            Console.WriteLine($"Nomes digitados:");

            for (int i = 0; i < nomes.Length; i++)
            {
                string nome = nomes[i];
                Console.WriteLine($"{nome}");

            }
            Console.ReadKey();
        }
    }
}

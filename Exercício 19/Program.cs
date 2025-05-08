using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_19 {
    internal class Program {
        /*
         ATIVIDADE 19 
         Criar um laço de repetição paar exibir 5 valores aleatorios entre 1 e 30.
        Alem de exibir o número, retorne se é par ou impar*/
        static void Main(string[] args) {


            Random rnd = new Random();

            int numeroAleatorio = rnd.Next(1, 31);


            for (int i = 0; i <= numeroAleatorio; i++)
            {
                //Console.WriteLine("");
                //if (i % 2 == 0)
                //{
                //    Console.WriteLine($"Par => {i}");
                //}

                //else if (i % 2 == 1)
                //{
                //    Console.WriteLine($"Impar=> {i} ");
                //}
                string aleatorio = i % 2 == 0 ? "Par" : "Impar";
                Console.WriteLine($" {aleatorio} - {i} ");
            }
            Console.ReadKey();
        }
    }
}

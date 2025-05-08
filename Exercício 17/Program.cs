using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_17 {
    internal class Program {
        /*Atividade 17
         Sistema de votação*/
        static void Main(string[] args) {

            int voto, votosAna = 0, votosRobson = 0, votosEvandro = 0;
            do
            {
                Console.WriteLine("Vote no seu canditado [1: Ana] - [2: Robson] - [3: Evandro] - [4:Sair]");
                voto = Convert.ToInt16(Console.ReadLine());

                switch (voto)
                {
                    case 1:
                        votosAna++;
                        Console.WriteLine($"Voto da  Ana");
                        break;
                    case 2:
                        votosRobson++;
                        Console.WriteLine($"Voto da  Robson");
                        break;
                    case 3:
                        votosEvandro++;
                        Console.WriteLine($"Voto da  Evandro");
                        break;
                    default:
                        Console.WriteLine($"opção inválida");
                        break;
                }

                Console.WriteLine($"\nResultado da votação\nVotos da Ana:{votosAna}" +
                                  $"\nVotos do Robson: {votosRobson}" +
                                  $"\nVotos do Evandro: {votosEvandro}");
            }

            while (voto != 4);
            Console.WriteLine("==========  Votação encerrada. =======");
            Console.ReadKey();
        }
    }
}

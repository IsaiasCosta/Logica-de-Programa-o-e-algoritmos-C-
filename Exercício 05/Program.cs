using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_05
{
    internal class Program
    {/*ATIVIDADE 05
      ano bisexto*/
        static void Main(string[] args)
        {
            Console.WriteLine("INFORME QUAL QUER E DECUBRA SE ELE É BISEXTO");
            int ano = Convert.ToInt16(Console.ReadLine());
            int anoBisexto = (ano % 400 == 0 || (ano % 4 == 0 && ano % 100 != 0)) ? 1 : 2;


            switch (anoBisexto) 
            {
                case 1:
                    Console.WriteLine($"{ano} é bisexto");
                    break; 
                case 2:
                    Console.WriteLine($"{ano} não é bisexto");
                    break;
            }Console.ReadKey();
        }
    }
}

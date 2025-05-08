using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_20 {
    internal class Program {
        /*ATIVIDADE 20
         Exiba cem asrteriscos da seguinte maneira*/
        static void Main(string[] args) {

            for (int i = 1; i <= 100; i++)
            {
                Console.Write("*");
                if (i % 10 == 0)
                {
                    Console.WriteLine("*");
                }
            }
            Console.ReadKey();
        }
    }
}

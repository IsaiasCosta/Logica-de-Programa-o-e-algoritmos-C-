using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_03
{
    internal class Program
    { /* Atividade 03
       * Peça duas notas , em seguida realize a média e retorne a situação.
       * 7-10 : Aprovado(a)
       * 5 -6.9: Recuperação
       * 0 -4.9 ?: Reaprovado(a)
       */
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a 1 ° nota");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a 2 ° nota");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double media = (num1 + num2)/2;

            int categoria = media >= 7 && media <= 10 ? 1 : media >= 5 && media < 7 ? 2 : 3;

            switch (categoria)
            {
                case 1:
                    Console.WriteLine($"A média {media} Aluno(a) Aprovado");
                    break;
                case 2:
                    Console.WriteLine($"A média {media} Aluno(a) Recuperação");
                    break;
                case 3:
                    Console.WriteLine($"A média {media} Aluno(a) Reprovado");
                    break;
            }
        }
    }
}

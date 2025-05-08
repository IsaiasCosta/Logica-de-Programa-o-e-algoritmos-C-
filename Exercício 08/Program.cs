using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_08 {
    internal class Program {
        /*ATIVIDADE 8  
         Peça 3 lados de um triangulo e retorne o seu tipo:  

         Equilatero: todos os lados congruentes.  
         Isosceles: dois lados congruentes  
         Escaleno: todos os lados com medidas distintas.*/
        static void Main(string[] args) {
            Console.WriteLine("Entre com o 1° lado do Triângulo:");
            double ladoA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com o 2° lado do Triângulo:");
            double ladoB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com o 3° lado do Triângulo:");
            double ladoC = Convert.ToDouble(Console.ReadLine());

            if (ladoA <= 0 || ladoB <= 0 || ladoC <= 0)
            {
                Console.WriteLine("Os lados devem ser valores positivos.");
                return;
            }

            if (ladoA + ladoB > ladoC && ladoA + ladoC > ladoB && ladoB + ladoC > ladoA)
            {
                if (ladoA == ladoB && ladoB == ladoC)
                {
                    Console.WriteLine("O triângulo é Equilátero.");
                }
                else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                {
                    Console.WriteLine("O triângulo é Isósceles.");
                }
                else
                {
                    Console.WriteLine("O triângulo é Escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Os valores fornecidos não formam um triângulo.");
            }
        }
    }
}

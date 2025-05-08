using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_26 {
    internal class Program {
        static void Main(string[] args) {

            int[,] num = new int[3, 3];

            int soma=0;
            Console.WriteLine("Entre com os valores da Matriz 3x3");

            for (int linha = 0; linha < num.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < num.GetLength(1); coluna++)
                {
                    Console.WriteLine($"Matriz: [{linha} - {coluna}]");
                    num[linha, coluna] = Convert.ToInt16(Console.ReadLine());
                    soma += num[linha, coluna];
                }
            }

            Console.WriteLine("Matriz 3 x 3");
            for (int linha = 0; linha < num.GetLength(0); linha ++)
            {
                for (int coluna = 0; coluna < num.GetLength(1); coluna++)
                {
                    Console.WriteLine($"Matriz: [ {linha} - {coluna} ]");
                }

            }
            Console.WriteLine($"Soma da Matriz 3x3 = {soma}");

            Console.ReadKey();
        }
    }
}

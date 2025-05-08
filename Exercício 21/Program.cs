using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_21 {
    internal class Program {
        /*
         * ATIVIDADE 21
          * Crie um vetor de 5 numeros e  retorne  a soma
          */
        static void Main(string[] args) {

            int[] vetNum = { 2,5,9,4,8};

            int soma = 0;
            for (int i = 0; i < vetNum.Length ; i++)
            {
                soma += vetNum[i];
                Console.Write(soma+$"+");
            }
       
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_16 {
    internal class Program {
        //ATIVIDADE 16
        //    Peça um número inteiro, em seguida crie uma estrutura de repetição
        //    que deverá iniciazr pelo numero 1 e finalizar pelo número informado.

        //    Retorne a quantidade de números pares e impares entre os valores.
        //    Exempolo: Se infromar 5, o laço irá percorrer os valores
        //    1,2,3,4, e 5
        //    Retornar 2 pares e 3 impares.

        static void Main(string[] args) {
            int par = 0,impar = 0;
            Console.WriteLine("Entre com um número inteiro");
            int num = Convert.ToInt16(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if(i % 2 == 0) par++;
                else  impar++;
            }
            Console.WriteLine($"Quantidade de pares {par} | Qauntidade de impar {impar}");
            Console.ReadKey();
        }
    }
}

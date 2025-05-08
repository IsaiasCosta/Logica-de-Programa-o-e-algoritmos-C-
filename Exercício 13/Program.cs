using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_13 {
    internal class Program {
        /*ATIVIDADE 12
        Peça  diversos numeros inteiro, até que seja informado o número zero.
        quando sair da estrutura repetição, exiba a soma dos valores informados
        Exemplos: 7,8,9 e 0
        A soma será =25 */
        static void Main(string[] args) {

            int num=0, soma=0;
            do
            {
                Console.WriteLine("entre com varios numeros inteiros");
                num = Convert.ToInt16(Console.ReadLine());
                soma += num;
            } while (num != 0);
                Console.WriteLine($"{soma}");

            Console.ReadKey();
        }
    }
}

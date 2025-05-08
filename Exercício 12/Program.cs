using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_12 {
    internal class Program {
        /*ATIVIDADE 12
         peça um nome até que seja informado o termo sair*/
        static void Main(string[] args) {

            string nome;
            do
            {
                Console.WriteLine("Entre com qual nome ");
                nome = Console.ReadLine();
      
            } while (nome.ToLower() != "sair");
            Console.WriteLine("programa encerrado, tecle enter para sair !");
            Console.ReadKey();
        }
    }
}

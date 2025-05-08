using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_04
{
    internal class Program
    {/* ATIVIDADE 04
       Peça um determinado dia  mes/ano, retorne o dia da semana
        
      */


        static void Main(string[] args)
        {
            int dia, mes, ano;
            Console.WriteLine("Informe qual dia do mes de maio");
            dia = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Informe o mes ");
            mes = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Informe o ano ");
            ano = Convert.ToInt16(Console.ReadLine());

            var diasSemana = new Dictionary<string, List<int>>
            {
                { "quinta",new List<int> { 1, 8, 15, 22, 29 }},
                {  "sexta",new List<int> { 2, 9, 16, 23, 30 }},
                {  "sabado" ,new List<int> { 3, 10, 17, 24, 31 }},
                {  "domingo" ,new List<int> { 4, 11, 18, 25 }},
                {  "segunda", new List<int>{ 5, 12, 19, 26 }},
                {  "terca",new List<int> { 6, 13, 20, 27 }},
                {  "quarta" ,new List<int> { 7, 14, 21, 28 }},
            };


            foreach (var diaSemana in diasSemana)
            {
                if (diaSemana.Value.Contains(dia))
                {
                    Console.WriteLine($"{dia}/{mes}/{ano} coresponde a ao dia da semana {diaSemana.Key}");
                    break;
                }
            }

                Console.ReadKey();
        }
    }
}

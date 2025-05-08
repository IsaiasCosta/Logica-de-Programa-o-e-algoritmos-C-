using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_09 {
    internal class Program {
        /*ATIVIDADE 09
        Peça uma hora referente ao horario de Brasilia (0 a 23).
        Em seguida liste 3 cidades e peça para selecionar uma.
        Tendo essas duas informações, retorne o horario da cidade selecionada.

        Algumas cidades es eus respectivos fuso horario.
        Tóquio:+12
        Lisbos: +4
        Paris:+5
         */
        static void Main(string[] args) {

            Console.WriteLine("Entre com o horario de Brasilia ");
            var horaB = Convert.ToInt16(Console.ReadLine());

            var horarioBrasilia = new DateTime(1, 1, 1, horaB, 0, 0);
            var horarioToquio = horarioBrasilia.AddHours(12);
            var horarioLisboa = horarioBrasilia.AddHours(4);
            var horarioParis = horarioBrasilia.AddHours(5);

            Console.WriteLine($"[1 = horario de Toquio] - [2= Horario de Lisboa]  - [3 = Horario de Paris]");
            int fusoHorario = Convert.ToInt16(Console.ReadLine());
            switch (fusoHorario)
            {
                case 1:
                    Console.WriteLine($" Em Brasilia são {horarioBrasilia} - em Toquio {horarioToquio}");
                    break;
                case 2:
                    Console.WriteLine($" Em Brasilia são {horarioBrasilia} - em Toquio {horarioLisboa}");
                    break;
                case 3:
                    Console.WriteLine($" Em Brasilia são {horarioBrasilia} - em Toquio {horarioParis}");
                    break;
                default:
                    Console.WriteLine("Fuso horario invalido !");
                    break;

            }
            Console.ReadKey();
        }
    }
}

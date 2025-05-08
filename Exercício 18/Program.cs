using System;
using System.Collections.Generic;

namespace Exercício_18 {
    internal class Program {
        static void Main(string[] args) {
            double nota1, nota2;
            int qtoAlunosR = 0, qtoAlunosA = 0;
            string resposta;

            // Usamos listas para permitir adicionar alunos dinamicamente
            List<string> nomes = new List<string>();
            List<double> medias = new List<double>();

            do
            {
                Console.Write("Quantos alunos serão cadastrados? ");
                int qto = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < qto; i++)
                {
                    Console.Write($"Entre com o nome do {i + 1}° aluno: ");
                    string nome = Console.ReadLine();
                    nomes.Add(nome);

                    Console.Write($"Entre com a 1ª nota de {nome}: ");
                    nota1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write($"Entre com a 2ª nota de {nome}: ");
                    nota2 = Convert.ToDouble(Console.ReadLine());

                    double media = (nota1 + nota2) / 2;
                    medias.Add(media);

                    if (media >= 7)
                        qtoAlunosA++;
                    else
                        qtoAlunosR++;
                }

                Console.Write("\nDeseja cadastrar mais alunos? Digite 'não' para encerrar ou pressione Enter para continuar: ");
                resposta = Console.ReadLine().Trim().ToLower();

            } while (resposta != "não");

            // Exibindo os resultados
            Console.WriteLine("\nMédias dos Alunos:");
            for (int i = 0; i < nomes.Count; i++)
            {
                string status = medias[i] >= 7 ? "Aprovado" : "Reprovado";
                Console.WriteLine($"{nomes[i]}: {medias[i]:F2} - {status}");
            }

            Console.WriteLine($"\nTotal de alunos Aprovados: {qtoAlunosA}");
            Console.WriteLine($"Total de alunos Reprovados: {qtoAlunosR}");
        }
    }
}

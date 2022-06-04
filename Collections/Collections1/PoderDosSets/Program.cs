using System;
using System.Collections.Generic;

namespace PoderDosSets
{
    class Program
    {
        static void Main(string[] args)
        {
            //SETS = CONJUNTOS

            //Não permite duplicidade e os elementos não são mantidos em ordem específica

            //Declarando set de alunos
            ISet<string> alunos = new HashSet<string>();
            alunos.Add("Vanessa Toniti");
            alunos.Add("Ana Losnak");
            alunos.Add("John Nercess");

            Console.WriteLine(alunos);
            Console.WriteLine(string.Join(", ", alunos));
            Console.WriteLine();


            alunos.Add("Priscilla Stuany");
            alunos.Add("Leonardo Roll");
            alunos.Add("Fábio Gushkan");

            Console.WriteLine(string.Join(", ", alunos));
            Console.WriteLine();


            alunos.Remove("Leonardo Roll");
            alunos.Add("Marcelo Oliver");
            Console.WriteLine(string.Join(", ", alunos));
            Console.WriteLine();


            //Tentando add um aluno existente
            alunos.Add("Marcelo Oliver");
            Console.WriteLine(string.Join(", ", alunos));
            Console.WriteLine();

            //Para ordenação, o método sort não funciona. Criando uma copia da variável dá certo
            List<string> alunosLista = new List<string>(alunos);
            alunosLista.Sort();
            Console.WriteLine(string.Join(", ", alunosLista));
        }
    }
}

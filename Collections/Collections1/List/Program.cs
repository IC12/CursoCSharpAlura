using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections1
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            //List<string> aulas = new List<string>
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            List<string> aulas = new List<string>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);

            Imprimir(aulas);

            Console.WriteLine("A primeira aula é " + aulas[0]);
            Console.WriteLine("A primeira aula é " + aulas.First());

            Console.WriteLine("A última aula é " + aulas[aulas.Count - 1]);
            Console.WriteLine("A última aula é " + aulas.Last());

            aulas[0] = "Trabalhando com Listas";
            Imprimir(aulas);

            Console.WriteLine("A primeira aula 'Trabalhando' é: "
                + aulas.First(aula => aula.Contains("Trabalhando")));

            Console.WriteLine("A última aula 'Trabalhando' é: "
                + aulas.Last(aula => aula.Contains("Trabalhando")));

            //Retorna vazio/nulo por nenhum item da lista conter Conclusão
            Console.WriteLine("A primeira aula 'Conclusão' é: "
                + aulas.FirstOrDefault(aula => aula.Contains("Conclusão")));

            Console.WriteLine("");

            aulas.Reverse();
            Imprimir(aulas);

            Console.WriteLine("");

            aulas.Reverse();
            Imprimir(aulas);

            Console.WriteLine("");

            //Remove a partir do índice
            aulas.RemoveAt(aulas.Count - 1);
            Imprimir(aulas);

            Console.WriteLine("");

            aulas.Add("Conclusão");
            Imprimir(aulas);

            Console.WriteLine("");

            aulas.Sort();
            Imprimir(aulas);

            Console.WriteLine("");

            //Obter faixa de valores/elementos GetRange
            List<string> copia = aulas.GetRange(aulas.Count - 2, 2);
            Imprimir(copia);

            Console.WriteLine("");

            //Cria clone da lista aulas
            List<string> clone = new List<string>(aulas);
            Imprimir(clone);

            Console.WriteLine("");

            //Remover faixa de valores/elementos da lista clone
            clone.RemoveRange(clone.Count - 2, 2);
            Imprimir(clone);
        }

        private static void Imprimir(List<string> aulas)
        {
            //foreach (var aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}


            //for (int i = 0; i < aulas.Count; i++)
            //{
            //    Console.WriteLine(aulas[i]);
            //}


            aulas.ForEach(aula => 
            {
                Console.WriteLine(aula);
            });
        }
    }
}

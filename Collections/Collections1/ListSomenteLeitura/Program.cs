using System;
using System.Collections.Generic;

namespace ListSomenteLeitura
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Collections", "Marcelo Oliveira");
            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            Imprimir(csharpColecoes.Aulas);

            //add 2 aulas
            csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 19));

            Imprimir(csharpColecoes.Aulas);

            //IList não permite usar o método sort para ordenação
            //Copiar a lista para outra lista pode dar certo

            List<Aula> aulasCopiadas = new List<Aula>(csharpColecoes.Aulas);
            aulasCopiadas.Sort();
            Imprimir(aulasCopiadas);

            //Totalizar o tempo do curso
            Console.WriteLine(csharpColecoes.TempoTotal);

            //Detalhes: Implemente o override ToString
            Console.WriteLine(csharpColecoes);
        }

        private static void Imprimir(IList<Aula> aulas)
        {
            Console.Clear();
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }
}

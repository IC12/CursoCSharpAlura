using System;

namespace Collections1
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            //string[] aulas = new string[]
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            string[] aulas = new string[3];
            aulas[0] = aulaIntro;
            aulas[1] = aulaModelando;
            aulas[2] = aulaSets;

            Console.WriteLine(aulas);

            Imprimir(aulas);

            Console.WriteLine(aulas[0]);
            Console.WriteLine(aulas[aulas.Length - 1]);

            aulas[0] = "Trabalhando com Arrays";
            Imprimir(aulas);

            Console.WriteLine("Aulas modelando está no índice " + Array.IndexOf(aulas, aulaModelando));
            Console.WriteLine(Array.LastIndexOf(aulas, aulaModelando));

            //Inverter a ordem dos índices
            Array.Reverse(aulas);
            Imprimir(aulas);

            Console.WriteLine("");

            Array.Reverse(aulas);
            Imprimir(aulas);

            Console.WriteLine("");

            //Redimencionar array, internamente cria outro array e troca a referência da variável aulas
            Array.Resize(ref aulas, 2);
            Imprimir(aulas);

            Console.WriteLine("");

            Array.Resize(ref aulas, 3);
            Imprimir(aulas);

            Console.WriteLine("");

            //Último índice
            aulas[aulas.Length - 1] = "Conclusão";
            Imprimir(aulas);

            Console.WriteLine("");

            //Ordem alfabética
            Array.Sort(aulas);
            Imprimir(aulas);

            Console.WriteLine("");

            string[] copia = new string[2];
            Array.Copy(aulas, 1, copia, 0, 2);
            Imprimir(copia);

            Console.WriteLine("");

            string[] clone = aulas.Clone() as string[];
            Imprimir(clone);

            Console.WriteLine("");

            //Limpar clone
            Array.Clear(clone, 1, 2);
            Imprimir(clone);
        }

        private static void Imprimir(string[] aulas)
        {
            //foreach (var aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}

            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);
            }
        }
    }
}

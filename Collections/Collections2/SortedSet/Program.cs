using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            ISet<string> alunos
                = new SortedSet<string>(new ComparadorMinusculo())
                {
                    "Vanessa",
                    "Ana",
                    "Rafael",
                    "Priscila"
                };
            alunos.Add("Rafael Rollo");
            alunos.Add("Fabio Queiroz");
            alunos.Add("Fabio Queiroz");
            alunos.Add("fabio queiroz");
            alunos.Add("FABIO QUEIROZ");

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            ISet<string> outroConjun = new HashSet<string>();
            //esse conjunto é subconjunto do outro?
            alunos.IsSubsetOf(outroConjun);

            //esse conjunto é superconjunto do outro?
            alunos.IsSupersetOf(outroConjun);

            //os conjuntos contêm os mesmos elementos?
            alunos.SetEquals(outroConjun);

            //Remover elementos da outra coleção que também estão na coleção alunos
            alunos.ExceptWith(outroConjun);

            //Intersecção dos conjuntos
            alunos.IntersectWith(outroConjun);

            //elementos que não fazem parte da intersecção
            alunos.SymmetricExceptWith(outroConjun);

            //União dos conjuntos
            alunos.UnionWith(outroConjun);
        }
    }

    internal class ComparadorMinusculo : IComparer<string>
    {
        public int Compare([AllowNull] string x, [AllowNull] string y)
        {
            return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
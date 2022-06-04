using System;

namespace SetModelo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando
            Curso csharpColecoes = new Curso("C# Coleções", "Marcelo Oliveira");

            //Add cursos
            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 24));

            //Instanciando 3 alunos com matrícula
            Aluno a1 = new Aluno("Vanessa Toniti", 34672);
            Aluno a2 = new Aluno("Ana Losnak", 56172);
            Aluno a3 = new Aluno("Leonardo Nercess", 17645);

            //Matriculando
            csharpColecoes.Matricula(a1);
            csharpColecoes.Matricula(a2);
            csharpColecoes.Matricula(a3);

            Console.WriteLine("Imprimindo os alunos matriculados:");
            foreach (var aluno in csharpColecoes.Alunos)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine();
            //ToString formato

            Console.WriteLine($"O(A) aluno(a) {a1.Nome} está matriculado(a)?");
            Console.WriteLine();
            //Método EstaMatriculado

            Console.WriteLine(csharpColecoes.EstaMatriculado(a1));
            Console.WriteLine();

            //Instanciando aluno igual
            Aluno toniti = new Aluno("vanessa toniti", 34672);
            Console.WriteLine("Toniti está matriculada? " + csharpColecoes.EstaMatriculado(toniti));
            Console.WriteLine();

            //Equals
            Console.WriteLine("São iguais?");
            Console.WriteLine(a1.Equals(toniti));
            Console.WriteLine();
            //Precisa implementar Equals()

            Console.Clear();

            Console.WriteLine("Quem é o aluno com matrícula 56172?");
            //Implementar o método que busca matricula
            Aluno aluno56172 = csharpColecoes.BuscaMatriculado(56172);
            Console.WriteLine("Aluno56172: " + aluno56172);

            //Um dicionário permite associar uma chave (matrícula, no caso) a um valor (aluno, no caso)
            //Implementar dicionário de alunos em Curso

            Console.WriteLine();
            Console.WriteLine("Quem é o aluno 56182?");
            Console.WriteLine(csharpColecoes.BuscaMatriculado(56182));

            //Add outro aluno com mesma chave
            Aluno leo = new Aluno("Leonardo Nercess", 17645);
            //csharpColecoes.Matricula(leo);

            //Trocar aluno com mesma chave
            csharpColecoes.SubstituiAluno(leo);
            Console.WriteLine("Quem é o aluno 17645?");
            Console.WriteLine(csharpColecoes.BuscaMatriculado(17645));
        }
    }
}

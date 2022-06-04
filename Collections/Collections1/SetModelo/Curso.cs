using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace SetModelo
{
    class Curso
    {
        //Implementando um dicionário de alunos
        private IDictionary<int, Aluno> dicionarioAlunos =
            new Dictionary<int, Aluno>();

        //Criando propriedades usando propfull
        private ISet<Aluno> alunos = new HashSet<Aluno>();
        //Podemos usar o SortedSet para ordenação de elementos e funciona de forma similar ao HashSet

        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }
        }

        private IList<Aula> aulas;

        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }
        }

        internal void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }

        private string nome;
        private string instrutor;

        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            this.aulas = new List<Aula>();
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        internal void Matricula(Aluno aluno)
        {
            alunos.Add(aluno);
            this.dicionarioAlunos.Add(aluno.NumMatricula, aluno);
        }

        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

        public int TempoTotal
        {
            get
            {
                //int total = 0;
                //foreach (var aula in aulas)
                //{
                //    total += aula.Tempo;
                //}
                //return total;

                //LINQ = Consulta Integrada à Linguagem

                return aulas.Sum(aula => aula.Tempo);
            }
        }

        public override string ToString()
        {
            return $"Curso: {nome}, Tempo: {TempoTotal}, Aulas: {string.Join(", ", aulas)}";
        }

        public bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }

        internal Aluno BuscaMatriculado(int numMatricula)
        {
            Aluno aluno = null;
            this.dicionarioAlunos.TryGetValue(numMatricula, out aluno);
            return aluno;
        }

        internal void SubstituiAluno(Aluno aluno)
        {
            this.dicionarioAlunos[aluno.NumMatricula] = aluno;
        }
    }
}

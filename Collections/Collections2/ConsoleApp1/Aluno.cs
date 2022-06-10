using System;
using System.Collections.Generic;
using System.Text;

namespace SortedList
{
    class Aluno
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
        }

        private int numMatricula;

        public int NumMatricula
        {
            get { return numMatricula; }
        }

        public Aluno(string nome, int numMatricula)
        {
            this.nome = nome;
            this.numMatricula = numMatricula;
        }

        public override string ToString()
        {
            return $"Nome: {nome}, matrícula: {numMatricula}.";
        }

        public override bool Equals(object obj)
        {
            Aluno outro = obj as Aluno;

            if (outro == null)
            {
                return false;
            }
            return this.nome.ToUpper().Equals(outro.nome);
        }

        //Sempre que implementar o Equals() implemente o GetHashCode()
        //Importante: a rapidez da busca depende do Código de Dispersão!
        public override int GetHashCode()
        {
            return this.nome.ToUpper().GetHashCode();
            //ToUpper verifica nome tanto em maiúscula como em minúscula
        }
    }
}

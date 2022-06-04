using System;
using System.Collections.Generic;
using System.Text;

namespace SetModelo
{
    class Aluno
    {
        private string nome;
        private int numMatricula;

        public Aluno(string nome, int numMatricula)
        {
            this.nome = nome;
            this.numMatricula = numMatricula;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int NumMatricula
        {
            get { return numMatricula; }
            set { numMatricula = value; }
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

        //2 objetos que são iguais possuem o mesmo hash code
        //2 objetos com mesmo hash code não são necessariamente iguais
    }
}

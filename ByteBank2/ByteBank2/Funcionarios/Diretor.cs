using ByteBank2.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank2.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando DIRETOR!");
        }

        public override void AumentSalario()
        {
            Salario *= 1.15;
        }
        
        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }
    }
}

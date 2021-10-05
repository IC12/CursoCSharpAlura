using ByteBank2.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank2.Funcionarios
{
    public class GerenteConta : FuncionarioAutenticavel
    {
        public GerenteConta(string cpf) : base(4000, cpf)
        {

        }

        public override void AumentSalario()
        {
            Salario *= 1.05;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}

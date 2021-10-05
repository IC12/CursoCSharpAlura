using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank2.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO!");

            CPF = cpf;
            Salario = salario;

            TotalFuncionarios++;
        }

        public abstract void AumentSalario();
        //Salario = Salario + (Salario * 0.1);
        //Salario = Salario * 1.1;
        //Salario *= 1.1;

        //get = obter, ganhar
        public abstract double GetBonificacao();
    }
}

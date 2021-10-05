using System;

namespace _3_VariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3!\n");

            double salario = Decimal.Round(1200.5);
            Console.WriteLine("Salário: " + salario);

            double idade = 15.0 / 2;
            Console.WriteLine("Idade: 15.0 / 2 = " + idade);

            Console.ReadLine();
        }
    }
}
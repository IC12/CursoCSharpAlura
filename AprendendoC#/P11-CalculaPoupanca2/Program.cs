using System;

namespace P11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11!\n");

            double valorInvest = 1000;

            for (int contMes = 1; contMes <= 12; contMes++)
            {
                valorInvest *= 1.0036;
                Console.WriteLine("Após " + contMes + " meses, você terá R$ " + valorInvest);
            }

            Console.ReadLine();
        }
    }
}

using System;

namespace P12_CalculaLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12!\n");

            double valorInvest = 1000;
            double fatorRend = 1.0036;

            for (int contAno = 1; contAno <= 5; contAno++)
            {
                for (int contMes = 1; contMes <= 12; contMes++)
                {
                    valorInvest *= fatorRend;
                }
                fatorRend += 0.0010;
            }

            Console.WriteLine("Ao término do investimento, você terá R$ " + valorInvest);

            Console.ReadLine();
        }
    }
}

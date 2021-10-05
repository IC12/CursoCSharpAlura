using System;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10!\n");

            double valorInvest = 1000;
            int contMes = 1;

            while (contMes <= 12)
            {
                //0.36% corresponde a 0.0036.
                valorInvest = valorInvest + valorInvest * 0.0036;
                Console.WriteLine("Após " + contMes + " meses, você terá R$ " + valorInvest);

                //contMes = contMes + 1;
                //contMes += 1;
                contMes++;
            }

            Console.ReadLine();
        }
    }
}

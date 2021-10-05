using System;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7!\n");

            int idadeJoao = 16;
            int qtdPessoa = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos. Pode liberar.");
            }
            else
            {
                if (qtdPessoa >= 2)
                {
                    Console.WriteLine("João não possui mais de 18 anos, mas está acompanhado.");
                }
                else
                {
                    Console.WriteLine("João não possui mais de 18 anos. Não pode liberar.");
                }
            }
            Console.ReadLine();
        }
    }
}

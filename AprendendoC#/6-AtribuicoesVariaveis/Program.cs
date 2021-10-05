using System;

namespace _6_AtribuicoesVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 6!\n");

            int idade = 32;
            int idadePedro = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadePedro);

            Console.ReadLine();
        }
    }
}

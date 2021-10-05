using System;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9!\n");

            int idadeMarcos = 18;
            bool acompanhado = false;
            string msgAdicional;

            if (acompanhado == true)
            {
                msgAdicional = "Marcos está acompanhado!";
            }
            else
            {
                msgAdicional = "Marcos não está acompanhado!";
            }

            if (idadeMarcos >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode entrar.");
                Console.WriteLine(msgAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar.");
                Console.WriteLine(msgAdicional);
            }

            Console.ReadLine();
        }
    }
}

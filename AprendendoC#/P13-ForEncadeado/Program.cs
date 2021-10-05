using System;

namespace P13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 13!\n");

            for (int contLinha = 0; contLinha < 10; contLinha++)
            {
                for (int contColuna = 0; contColuna < 10; contColuna++)
                {
                    Console.Write("*");
                    if (contColuna >= contLinha)
                        break;
                }
                Console.WriteLine();
            }

            //Outra forma de fazer o desenho
            for (int contLinha = 0; contLinha < 10; contLinha++)
            {
                for (int contColuna = 0; contColuna <= contLinha; contColuna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

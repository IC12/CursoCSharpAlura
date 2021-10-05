using System;

namespace _4_ConversõesTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4!\n");

            double salario = 1200.5;
            //int é um tipo de variável que suporta valores até 32 bits
            int salarioEmInteiro = (int)salario;
            //Essa conversão chama casting
            Console.WriteLine("Salário inteiro: R$ " + salarioEmInteiro + ".");

            float altura = 1.8f;
            Console.WriteLine("A altura é: " + altura + " metros.");

            //long é variável de 64 bits
            long anosUniverso = 130000000000000;
            Console.WriteLine("O universo tem " + anosUniverso + " anos.");

            //short é variável de 16 bits
            short qtdProdutos = 15000;
            Console.WriteLine("A quantidade de produtos é " + qtdProdutos + ".");

            Console.ReadLine();
        }
    }
}

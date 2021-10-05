using System;

namespace _5_CaracteresTextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5!\n");

            char letra1 = 'a';
            Console.WriteLine(letra1);

            //C# usa padrões da tabela ASCII
            letra1 = (char)65;
            Console.WriteLine(letra1);

            letra1 = (char)(letra1 + 1);
            Console.WriteLine(letra1);

            Console.WriteLine();
            string titulo = "Alura Cursos de Tecnologia " + 2021 +"!";
            Console.WriteLine(titulo + "\n");

            string cursos = "-.NET;\n" + "-Java;\n" + "-JavaScript.\n";
            Console.WriteLine("Cursos: \n" + cursos);

            Console.ReadLine();
        }
    }
}

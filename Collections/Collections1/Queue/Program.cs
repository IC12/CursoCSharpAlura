using System;
using System.Collections.Generic;
using System.Linq;

namespace Queue
{
    class Program
    {
        static Queue<string> pedagio = new Queue<string>();

        static void Main(string[] args)
        {
            //Fila
            Enfileirar("van");
            Enfileirar("kombi");
            Enfileirar("guincho");
            Enfileirar("pickup");

            //Liberar carro
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
        }

        private static void Desenfileirar()
        {
            //Verifica se tem algum elemento na fila
            if (pedagio.Any())
            {
                //Verifica o próximo que vai sair da fila
                if (pedagio.Peek() == "guincho")
                {
                    Console.WriteLine("guincho está pagando.");
                }
                string veiculo = pedagio.Dequeue();
                Console.WriteLine($"Saiu da fila: {veiculo}");
                ImprimirFila();
            }
        }

        private static void Enfileirar(string veiculo)
        {
            Console.WriteLine($"Entrou na fila: {veiculo}");
            //Enfileirar
            pedagio.Enqueue(veiculo);
            ImprimirFila();
        }

        private static void ImprimirFila()
        {
            Console.WriteLine("Fila:");
            foreach (var v in pedagio)
            {
                Console.WriteLine(v);
            }
        }
    }
}

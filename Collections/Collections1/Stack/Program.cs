using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Coleção pilha
            var navegador = new Navegador();

            navegador.NavegarPara("google.com");
            navegador.NavegarPara("caelum.com.br");
            navegador.NavegarPara("alura.com.br");

            navegador.Anterior();
            navegador.Anterior();
            navegador.Anterior();
            navegador.Anterior();

            navegador.Proximo();
            navegador.Proximo();
            navegador.Proximo();
            navegador.Proximo();
        }
    }

    internal class Navegador
    {
        private readonly Stack<string> historicoAnterior = new Stack<string>();

        private readonly Stack<string> historicoProximo = new Stack<string>();

        private string atual = "vazia";

        public Navegador()
        {
            Console.WriteLine("Página atual: " + atual);
        }

        internal void Anterior()
        {
            //Any verifica se tem algum elemento na pilha
            if (historicoAnterior.Any())
            {
                historicoProximo.Push(atual);
                //obter valor de um elemento na pilha
                atual = historicoAnterior.Pop();
                Console.WriteLine("Página atual: " + atual);
            }
        }

        internal void NavegarPara(string url)
        {
            //Colocar em uma pilha push
            historicoAnterior.Push(atual);
            atual = url;
            Console.WriteLine("Página atual: " + atual);
        }

        internal void Proximo()
        {
            if (historicoProximo.Any())
            {
                historicoAnterior.Push(atual);
                atual = historicoProximo.Pop();
                Console.WriteLine("Página atual: " + atual);
            }
        }
    }
}

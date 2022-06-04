using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> frutas = new List<string>
            {
                "abacate", "banana", "caqui", "damasco", "figo"
            };

            foreach (var fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

            Console.WriteLine();
            //Coleção apropriada para inserção/remoção rápida dentro da lista:
            //Lista Ligada (LinkedList)
            //A ordem é mantida usando Ponteiros

            //Instanciar uma nova lista ligada: dias da semana
            //Add um dia qualquer e esse será o primeiro elemento da lista ligada
            LinkedList<string> dias = new LinkedList<string>();
            var d4 = dias.AddFirst("quarta");
            //cada elemento é um nó: LinkedListNode<T>

            Console.WriteLine("d4.Value: " + d4.Value);
            //Ele não possui o método add mas tem 4 opções para add:
            //AddFirst, AddLast, antes de um nó(AddBefore) e depois de um nó(AddAfter)

            var d2 = dias.AddBefore(d4, "segunda");
            //Agora d2 e d4 estão ligados
            //d2.Next é igual a d4
            //d4.Previous é igual a d2

            var d3 = dias.AddAfter(d2, "terça");
            //ponteiros ou referências d2 e d4 foram redirecionados para d3

            var d6 = dias.AddAfter(d4, "sexta");

            var d7 = dias.AddAfter(d6, "sábado");

            var d5 = dias.AddBefore(d6, "quinta");

            var d1 = dias.AddBefore(d2, "domingo");

            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }
            //Ele não dá suporte ao acesso de índice dias[0]
            //Podemos fazer o laço foreach mas não um for

            //Para encontrar um elemento:
            var quarta = dias.Find("quarta");

            //Remover elemento:
            dias.Remove("quarta");
            //dias.Remove(d4);
        }
    }
}

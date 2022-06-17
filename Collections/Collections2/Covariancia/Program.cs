using System;
using System.Collections.Generic;

namespace Covariancia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String para object:");
            string titulo = "Meses";
            object obj = titulo;
            Console.WriteLine(obj);
            Console.WriteLine();

            Console.WriteLine("Lista de string para lista de objetos:");
            IList<string> listaMeses = new List<string>
            {
                "Janeiro", "Fevereiro", "Março", "Abril",
                "Maio", "Junho", "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };
            Console.WriteLine();
            //IList<object> listaObj = listaMeses;

            Console.WriteLine("string[] para object[]:");
            string[] arrayMeses = new string[]
            {
                "Janeiro", "Fevereiro", "Março", "Abril",
                "Maio", "Junho", "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };
            object[] arrayObj = arrayMeses; //Covariância entre string[] e object[]
            foreach (var item in arrayObj)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            arrayObj[0] = "Primeiro Mês";
            Console.WriteLine(arrayObj[0]);
            Console.WriteLine();

            //arrayObj[0] = 1234;  //Problema covariância do array: fica impossibilitado de mexer com objetos, apenas strings.
            //Console.WriteLine(arrayObj[0]);
            //Console.WriteLine();

            Console.WriteLine("Lista de strings para IEnumerable<object>:");
            IEnumerable<object> enumObj = listaMeses; //Covariância
            foreach (var item in enumObj)
            {
                Console.WriteLine(item);
            }
            //enumObj[0] = 1234  //IEnumerable não permite aplicar indexador
        }
    }
}

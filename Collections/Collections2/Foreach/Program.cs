using System;
using System.Collections.Generic;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            var meses = new string[] //new List<string>
            {
                "Janeiro", "Fevereiro", "Março", "Abril",
                "Maio", "Junho", "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };

            foreach (var mes in meses)
            {
                //mes = mes.ToUpper(); //Proteção da variável de iteração, não pode ser modificada
                //Todas as coleções que implementam a interface IEnumerable podem usar foreach
                meses[0] = meses[0].ToUpper(); //Caso tentar utilizar com array, não gera exceção pq Array não trabalha com a interface IEnumerable
                Console.WriteLine(mes);
            }
        }
    }
}

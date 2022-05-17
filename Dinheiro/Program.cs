﻿using Caelum.Stella.CSharp.Vault;
using System.Diagnostics;
using System.Globalization;

namespace Dinheiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Money money = 10.00;
            Debug.WriteLine(money);

            double valor1 = 10.00;
            double valor2 = 20.00;
            Money total = valor1 + valor2;
            Debug.WriteLine(total);

            decimal minuendo = 20m;
            decimal subtraendo = 15m;
            Money diferenca = minuendo - subtraendo;
            Debug.WriteLine(diferenca);

            Money euro = new Money(Currency.EUR, 1000);
            Debug.WriteLine(euro);

            Money dolar = new Money(Currency.USD, 1000);
            Debug.WriteLine(dolar);

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            Debug.WriteLine(dolar);
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
            Debug.WriteLine(dolar);

            //Money somaMoedasDferentes = euro + dolar;
            //Debug.WriteLine(somaMoedasDferentes);
        }
    }
}

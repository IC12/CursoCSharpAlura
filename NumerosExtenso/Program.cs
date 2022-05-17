using Caelum.Stella.CSharp.Inwords;
using System;
using System.Diagnostics;

namespace NumerosExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 75;
            string extenso = new Numero(valor).Extenso();
            Debug.WriteLine(extenso);

            valor = 1532987897;
            extenso = new Numero(valor).Extenso();
            Debug.WriteLine(extenso);

            Debug.WriteLine(extenso + " reais");

            string extensoBRL = new MoedaBRL(valor).Extenso();
            Debug.WriteLine(extensoBRL);

            valor = 1532987897.89;
            extensoBRL = new MoedaBRL(valor).Extenso();
            Debug.WriteLine(extensoBRL);
        }
    }
}

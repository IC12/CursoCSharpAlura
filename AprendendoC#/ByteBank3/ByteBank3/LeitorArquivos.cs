using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ByteBank3
{
    public class LeitorArquivos : IDisposable
    {
        public string Arquivo { get; }

        public LeitorArquivos(string arquivo)
        {
            Arquivo = arquivo;

            //throw new FileNotFoundException();

            Console.WriteLine("Abrindo arquivo: " + arquivo);
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha...");

            //throw new IOException();
            return "Linha do arquivo";
        }

        public void Dispose()
        {
            Console.WriteLine("Fechando arquivo...");
        }
    }
}

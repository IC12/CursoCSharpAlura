using System;
using System.IO;

namespace ByteBank3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch (Exception)
            {
                Console.WriteLine("Catch no método MAIN");
            }
            

            //try
            //{
            //    ContaCorrente conta = new ContaCorrente(456, 4567890);
            //    ContaCorrente conta2 = new ContaCorrente(456, 7894850);

            //    conta2.Transferir(1000, conta);

            //    conta.Depositar(50);
            //    Console.WriteLine(conta.Saldo);
            //    conta.Sacar(-500);
            //}
            //catch (ArgumentException e)
            //{
            //    if(e.ParamName == "numero")
            //    {

            //    }

            //    Console.WriteLine("Argumento com problema: " + e.ParamName);
            //    Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
            //    Console.WriteLine(e.Message);
            //}
            //catch(SaldoInsuficienteException ex)
            //{
            //    Console.WriteLine(ex.Saldo);
            //    Console.WriteLine(ex.ValorSaque);

            //    Console.WriteLine(ex.StackTrace);

            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Metodo();

            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            using (LeitorArquivos leitor = new LeitorArquivos("teste.txt"))
            {
                // IDisposable
                leitor.LerProximaLinha();
            }

            //LeitorArquivos leitor = null;
            //try
            //{
            //    leitor = new LeitorArquivos("contasx.txt");

            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //}
            //catch(IOException)
            //{
            //    Console.WriteLine("Exceção do tipo IOException capturada e tratada!");
            //}
            //finally
            //{
            //    if (leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
                
            //}
        }

        private static void TestInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(4564, 789645);
                ContaCorrente conta2 = new ContaCorrente(4564, 785469);

                //conta1.Transferir(10000, conta2);
                conta1.Sacar(10000);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                //Console.WriteLine("Informações da InnerException (exceção interna): ");
                //Console.WriteLine(e.InnerException.Message);
                //Console.WriteLine(e.StackTrace);
            }

        }

        //ctrl + kc = comentario

        //Teste com a cadeia de chamada:
        //Metodo -> TestaDivisao -> Dividir
        //private static void Metodo()
        //{
        //    TestaDivisao(0);
        //}

        //public static void TestaDivisao(int divisor)
        //{
        //        int resultado = Dividir(10, divisor);
        //        Console.WriteLine("Resultado da divisão de 10 por " + " é " + resultado);
        //}
        // private static int Dividir(int numero, int divisor)
        //{
        //    try
        //    {
        //        return numero / divisor;
        //    }
        //    catch (DivideByZeroException)
        //    {
        //        Console.WriteLine("Exceção com número = " + numero + " e divisor = " + divisor);
        //        throw;
        //    }
            
        //    //return numero / divisor;
        //}
    }
}

using System;
using TratamentoExceptions.Exceptions;

namespace TratamentoExceptions
{
    class Program
    {
        //Em oposição a resolução de sobrecargas de métodos, 
        //    os blocos catch são visitados de cima para baixo e 
        //    nenhum bloco catch após o catch (Exception) será executado, 
        //    uma vez que este captura todas as exceções do .NET.

        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch (Exception)
            {
                Console.WriteLine("Catch no método main!");
            }


            Console.WriteLine("Execução finalizada. Tecle enter para sair");
            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            //O using faz o papel do try e do finally
            //Primeiro o using executa o metodo como o try
            //Posteriormente ele chama o dispose que precisa ser o metodo que libera
            //ou seja, o metodo fechar()
            //Mas nao faz o catch
            //O catch nao e obrigatorio quando se tem um finally

            using (LeitorDeArquivos leitor = new LeitorDeArquivos("teste.txt"))
            {
                leitor.LerProximaLinha();
            }


            //LeitorDeArquivos leitor = null;

            //try
            //{
            //    leitor = new LeitorDeArquivos("contas.txt");
            //    leitor.LerProximaLinha();
            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("Exceção do tipo IO tratada!");
            //}
            //finally
            //{
            //    if(leitor != null)
            //    {
            //        leitor.Fechar();
            //    }

            //}

        }

        private static void TestarInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(4564, 789684);
                ContaCorrente conta2 = new ContaCorrente(7891, 456789);

                // conta1.Transferir(10000, conta2);

                conta1.Sacar(1000);
            }
            //Deixar o catch com Exception e não é uma boa pois a classe "Exception"
            //é muito generico e pode querer tratar qualquer excecao possivel
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }

        // Teste com a cadeia de chamada:
        // Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com numero=" + numero + " e divisor=" + divisor);
                //Um throw vazio dentro de um bloco catch faz a maquina virtual
                //passa a exceção para o proximo metodo na pilha de chamadas
                //Vai fazer isso ate encontrar um bloco catch que possa pegar essa exceção
                throw;
                Console.WriteLine("Código depois do throw");
            }
        }

    }
}

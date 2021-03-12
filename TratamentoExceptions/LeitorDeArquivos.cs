using System;

namespace TratamentoExceptions
{
    public class LeitorDeArquivos : IDisposable
    {
        public string Arquivo { get; }

        public LeitorDeArquivos(string arquivo)
        {
            Arquivo = arquivo;

            //throw new FileNotFoundException();
            Console.WriteLine("Abrindo arquivo: " + arquivo);
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha...");

           // throw new IOException();
            return "Linha do arquivo";
        }

        //Metodo da interface Dispose
        //Tem a reponsabilidade de liberar os recursos
        public void Dispose()
        {
            Console.WriteLine("Fechando arquivo.");
        }
    }
}

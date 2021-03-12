using System;

namespace Conceitos.Utils
{
    public class ExtratorValorDeArgumentosURL
    {
        //string somente leitura eu só posso atribuir valor no cosntrutor ou na própria declaração
        private readonly string _argumentos;

        public string URL { get; }

        //ctor tab tab cria o construtor
        public ExtratorValorDeArgumentosURL(string url)
        {
            //retorna true para nulo ou vazio
            //string tem letra minuscula pois e uma palavra reservada
            //ela e interpretada como o tipo string, mesmo sendo uma classe

            //String maiuscula é uma referencia direta a classe
            //string é uma palavra reservada que referencia essa classe
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento url não pode ser nulo ou vazio", nameof(url));
            }

            //if (url == null)
            //{
            //    throw new ArgumentNullException(nameof(url));
            //}

            //if (url == "")
            //{
            //    throw new ArgumentException("O argumento url não pode ser uma string vazia.", nameof(url));
            //}

            URL = url;

            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);

        }

        //moedaOrigem=Real&moedaDestino=Dollar
        public string getValor(string nomeParametro)
        {
            nomeParametro = nomeParametro.ToUpper();
            string argumentoCaixaAlta = _argumentos.ToUpper();

            string termo = nomeParametro + "="; //moedaDestino=
            //  int indiceTermo = _argumentos.ToUpper().IndexOf(termo);
            int indiceTermo = argumentoCaixaAlta.IndexOf(termo);

            string resultado = _argumentos.Substring(indiceTermo + termo.Length);
            int indiceEComercial = resultado.IndexOf("&");

            if (indiceEComercial == -1)
            {
                return resultado;
            }

            return resultado.Remove(indiceEComercial);
        }
    }
}

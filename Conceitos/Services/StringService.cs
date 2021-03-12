using Conceitos.Models.Funcionarios;
using Conceitos.Models.Models;
using Conceitos.Utils;
using Humanizer;
using System;
using System.Text.RegularExpressions;

namespace Conceitos.Services
{
    public class StringService
    {
        public void testandoEquals()
        {
            Cliente carlos1 = new Cliente();
            carlos1.Nome = "Carlos";
            carlos1.CPF = "458.623.120-03";
            carlos1.Profissao = "Designer";


            Cliente carlos2 = new Cliente();
            carlos2.Nome = "Carlos";
            carlos2.CPF = "458.623.120-03";
            carlos2.Profissao = "Designer";

            //Esse if faz só a comparação da referencia em memória dessas duas instancias, porém, não faz do seu conteúdo
            if (carlos1 == carlos2)
            {
                Console.WriteLine("São Iguais!");
            }
            else
            {
                Console.WriteLine("São Diferentes!");
            }

            //Esse if faz só a comparação da referencia em memória dessas duas instancias, porém, não faz do seu conteúdo
            //Isso se eu nao fizer um tratamento do metodo equals
            if (carlos1.Equals(carlos2))
            {
                Console.WriteLine("São Iguais!");
            }
            else
            {
                Console.WriteLine("São Diferentes!");
            }


            //Como comparar se o valor dois objetos são iguais????????????

            //O equals é um método virtual então eu posso sobrescreve-lo

            //Sobrescrevendo o metodo Equals na classe cliente eu consigo fazer essa comparacao

            if (carlos1.Equals(carlos2))
            {
                Console.WriteLine("São Iguais!");
            }
            else
            {
                Console.WriteLine("São Diferentes!");
            }

            ContaCorrente conta = new ContaCorrente(5, 4558);

            carlos1.Equals(conta);
        }

        public void testandoObjectEInterpolacao()
        {

            //object é o tipo pai de todos os tipos no .Net, toda classe deriva do tipo object

            object conta = new ContaCorrente(456, 67896);
            Console.WriteLine(conta.ToString());
            Console.WriteLine(conta);


            //    //Interpolação de String, foi implemantada na sua versão 6, é muito útil
            //    //Pode ser realizadas operações matemáticas dentro dessas chaves
            //    return $"Número {Numero}, Agência {Agencia}, Saldo {Saldo} e Conta de 10 + 10: {10 + 10}";

            //    //return "Numero " + Numero + ", agencia " + Agencia + ", Saldo " + Saldo;
        }

        public void expressoesRegulares()
        {
            //Expressoes regulares - regex 
            //O texto padrao pode ser: 
            //string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            //string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            //string padrao = "[0-9]{4,5}[-][0-9]{4}"; Quantificadores {4,5} 
            //string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";

            string textoDeTeste = "Meu nome é Guilherme, me ligue em 11 96894-6663";
            Console.WriteLine("Trabalhando com Regex");

            //Is match só retorna um booleano, mas nao retorna o valor em si
            Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao));

            //Regex nao tem nenhuma ligacao com os indices, o texto que eu procuro pode estar em qualquer posicao dentro de outro

            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado.Value);
        }

        public void contemString()
        {
            string urlGoogle = "http://google.com/?q=http://www.bytebank.com/cambio"; //Como seria a url de pesquisa do Google
            int indiceByteBankGoogle = urlGoogle.IndexOf("http://www.bytebank.com");

            string urlTeste = "http://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("http://www.bytebank.com");


            Console.WriteLine("É uma página do ByteBank ? -- StartsWith");
            Console.WriteLine(urlTeste.StartsWith("http://www.bytebank.com")); //Retorna um booleano informando se uma string esta presente no inicio de outra
            Console.WriteLine("--------------------------------------\r\n");

            Console.WriteLine("String no final de outra ? -- Subdominio ByteBank -- EndsWith");
            Console.WriteLine(urlTeste.EndsWith("cambio/")); //Retorna um booleano informando se uma string esta presente no final de outra
            Console.WriteLine("--------------------------------------\r\n");

            Console.WriteLine("É uma página do ByteBank ? -- Google");
            Console.WriteLine(indiceByteBankGoogle == 0); //Se for uma url de pesquisa do Google ele nao pode dar retorno como sendo
                                                          //url do bytebank
            Console.WriteLine("--------------------------------------\r\n");

            Console.WriteLine("É uma página do ByteBank ? -- ByteBank page");
            Console.WriteLine(indiceByteBank == 0); //Se for maior ou igual a 0 significa que a substring foi encontrada
            Console.WriteLine("--------------------------------------\r\n");

            Console.WriteLine("Contém a string ByteBank ? -- Contains");
            Console.WriteLine(urlTeste.Contains("bytebank")); //Ainda considera se é maiusculo ou minusculo
            Console.WriteLine("--------------------------------------\r\n");

        }

        public void lidandoComDatas()
        {
            // Datas

            DateTime dataFimPagamento = new DateTime(2019, 08, 18);
            DateTime dataCorrente = DateTime.Now;

            //DateTime.Today -- Pega a data atual, porem sem a parte de horas, minutos e segundos
            //TimeSpan serve para fazer calculos com datas
            TimeSpan diferenca = dataFimPagamento - dataCorrente;

            //TimeSpanHumanizeExtensions -- classe de pacote externo -- Humanizer
            Console.WriteLine("Vencimento em: " + TimeSpanHumanizeExtensions.Humanize(diferenca));

            Console.ReadLine(); //Para a aplicacao nao fechar muito rapido

            ContaCorrente conta = new ContaCorrente(847, 489754);

            new ContaCorrente(889, 789456);
            FuncionarioAutenticavel carlos = null;

            Console.WriteLine(conta.Numero);
        }

        public void extracaoArgumentos()
        {
            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";

            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(urlParametros);

            string valorOrigem = extrator.getValor("moedaOrigem");
            Console.WriteLine("Valor de moeda moedaOrigem: " + valorOrigem);

            string valor = extrator.getValor("moedaDestino");
            Console.WriteLine("Valor de moeda moedaDestino: " + valor);


            Console.WriteLine("Argumento valor: " + extrator.getValor("Valor"));
        }

        public void testeUpperLower()
        {
            string testeUpper = "upper";
            string testeLower = "LOWER";

            Console.WriteLine("Teste Lower: " + testeLower.ToLower());
            Console.WriteLine("Teste Upper: " + testeUpper.ToUpper());
        }

        public void testeRemove()
        {
            //testando o metodo remove

            string testeremocao = "primeiraparte&parteremover";
            int indiceecomercial = testeremocao.IndexOf("&");

            Console.WriteLine("string com a remocão de starindex: " + testeremocao.Remove(indiceecomercial));

            Console.WriteLine("string com a remocão de starindex e count: " + testeremocao.Remove(indiceecomercial, 4));
        }

        public void testandoIndexof()
        {
            //Teste palavra
            Console.WriteLine("Teste palavra.");

            //O indexOf sempre pega a primeira ocorrencia e devolve o indice dela,
            //ele ignora as outras ocorrencias 

            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino";

            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da string nomeArgumento: " + nomeArgumento.Length + "\r\n");
            Console.WriteLine(palavra.Substring(indice));

            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length + 1));

            Console.WriteLine("//////////////////////////\r\n");

            ////Teste caracter
            //Console.WriteLine("Teste caracter.");
            //string url = "paginaaaaaaaaaa?argumentos";
            //ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(url);


            ////Pega o indice daquele determinado elemento
            //int indiceInterrogacao = url.IndexOf('?');
            //Console.WriteLine(url);

            ////O substring é inclusivo, ele adiciona o caracter com o indice que voce esta passando no metodo
            //string argumentos = url.Substring(indiceInterrogacao + 1);

            //Console.WriteLine(argumentos);

        }

        public void testandoIsNullOrEmpty()
        {
            string textoVazio = "";
            string textoNulo = null;
            string textoNormal = "teste";

            Console.WriteLine(String.IsNullOrEmpty(textoVazio));

            Console.WriteLine(String.IsNullOrEmpty(textoNulo));

            Console.WriteLine(String.IsNullOrEmpty(textoNormal));
        }
    }
}

using System;

namespace TratamentoExceptions.Exceptions
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double Saldo { get; }
        public double ValorSaque { get; }

        //Boas praticas, um construtor vazio
        public SaldoInsuficienteException()
        {

        }


        public SaldoInsuficienteException(double saldo, double valorSaque)
            : this("Tentativa de saque do valor de" + valorSaque + " em uma conta com saldo de" + saldo)
        //O this faz referencia ao metodo abaixo
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }

        //Um construtor com argumento de mensagem
        public SaldoInsuficienteException(string mensagem)
            : base(mensagem)
        {
            /*Esse método so envia a mensagem para a classe mae Exception, eu deixo ele aqui 
             para o caso de futuramente haver a necessidade de inicializacao de alguma variavel
             ainda estar o metodo aqui*/
        }

        //Um contrutor com a mensagem e a inerException
        public SaldoInsuficienteException(string mensagem, Exception excecaoInterna)
            : base(mensagem, excecaoInterna)
        {

        }
    }
}

using HerancaAndInterface.Funcionarios;
using HerancaAndInterface.Sistemas;
using System;

namespace HerancaAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //O metodo main é estatico, ou seja, ele nao pertence a um objeto, mas sim a classe program

            //Dentro de um metodo estatico eu nao consigo chamar outros metodos que não sejam estaticos
            //(que sejam da mesma classe)
           
            // CalcularBonificacao();

            UsarSistema();
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("159.753.389-04");
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camilla";
            camila.Senha = "abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";
            

            sistemaInterno.Logar(parceiro, "123456");
            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");
        }


        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("159.753.398-84");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            //Nao se pode criar instancia de classes abstratas, somente de classes concreta
            //A linha abaixo gera um erro
            //Funcionario carlos = new Funcionario();


            Desenvolvedor guilherme = new Desenvolvedor("475.458.444-89");
            guilherme.Nome = "Guilherme"; 

            gerenciador.Registrar(pedro);
            gerenciador.Registrar(roberta);
            gerenciador.Registrar(igor);
            gerenciador.Registrar(camila);
            gerenciador.Registrar(guilherme);

            Console.WriteLine("Total de Bonificações do mês " +
                gerenciador.GetTotalBonificacao());                     
        }
    }
}

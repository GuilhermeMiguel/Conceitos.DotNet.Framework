using HerancaAndInterface.Sistemas;

namespace HerancaAndInterface.Funcionarios
{
    //Primeiro vem a classe, depois a interface
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }
        public FuncionarioAutenticavel(double salario, string cpf)
            : base(salario, cpf)
        {

        }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}

namespace HerancaAndInterface.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
   
        public Diretor(string cpf) : base(5000, cpf)
        {

        }
               
        //sobrescrita de metodo
        public override double GetBonificacao()
        {
            //base quer dizer que o metodo é da classe mae
            return Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}

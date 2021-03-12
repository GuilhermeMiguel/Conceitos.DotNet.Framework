namespace HerancaAndInterface.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {

        }

        //sobrescrita de metodo
        public override double GetBonificacao()
        {
            //base quer dizer que o metodo é da classe mae
            return Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
    }
}

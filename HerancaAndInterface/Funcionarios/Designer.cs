namespace HerancaAndInterface.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(3000, cpf)
        {

        }

        //sobrescrita de metodo
        public override double GetBonificacao()
        {
            //base quer dizer que o metodo é da classe mae
            return Salario * 0.17;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }
    }
}

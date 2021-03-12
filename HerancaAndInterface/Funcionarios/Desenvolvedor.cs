namespace HerancaAndInterface.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf) : base(2000, cpf)
        {

        }

        //sobrescrita de metodo
        public override double GetBonificacao()
        {
            //base quer dizer que o metodo é da classe mae
            return Salario * 0.1;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}

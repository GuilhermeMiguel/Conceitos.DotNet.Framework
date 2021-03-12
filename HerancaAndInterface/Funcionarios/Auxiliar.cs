namespace HerancaAndInterface.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(2000, cpf)
        {

        }

        //sobrescrita de metodo
        public override double GetBonificacao()
        {
            //base quer dizer que o metodo é da classe mae
            return Salario * 0.2;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }
    }
}

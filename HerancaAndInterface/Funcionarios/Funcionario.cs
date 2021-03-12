namespace HerancaAndInterface.Funcionarios
{
    //O funcionário é uma abstracao que nos traz os beneficios do polimorfismo
    //Nao posso instanciar a classe funcionario e atriburi uma pessoa a ela, pois, ela generica
    //Cada pessoa é um tipo de funcionario

    //O abstract diz que o funcionario é uma abstracao e nao deve ser diretamente instanciada

    //Nao se pode criar instancia de classes abstratas, somente de classes concretas
    public abstract class Funcionario
    {
        private int _tipo;
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }
   

        //O protected diz que somente a classe base junto as classes
        //filhas podem alterar a propriedade

        /*A palavra chave com a menor visibilidade 
         * é private, depois vem o protected e depois public. 
         * 
         * private - apenas visível dentro da classe; 
         * protected - visível dentro da classe e também para as filhas; 
         * public - visível em todo lugar;
         * 
         * Repare também que protected é relacionado com a herança.
         */


        //Sempre que um funcionario e criado, é adicionado 1
        public Funcionario(double salario, string cpf)
        {
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }

        /*
                A palavra reservada virtual diz que o metodo pode ser sobreescrito na classe filha, ou pode ser utilizada a implementação da classa mãe 
            como o metodo equals da classe Object: 
           
            public virtual bool Equals(Object obj);

            Eu posso utilizar a sua implementação padrão, ou posso reescreve-lo
        */


        /*
                A palavra reservada abstract indica que um metodo deve ter seu corpo escrito numa classe filha concreta 
            Um método abstract não pode ter corpo

        */
        public abstract double GetBonificacao();


        public abstract void AumentarSalario();

    }
}

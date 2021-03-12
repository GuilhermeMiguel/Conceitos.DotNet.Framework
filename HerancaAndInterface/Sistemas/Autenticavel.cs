namespace HerancaAndInterface.Sistemas
{
    //Se a minha classe filha também é abstrata eu nao preciso implementar os 
    //metodos abstratos da classe mae
    public interface IAutenticavel 
    {
        bool Autenticar(string senha);
       
    }
}

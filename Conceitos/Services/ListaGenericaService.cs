using Conceitos.Generics;

namespace Conceitos.Services
{
    public class ListaGenericaService
    {
        public void TestaListaGenerica()
        {
            //Instanciando a minha classe generica 

            ListaGenerica<int> idades = new ListaGenerica<int>();

            idades.AdicionarVarios(1, 5, 7, 8);

            /*INTERESSANTE:
                int, double, bool, float nunca apontam para uma referencia, por isso eles não podem receber nullo, eles sempre recebem valores

                nullo só pode ser atribuido a referencias, como string e não a valores como int
                        int[] arrayDeInt = new int[5];
                        arrayDeInt[0] = null;
            */

            var nomes = new ListaGenerica<string>();
            nomes.AdicionarVarios(
                "Guilherme",
                "Alexandre",
                "Donald",
                "Pateta"
            );
        }
    }
}

using System.Collections.Generic;

namespace Conceitos.Extensoes
{
    public static class ListExtensoes
    {
        //O this quer dizer que esse é o argumento que está sendo estendido
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens)
        {
            foreach(T item in itens)
            {
                lista.Add(item);
            }

        }

        static void Teste()
        {
            List<int> idades = new List<int>();

            idades.Add(14);
            idades.Add(26);
            idades.Add(60);


            //Eu nao preciso passar a lista esta implicito que ela sera passada da seguinte forma:
            //ListExtensoes.AdicionarVarios(idades, 54, 56, 72);
            
            //QUANDO O VISUAL STUDIO PINTA ALGO DE VERDE CLARO, ELE INDICA QUE ESSA COISA PODE SER APAGADA
            idades.AdicionarVarios(54, 56, 72); 

            //Para classe generica
          //  ListExtensoes<int>.AdicionarVarios(idades, 4, 5, 7, 8);


            //Como a classe de extensao e generica (ATENCAO, NNO PRIMEIRO EXEMPLO, SO A CLASSE E GENERICA, eu posso passar para ele quqlquer tipo de dado
            //desde que eu atribua isso entre <> antes de informar o .nomeDoMetodo
            List<string> nomes = new List<string>();
            nomes.Add("Guilherme");


            //nomes.AdicionarVarios<string>("Nao preciso informar o tipo", "o visual ja conhece pelo tipo da lista");
            nomes.AdicionarVarios("Nao preciso informar o tipo", "o visual ja conhece pelo tipo da lista");
            //Para classe generica

            // ListExtensoes<string>.AdicionarVarios(nomes, "Posso passar qualquer nome", "Metodo de extensao");

            //o metodo de extensao eu nao posso chamar em classes estaticas, isso nao passando o tipo antes de .nomeMEtodo


            //No metodo generico eu recebo o <T>
        }
    }
}

using Conceitos.Extensoes;
using System;
using System.Collections.Generic;

namespace Conceitos.Services
{
    public class MetodosDeExtensaoMain
    {
        public void TestaMetodoDeExtensao()
        {

            List<int> idades = new List<int>() { };

            idades.Add(14);
            idades.Add(26);
            idades.Add(60);


            //Eu nao preciso passar a lista esta implicito que ela sera passada da seguinte forma:
            //ListExtensoes.AdicionarVarios(idades, 54, 56, 72);

            //QUANDO O VISUAL STUDIO PINTA ALGO DE VERDE CLARO, ELE INDICA QUE ESSA COISA PODE SER APAGADA
            //idades.AdicionarVarios(54, 56, 72); 

            //Para classe generica
            ListExtensoes.AdicionarVarios(idades, 4, 5, 7, 8);


            List<string> nomes = new List<string>();
            nomes.Add("Guilherme");


            nomes.AdicionarVarios<string>("Nao preciso informar o tipo", "o visual ja conhece pelo tipo da lista");
            nomes.AdicionarVarios("Nao preciso informar o tipo", "o visual ja conhece pelo tipo da lista");


            Console.WriteLine("Nomes: " + nomes);
            Console.WriteLine("Idades: " + idades);
            //Para classe generica

            // ListExtensoes<string>.AdicionarVarios(nomes, "Posso passar qualquer nome", "Metodo de extensao");

            //o metodo de extensao eu nao posso chamar em classes estaticas, isso nao passando o tipo antes de .nomeMEtodo


            //No metodo generico eu recebo o <T>
        }
    }
}

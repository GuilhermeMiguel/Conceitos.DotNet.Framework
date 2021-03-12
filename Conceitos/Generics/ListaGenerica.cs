using System;

namespace Conceitos.Generics
{
    public class ListaGenerica<T>
    {
        //ListaGenerica depende do tipo T, é o argumeto que será substituido em todos os pontos 



        //T para deixar bem evidente que é um tipo genérico
        private T[] _itens;
        private int _proximaPosicao;

        //Tamanho é um propriedade
        public int Tamanho
        {
            //Tamanho é igual quantidade ocupada
            get
            {
                //Eu abro o get pra fazer a lógica necessária 
                return _proximaPosicao;
            }
        }


        //Estou utilizando o argumento opcional do c#, assim nao é necessário fazer uma sobrecarga 
        //do construtor sem o recebimento de um parametro

        //Com um argumento opicional o proprio compilador passa o valor do argumento padrao que eu defini, 
        //fica bem evidente que o valor padrao é 5
        public ListaGenerica(int capacidadeInicial = 5)
        {
            _itens = new T[capacidadeInicial];
            _proximaPosicao = 0;
        }


        //O params indica que nesse método eu posso passar vários argumentos sem estar num array
        //Por exemplo 
        //lista.AdicionarVarios(contaDoGui, new ContaCorrente(874, 5679445));
        public void AdicionarVarios(params T[] itens)
        {
            foreach (T item in itens)
            {
                Adicionar(item); //Assim ele vai adicionando um por vez passando ao método adicionar
            }
        }


        public void Adicionar(T item)
        {
            VerificarCapacidade(_proximaPosicao + 1);

            //Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");

            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        public void Remover(T item)
        {
            int indiceItem = -1;

            for (int i = 0; i < _proximaPosicao; i++)
            {
                T itemAtual = _itens[i];

                if (itemAtual.Equals(item))
                {
                    indiceItem = i;
                    break; //Se eu descobrir que o indice é o do meu item, eu abandono esse array
                }
            }

            // Quero remover o 0x01

            // [0x03] [0x04] [0x05] [null]
            //                       ^
            //                        ` _proximaPosicao

            for (int i = indiceItem; i < _proximaPosicao - 1; i++)
            {
                _itens[i] = _itens[i + 1];
            }

            _proximaPosicao--;
            //Como nao se sabe se T é um tipo de referencia ou um tipo de valor, nao pode-se adicionar null
            // _itens[_proximaPosicao] = null;
        }



        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            int novoTamanho = _itens.Length * 2;
            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }

            //Console.WriteLine("Aumentando capacidade da lista!");

            T[] novoArray = new T[novoTamanho];

            for (int indice = 0; indice < _itens.Length; indice++)
            {
                novoArray[indice] = _itens[indice];
                // Console.WriteLine(".");
            }

            _itens = novoArray;
        }


        public T GetItemNoIndice(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentException(nameof(indice));
            }

            return _itens[indice];
        }

        //Indexadores para na classe program eu acessar meu array com colchetes []
        public T this[int indice]
        {
            get
            {
                return GetItemNoIndice(indice);
            }
        }

        //Sugestao do visual studio para corpo de idexador 
        //public T this[int indice] => GetItemNoIndice(indice);
    }
}


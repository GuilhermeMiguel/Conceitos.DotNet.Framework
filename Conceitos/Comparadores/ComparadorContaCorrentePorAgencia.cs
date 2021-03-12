using Conceitos.Models.Models;
using System.Collections.Generic;

namespace Conceitos.Comparadores
{
    public class ComparadorContaCorrentePorAgencia : IComparer<ContaCorrente>
    {
        public int Compare(ContaCorrente x, ContaCorrente y)
        {           
            if(x == y)
            {
                return 0;
            }

            if(x == null)
            {
                //X fica depois
                return 1;
            }

            if(y == null)
            {
                return -1;
            }

            if(x.Agencia < y.Agencia)
            {
                return -1; // X fica na frente de Y
            }

            if(x.Agencia == y.Agencia)
            {
                return 0; //São equivalentes
            }

            return 1; //Y fica na frente de X


            //Nossas comparações de números inteiros são iguais o que já é existente no tipo int, porque estou passando no int
            //return x.Agencia.CompareTo(y.Agencia);
        }  
    }
}

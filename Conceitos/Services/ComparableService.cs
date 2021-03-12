using Conceitos.Models.Models;
using Conceitos.Comparadores;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Conceitos.Services
{
    public class ComparableService
    {
        public void TestaComparable()
        {
            var contas = new List<ContaCorrente>()
           {
               new ContaCorrente(341, 9),
               //null, //para teste do orderby, ele lança uma exceção
               new ContaCorrente(475, 20),
               //null,
               new ContaCorrente(856, 1),
               new ContaCorrente(989, 6),
               new ContaCorrente(988, 9999)
           };

            contas.Sort(); //==> O sort sem passagem de parametro chama a implementação dada em IComparable

            //
            contas.Sort(new ComparadorContaCorrentePorAgencia());


            //O order by nao altera a lista original, porém ele retorna uma lista ordenada 

            //Ele utiliza o operador de expressoes lambda => -- A expressao em si é conta=> conta.Numero

            //Conta é o argumento recebido no orderby
            //O orderby está iterando pelas contas, ele encurta o caminho pelo Icomparable, CompareTo



            IEnumerable<ContaCorrente> contasNaoNulas = contas.Where(conta => conta != null);

            var contasOrdenadas = contasNaoNulas.OrderBy(conta => conta.Numero);

            contasOrdenadas = contas
                .Where(conta => conta != null)
                .OrderBy(conta => conta.Numero);

            foreach (var conta in contasOrdenadas)
            {
                Console.WriteLine($"Conta número {conta.Numero}, agencia {conta.Agencia}");
            }

            Console.ReadLine();
        }
    }
}

namespace Conceitos.Models.Helpers
{
    internal class AutenticacaoHelper
    {
        /*
            O modificador de acesso que indica que essa classe so pode ser acessada dentro deste projeto/biblioteca
            
            Se eu nao especificar o modificador de acesso numa classe -- Ela é considerada internal
        */

        public bool CompararSenhas(string senhaVerdadeira, string senhaTentativa)
        {
            return senhaVerdadeira == senhaTentativa;
        }
    }
}

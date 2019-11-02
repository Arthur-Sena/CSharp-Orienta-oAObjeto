using System;

namespace GerenciadorDeTarefasCompleto.Utils
{
    public class ValidacaoUtil
    {
        public static bool ValidacaoEmail(string email){
            if(email.Contains("@") && email.Contains(".")){
                return true;            
            }
            return false;
        }//Fim Validação E-mail

        public static bool ValidacaoSenha(string senha,string confirmacaoSenha){
            if (senha.Equals(confirmacaoSenha))
            {
                return true;
            }
            return false;
        }
    }
}
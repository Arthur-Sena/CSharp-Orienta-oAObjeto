using System;

namespace GerenciadorDeTarefasCompleto.ViewModel
{
    public class BaseViewModel
    {
        public int Id {get;set;}
        public string Nome {get;set;}
        public DateTime DataCriacao {get;set;}
    }
}
using System;
using System.Collections.Generic;

namespace GerenciadorDeTarefas.ViewModel
{
    public class UsuarioViewModel
    {
        public int Id {get;set;}
        public string Nome {get;set;}
        public string  Email {get;set;}
        public string Senha {get;set;}
        public string Tipo {get;set;}
        public DateTime DataCriacao {get;set;}

        public static implicit operator List<object>(UsuarioViewModel v)
        {
            throw new NotImplementedException();
        }
    }
}
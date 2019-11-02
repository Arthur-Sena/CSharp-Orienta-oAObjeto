using System;
using System.Collections.Generic;
using GerenciadorDeTarefas.ViewModel;

namespace GerenciadorDeTarefas.Repositório
{
    public class UsuarioRepositorio
    {
        static List<UsuarioViewModel> usuarioRepositorio = new List<UsuarioViewModel>(); 
        
        public UsuarioViewModel Inserir(UsuarioViewModel usuario){
            usuario.DataCriacao = DateTime.Now;

            usuarioRepositorio.Add(usuario);
        
            return usuario;
        }

        public UsuarioViewModel BuscarUsuario(string email, string senha){
            foreach (var item in usuarioRepositorio )
            {
                if (email.Equals(item.Email) && senha.Equals(item.Senha))
                {
                    return item;
                }
            }
            return null;
        }
    }
}
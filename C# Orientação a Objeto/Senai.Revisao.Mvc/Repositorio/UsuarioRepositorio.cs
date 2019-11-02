using System;
using System.Collections.Generic;
using System.IO;
using GerenciadorDeTarefasCompleto.ViewModel;

namespace GerenciadorDeTarefasCompleto.Repositorio {
    public class UsuarioRepositorio {
        public List<UsuarioViewModel> listaDeUsuarios;

        public UsuarioViewModel Inserir (UsuarioViewModel usuario) {
            List<UsuarioViewModel> listaDeUsuarios = Listar ();
            int contador = 0;
            if (listaDeUsuarios != null) {
                contador = listaDeUsuarios.Count;
            }
            usuario.Id = 1;
            usuario.DataCriacao = DateTime.Now;

            //Gera um arquivo CSV

            StreamWriter sw = new StreamWriter ("usuario.csv", true);

            sw.WriteLine ($"{usuario.Id};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataCriacao}");

            sw.Close ();

            return usuario;
        }

        public List<UsuarioViewModel> Listar () {
            List<UsuarioViewModel> listaDeUsuarios = new List<UsuarioViewModel> ();
            UsuarioViewModel usuario;

            if (!File.Exists ("usuario.csv")) {
                return null;
            }

            string[] ususarios = File.ReadAllLines ("usuario.csv");

            foreach (var item in ususarios) {
                if (item != null) {

                    string[] dadosDoUsuario = item.Split (";");
                    usuario = new UsuarioViewModel ();
                    usuario.Id = int.Parse (dadosDoUsuario[0]);
                    usuario.Nome = dadosDoUsuario[1];
                    usuario.Email = dadosDoUsuario[2];
                    usuario.Senha = dadosDoUsuario[3];
                    usuario.DataCriacao = DateTime.Parse (dadosDoUsuario[4]);

                    listaDeUsuarios.Add (usuario);
                }
            }

            return listaDeUsuarios;
        } //fim listar

        public UsuarioViewModel BuscarUsuario (string email, string senha) {
            List<UsuarioViewModel> listaDeUsuarios = Listar();

            foreach (var item in listaDeUsuarios) {
                if (item != null) {
                    if (email.Equals (item.Email) && senha.Equals (item.Senha)) {
                        return item;
                    }
                }
            }

            return null;
        }
    }
}
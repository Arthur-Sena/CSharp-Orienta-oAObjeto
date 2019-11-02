using System;
using System.Collections.Generic;
using GerenciadorDeTarefasCompleto.Repositorio;
using GerenciadorDeTarefasCompleto.Utils;
using GerenciadorDeTarefasCompleto.ViewModel;

namespace GerenciadorDeTarefasCompleto.ViewController
{
    public class UsuarioViewController
    {
        static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        public static void CadastrarUsuario(){
            string nome, email, senha, confirmacaoSenha;

            do
            {
                System.Console.Write("Digite o Nome de Usuário : ");
                nome = Console.ReadLine();
                if (string.IsNullOrEmpty(nome)){
                    System.Console.WriteLine("Nome Inválido");
                }
            } while (string.IsNullOrEmpty(nome));

            do
            {
                System.Console.Write("Digite Seu E-Mail : ");
                email = Console.ReadLine();
                if (!ValidacaoUtil.ValidacaoEmail(email)){
                    System.Console.WriteLine("E-Mail Inválido");
                }
            } while (!ValidacaoUtil.ValidacaoEmail(email));

            do
            {
                System.Console.Write("Digite a Senha : ");
                senha = Console.ReadLine();
                System.Console.Write("Confirme a Senha : ");
                confirmacaoSenha = Console.ReadLine();
                
                if (!ValidacaoUtil.ValidacaoSenha(senha, confirmacaoSenha)){
                    System.Console.WriteLine("As Senhas não conferem");
                }
            } while (!ValidacaoUtil.ValidacaoSenha(senha, confirmacaoSenha));

            UsuarioViewModel usuario = new UsuarioViewModel();
            usuario.Nome = nome;
            usuario.Email = email;
            usuario.Senha = senha;
            
            usuarioRepositorio.Inserir(usuario);

            System.Console.WriteLine("Cadastro Efetuado");
        }

        public static void ListarUsuario(){
            List<UsuarioViewModel> listaDeUsuarios = usuarioRepositorio.Listar(); 
        
            foreach (var item in listaDeUsuarios)
            {
                if (item != null)
                {
                    System.Console.WriteLine($"Id {item.Id} - Nome {item.Nome}");                    
                }
                
            }
        }

        public static UsuarioViewModel EfetuarLogin(){
            string email, senha;

            System.Console.WriteLine("Digite seu email");
            email = Console.ReadLine();
            
            System.Console.WriteLine("Digite sua senha");
            senha = Console.ReadLine();

            UsuarioViewModel usuarioRecuperado = usuarioRepositorio.BuscarUsuario(email, senha);

            if (usuarioRecuperado != null)
            {
                return usuarioRecuperado;
            }
        
            System.Console.WriteLine("Usuário ou Senha Inválidas");
            return null;
        }//Fim Efetuar Login
    }
}
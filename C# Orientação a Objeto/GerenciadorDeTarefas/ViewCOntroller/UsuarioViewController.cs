using System;
using GerenciadorDeTarefas.Repositório;
using GerenciadorDeTarefas.ViewModel;
using static GerenciadorDeTarefas.Utils.ValidacoesUtils;

namespace GerenciadorDeTarefas.ViewController {
    public class UsuarioViewController {
        internal static object usuarioRetornado;
        static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();

        public static void CadastrarUsuario () {
            string nome, email, senha, confirmaSenha;

            System.Console.WriteLine("==================CADASTRO================== \n ");
            System.Console.Write ("Digite Um Nome de Usuario : ");
            nome = Console.ReadLine ();
            do {
                System.Console.Write ("Digite Um E-mail : ");
                email = Console.ReadLine ();

                if (!ValidacoesUtil.ValidadorDeEmail(email))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("E-Mail Inválida, Tente Novamente.");
                    Console.ResetColor();
                    continue;
                }
            }
            while(!ValidacoesUtil.ValidadorDeEmail(email));
            do{
                System.Console.Write ("Digite Uma Senha : ");
                senha = Console.ReadLine ();
                System.Console.Write ("Confirme a Senha : ");
                confirmaSenha = Console.ReadLine ();
                if (!ValidacoesUtil.ValidadorDeSenha(senha, confirmaSenha))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Senha Inválida, Tente Novamente.");
                    Console.ResetColor();
                }

            } while (!ValidacoesUtil.ValidadorDeSenha(senha, confirmaSenha));
                UsuarioViewModel usuarioViewModel = new UsuarioViewModel ();
                usuarioViewModel.Nome = nome;
                usuarioViewModel.Email = email;
                usuarioViewModel.Senha = senha;

                usuarioRepositorio.Inserir(usuarioViewModel);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Usuário Cadastrado com sucesso");
                Console.ResetColor();
        }//Fim Cadastri Usuario

        public static UsuarioViewModel EfetuarLogin(){
            System.Console.WriteLine("====================LOGIN=================== \n ");
            string email, senha;

            do
            {
                System.Console.WriteLine("Digite o seu E-Mail :");
                email = Console.ReadLine();
                // if (!ValidacoesUtil.ValidadorDeEmail(email))
                // {
                //     Console.ForegroundColor = ConsoleColor.Red;
                //     System.Console.WriteLine("E-.");
                //     Console.ResetColor();
                //     continue;
                // }
            }
            while(!ValidacoesUtil.ValidadorDeEmail(email));
           
           
            System.Console.WriteLine("Digite a sua senha : ");
            senha = Console.ReadLine();

            UsuarioViewModel usuarioRetornado = usuarioRepositorio.BuscarUsuario(email,senha);

            if (usuarioRetornado != null)
            {   
                System.Console.WriteLine("Bem-Vindo Ao Gerenciador De Tarefas");
                return usuarioRetornado;
            }else{
                Console.WriteLine($"Usuário ou Senha inválida");
                return null;
            }
        }
    }
}
using System;
using GerenciadorDeTarefasCompleto.Utils;
using GerenciadorDeTarefasCompleto.ViewController;
using GerenciadorDeTarefasCompleto.ViewModel;

namespace GerenciadorDeTarefasCompleto {
    class Program {
        public static object MenuUtils { get; private set; }

        static void Main (string[] args) {
            int opcaoDeslogado = 0;
            do {
                MenuUtil.MenuDeslogado ();
                System.Console.Write ("Digite o número de uma opção : ");
                opcaoDeslogado = int.Parse (Console.ReadLine ());

                switch (opcaoDeslogado) {
                    case 1:
                        //Cadastrar novo usuário
                        UsuarioViewController.CadastrarUsuario ();
                        break;
                    case 2:
                        //Listar todos os usuários
                        UsuarioViewController.ListarUsuario ();
                        break;
                    case 3:
                        //Efetuar Login
                        UsuarioViewModel usuarioRecuperado = UsuarioViewController.EfetuarLogin ();
                        if (usuarioRecuperado != null) {
                            System.Console.WriteLine ($"Bem-Vindo {usuarioRecuperado.Nome}");
                            int opcaoLogado;
                            do {
                                MenuUtil.MenuLogado ();
                                System.Console.Write ("Digite o número de uma opção : ");
                                opcaoLogado = int.Parse(Console.ReadLine());

                                switch (opcaoLogado)
                                {
                                    case 1:
                                    //Cadastrar Produto
                                    ProdutoViewController.CadastrarProduto(usuarioRecuperado);
                                    break;
                                    case 2:
                                    //Listar Produto
                                    ProdutoViewController.Listar();
                                    break;
                                    case 3:
                                    //Buscar por Id

                                    break;
                                    case 0:
                                    //Sair
                                    System.Console.WriteLine("Volte Sempre");
                                    break;
                                    default:
                                    System.Console.WriteLine("Opção Inválida");
                                    break;
                                }
                            } while (true);
                        }
                        break;
                    case 0:
                        System.Console.WriteLine ("Volte Sempre");
                        break;
                    default:
                        System.Console.WriteLine ("Opção Inválida");
                        break;
                }
            } while (opcaoDeslogado != 0);
        }
    }
}
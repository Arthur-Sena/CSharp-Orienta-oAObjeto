using System;
using GerenciadorDeTarefas.Utils;
using GerenciadorDeTarefas.ViewController;
using GerenciadorDeTarefas.ViewCOntroller;

namespace GerenciadorDeTarefas
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                MenuUtils.MenuDeslogado();
                Console.Write(" Digite o Número De Uma Opção : ");
                int opcao = int.Parse(Console.ReadLine());
                System.Console.WriteLine(" ");
                
                bool a = false;
                switch (opcao)
                {
                    case 1:
                        UsuarioViewController.CadastrarUsuario();
                    break;    
                    case 2:    
                        UsuarioViewController.EfetuarLogin();                       
                        do
                        {                
                            MenuUtils.MenuLogado();
                            System.Console.Write("Digite o número da opção : ");
                            int opcaoLogado = int.Parse(Console.ReadLine());

                            switch (opcaoLogado){
                            case 1:
                                LogadoViewController.EscreverTarefa();
                            break;  
                            case 2:
                                LogadoViewController.VisualizarTarefa();
                            break;
                            default:
                                System.Console.WriteLine("Sair");
                                a = !a;
                            break;
                            }
                        } while (!a);
                    break;
                    default:
                        System.Console.WriteLine("Fim");
                        a = !a;
                    break;
                }
            } while (true);
        }
    }
}

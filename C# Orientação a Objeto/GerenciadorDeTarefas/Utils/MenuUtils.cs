using System;
using GerenciadorDeTarefas.ViewController;

namespace GerenciadorDeTarefas.Utils
{
    public class MenuUtils
    {
        public static void MenuDeslogado(){

            Console.WriteLine("----------------- Opções -------------------");
            Console.WriteLine("           1 - Cadastrar Usuário            ");
            Console.WriteLine("           2 - Efetuar Login                ");
            Console.WriteLine("           0 - Sair                         ");
            Console.WriteLine("--------------------------------------------");
            
        }

        public static void MenuLogado(){
            Console.WriteLine("----------------- Opções -------------------");
            Console.WriteLine("           1 - Criar Tarefa                 ");
            Console.WriteLine("           2 - Visualizar Tarefa            ");
            Console.WriteLine("           0 - Sair                         ");
            Console.WriteLine("--------------------------------------------");
        }
    }
}
using System;
namespace GerenciadorDeTarefasCompleto.Utils
{
    public class MenuUtil
    {
        public static void MenuDeslogado(){
            System.Console.WriteLine("========================================");
            System.Console.WriteLine("||     1 - Cadastrar Usuário          ||");
            System.Console.WriteLine("||     2 - Listar                     ||");
            System.Console.WriteLine("||     3 - Efetuar Login              ||");
            System.Console.WriteLine("||     0 - Sair                       ||");
            System.Console.WriteLine("========================================");
        }

        public static void MenuLogado(){
            System.Console.WriteLine("========================================");
            System.Console.WriteLine("||     1 - Cadastrar Produtos         ||");
            System.Console.WriteLine("||     2 - Listar Produtos            ||");
            System.Console.WriteLine("||     3 - Buscar por ID              ||");
            System.Console.WriteLine("||     0 - Sair                       ||");
            System.Console.WriteLine("========================================");
        }
    }
}
using System;

namespace Pizzaria {
    public class Usuario {
        static int contador = 0;

        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }

        public static void Inserir () {

            string nome;
            System.Console.WriteLine ("Digite o nome do usuario");
            nome = Console.ReadLine ();
        }

        public static void ListarUsuario () { }

    }
}
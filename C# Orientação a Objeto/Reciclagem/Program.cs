using System;

namespace Reciclagem {
    class Program {
        static void Main (string[] args) {
            bool querSair = false;
            do {

                System.Console.WriteLine ("Estas são as coisas descartadas por você até agora:");
                int codigo = MenuUtils<LixoEnum>.ExibirMenuPadrao ();
            } while (true);

        }
        public static void Reciclar(Lixo lixo)
    }
}
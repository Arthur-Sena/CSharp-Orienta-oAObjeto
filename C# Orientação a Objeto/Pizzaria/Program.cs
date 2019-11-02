using System;

namespace Pizzaria {
    class Program {
        static void Main (string[] args) {
            bool sair = false;

            do {
                System.Console.WriteLine ("---Digite O Número da Opção ---");
                System.Console.WriteLine (" 1 - Cadastrar Usuário \n 2 - Efetuar Login \n 3 - Listar Usuário");

                int opcao = int.Parse (Console.ReadLine ());
                int contador = 0;

                Usuario[] usuarios = new Usuario[contador];
                switch (opcao) {
                    case 1:

                        Usuario c = new Usuario ();
                        System.Console.WriteLine ("-----Cadastro-----");

                        System.Console.Write ("Digite seu Nome:");
                        c.nome = Console.ReadLine ();

                        System.Console.Write ("Digite o seu Sobrenome:");
                        c.sobrenome = Console.ReadLine ();

                        System.Console.WriteLine ("Digite o seu E-Mail");
                        c.email = Console.ReadLine ();
                        if (c.email.Contains ("@") && c.email.Contains (".")) {
                            Console.WriteLine ("E-Mail Válido ");
                            System.Console.WriteLine (" ");

                            System.Console.WriteLine ("Digite Uma Senha");
                            c.senha = Console.ReadLine ();

                            if (c.senha.Length > 6 && c.senha.Length < 12) {
                                System.Console.WriteLine ("Senha Correta");
                                System.Console.WriteLine (" ");

                                usuarios[contador] = c;
                                contador++;
                            } else {
                                System.Console.WriteLine ("Digite uma senha válida");
                                System.Console.WriteLine (" ");
                                continue;
                            }
                        } else {
                            Console.WriteLine ("Dígite um e-mail válido");
                            System.Console.WriteLine (" ");
                            continue;
                        }


                        break;
                    case 2:
                        System.Console.WriteLine ("-----Login-----");
                        System.Console.Write ("Digite Seu E-Mail : ");
                        string logE = Console.ReadLine ();
                        System.Console.Write ("Digite Sua Senha : ");
                        string logS = Console.ReadLine ();

                        foreach (Usuario item in usuarios) {
                            if(logE.Equals(item.email) && logS.Equals(item.senha)){
                                System.Console.WriteLine($"Você esta conectado {item.nome} {item.sobrenome}");
                                System.Console.WriteLine(" ");
                            } else {
                                System.Console.WriteLine("Tente Novamente");
                                continue;
                            }
                        }
                        break;

                        case 3:

                        break;

                }
            } while (!sair);
        }
    }
}
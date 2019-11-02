using System;
using System.Collections.Generic;
using EscolaDeRock.Models;

namespace EscolaDeRock {
    enum FormacaoEnum : uint {
        TRIO,
        QUARTETO
    }

    enum InstrumentosEnum : uint
    {
        BAIXO,
        BATERIA,
        CONTRABAIXO,
        GUITARRA,
        PIANO,
        TAMBORES,
        VIOLAO
    }
    class Program {
        private static int opcaoFormacaoSelecionada;

        static void Main (string[] args) {
            bool querSair = false;
            string barraMenu = "===================================";
            var opcoesFormacao = new List<string> () {
                "    - 0                         ", //32
                "    - 1                     " //28
            };
            var itensMenuFormacao = Enum.GetNames (typeof (FormacaoEnum));
            int opcoesFormacaoSelecionada = 0;
            do {
                bool formacaoEscolhida = false;
                do {

                    Console.Clear ();
                    System.Console.WriteLine (barraMenu);
                    System.Console.WriteLine ("           Escola De Rock          ");
                    System.Console.WriteLine ("       Escolha Uma Formatação      ");
                    System.Console.WriteLine (barraMenu);

                    for (int i = 0; i < opcoesFormacao.Count; i++) {
                        string titulo = TratarTituloMenu (itensMenuFormacao[i]);

                        if (opcoesFormacaoSelecionada == i) {
                            DestacarOpcao (opcoesFormacao[i].Replace (i.ToString (), titulo).Replace ("-", ">"));
                        } else {
                            System.Console.WriteLine (opcoesFormacao[i].Replace (i.ToString (), titulo));
                        }
                    }

                    var tecla = Console.ReadKey (true).Key;

                    switch (tecla) {
                        case ConsoleKey.UpArrow:
                            opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == 0 ?
                                opcaoFormacaoSelecionada : --opcoesFormacaoSelecionada;
                            break;
                        case ConsoleKey.DownArrow:
                            opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == opcoesFormacao.Count - 1 ?
                                opcaoFormacaoSelecionada : ++opcoesFormacaoSelecionada;
                            break;
                        case ConsoleKey.Enter:
                            formacaoEscolhida = true;
                            break;
                    }

                } while (!formacaoEscolhida);
                bool bandaCompleta = false;
                int vagas = 0;

                switch (opcaoFormacaoSelecionada)
                {
                    case 0:
                        vagas = 2;
                        ExibirMenuDeInstrumentos();
                        System.Console.WriteLine("Digite o código do instrumento para a categoria Harmonia");
                        int codigo = int.Parse(Console.ReadLine());
                        var instrumento = Candidatos.Instrumento[codigo];
                        
                        ColocarNaBanda(instrumento);
                    break;
                    case 1:

                    break;
                }

            } while (!querSair);
        }

        public static string TratarTituloMenu (string titulo) {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase (titulo.Replace ("_", " ").ToLower ());
        }
        public static void ColocarNaBanda(InstrumentoMusical instrumento){
                         
        }

        public static void DestacarOpcao (string opcao) {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine (opcao);
            Console.ResetColor ();
        }
    
        public static void ExibirMenuDeInstrumentos () {
            var instrumentos = Enum.GetNames (typeof (InstrumentosEnum));
            int codigo = 1;
            string menuInstrumentoBorda = "##############################";
            System.Console.WriteLine (menuInstrumentoBorda);
            System.Console.WriteLine ("#         Instrumentos        #");

            foreach (var instrumento in instrumentos) 
            {
                System.Console.WriteLine ($"  {codigo++}.{TratarTituloMenu(instrumento)}");
            }

            System.Console.WriteLine (menuInstrumentoBorda);

        }
    }

    public class Piano
    {
    }

    public class Baixo
    {
    }

    public class Guitarra
    {
    }
}
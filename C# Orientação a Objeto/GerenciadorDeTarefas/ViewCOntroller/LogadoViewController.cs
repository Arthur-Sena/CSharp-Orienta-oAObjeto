using System;
using System.Collections.Generic;
using GerenciadorDeTarefas.Repositório;
using GerenciadorDeTarefas.ViewModel;

namespace GerenciadorDeTarefas.ViewCOntroller
{
    public class LogadoViewController
    {
        static LogadoRepositorio ListarTarefas = new LogadoRepositorio();

        public static void EscreverTarefa(){
            string titulo, descricao;
            DateTime entrega;
            
            System.Console.Write("Digite o Titulo :");
            titulo = Console.ReadLine();
            System.Console.WriteLine("Descreva a tarefa : ");
            descricao = Console.ReadLine();
            System.Console.Write("Digite a Data De Entrega (dd/mm/aaaa) : ");
            entrega = DateTime.Parse(Console.ReadLine());
            
            LogadoViewModel lista = new LogadoViewModel ();
            lista.TituloTarefa = titulo;
            lista.Tarefa = descricao;
            lista.Entrega = entrega;

            ListarTarefas.Inserir(lista);
        }
        public static void VisualizarTarefa(){
            List<LogadoViewModel> ListaDeTarefas = ListarTarefas.Listar();

            foreach (var item in ListaDeTarefas)
            {
                System.Console.WriteLine($"-------------TAREFA {item.Id}-------------\n Titulo : {item.TituloTarefa}\nDescrição : {item.Tarefa} \n Data de Entrega : {item.Entrega} \n ");
            }
        }
    }
}
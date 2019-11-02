using System;
using System.Collections.Generic;
using GerenciadorDeTarefas.ViewModel;

namespace GerenciadorDeTarefas.Repositório
{
    public class LogadoRepositorio
    {
        static List<LogadoViewModel> ListaDeTarefas = new List<LogadoViewModel>();

        public LogadoViewModel Inserir(LogadoViewModel Tarefa){
            
            Tarefa.Id = ListaDeTarefas.Count + 1;
            ListaDeTarefas.Add(Tarefa);
            return Tarefa;
        }
        public List<LogadoViewModel> Listar(){
            return ListaDeTarefas;
        }//Fim Listar/
        
    }
}
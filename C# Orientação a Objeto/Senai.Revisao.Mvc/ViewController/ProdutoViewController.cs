using System;
using System.Collections.Generic;
using GerenciadorDeTarefasCompleto.Repositorio;
using GerenciadorDeTarefasCompleto.ViewModel;

namespace GerenciadorDeTarefasCompleto.ViewController {
    public class ProdutoViewController {
        static ProdutoRepositorio produtoRepositorio = new ProdutoRepositorio();

        public static void CadastrarProduto (UsuarioViewModel usuario) {
            string nome, descricao, categoria;
            float preco;

            System.Console.Write("Digite o nome do produto : ");
            nome = Console.ReadLine ();

            System.Console.WriteLine ("Digite a descrição");
            descricao = Console.ReadLine();
            
            System.Console.Write("Digite a Categoria : ");
            categoria = Console.ReadLine();

            System.Console.Write("Digite o Preço : ");
            preco = float.Parse(Console.ReadLine());
            ProdutoViewModel produto = new ProdutoViewModel();

            produto.Nome = nome;
            produto.Categoria = categoria;
            produto.Descricao = descricao;
            produto.Preco = preco;
            produto.IdResponsavel = usuario.Id;

            produtoRepositorio.Inserir(produto);

            System.Console.WriteLine("Produto Cadastrado Com Sucesso");
            
        } //Fim Cadastrar Produto

        public static void Listar () {
            List<ProdutoViewModel> listaDeProdutos = produtoRepositorio.Listar();

            foreach (var item in listaDeProdutos)
            {
                if (item != null)
                {
                    System.Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Criador: {item.IdResponsavel}");
                }
            } 
        } //Fim Listar
    }
}
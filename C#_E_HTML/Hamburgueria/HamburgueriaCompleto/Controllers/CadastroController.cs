using System;
using Hamburgueria.Models;
using Hamburgueria.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hamburgueria.Controllers
{
    public class CadastroController : Controller
    {
        private ClienteRepositorio ClienteRepository = new ClienteRepositorio();
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Cadastro";
            return View();
        }
        public IActionResult Cadastrar(IFormCollection form)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = form["nome"];
            cliente.Endereco = form["endereco"];
            cliente.Telefone = form["telefone"];
            cliente.Senha = form["senha"];
            cliente.Email = form["email"];
            cliente.DataNascimento = DateTime.Parse(form["data-nascimento"]);

            ClienteRepository.Inserir(cliente);

            ViewData["Action"] = "Cadastro";
            return View("Sucesso");
        }
    }
}
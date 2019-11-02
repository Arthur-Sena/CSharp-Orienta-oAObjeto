using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TSUKAR_Estacionamento.Models;
using TSUKAR_Estacionamento.Repositorio;

namespace TSUKAR_Estacionamento.Controllers {
    public class ClienteController : Controller {
        [HttpGet]
        public IActionResult Index () {
            return View ();
        }
        [HttpPost]
        public IActionResult Cadastrar (IFormCollection form) {
            ClienteModel cliente = new ClienteModel (
                nome: form["nome"],
                modelo: form["modelo"],
                marca: form["marca"],
                placa: form["placa"]
            );
            ClienteRepositorio clienteRepositorio = new ClienteRepositorio ();

            clienteRepositorio.CadastrarCliente (cliente);

            return RedirectToAction ("Index", "Cliente");
        }

        [HttpGet]
        public IActionResult Editar (int id) {
            ClienteRepositorio usuarioRepositorio = new ClienteRepositorio ();
            ClienteModel usuarioRecuperado = usuarioRepositorio.BuscarPorId (id);
            if (usuarioRecuperado != null) {
                ViewBag.usuarios = usuarioRecuperado;
            } else {
                TempData["mensagem"] = "Usuário não encontrado";
                return RedirectToAction ("Listar");
            }

            return View ();
        }

        [HttpGet]
        public IActionResult Listar () {
            ClienteRepositorio clienteRepositorio = new ClienteRepositorio ();
            ViewData["cliente"] = clienteRepositorio.Listar ();

            return View ();
        }

        [HttpGet]
        public IActionResult Editar (IFormCollection form) {
            ClienteModel cliente = new ClienteModel (
                id: int.Parse (form["id"]),
                nome: form["nome"],
                modelo: form["modelo"],
                marca: form["marca"],
                placa: form["placa"],
                dataEntrada: DateTime.Parse (form["dataEntrada"])
            );
            ClienteRepositorio clienteRepositorio = new ClienteRepositorio ();
            clienteRepositorio.EditarCliente (cliente);

            TempData["mensagem"] = $"{cliente.Nome} editado com sucesso";
            return RedirectToAction ("Listar");
        }
    }
}
using System;
using System.IO;
using Ex2WebMVC.Models;
using Ex2WebMVC.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ex2WebMVC.Controllers {

    public class UsuarioController : Controller {
        [HttpGet]
        public IActionResult Index () {

            return View ();
        }

        [HttpPost]
        public IActionResult Cadastrar ([FromForm] UsuarioModel usuario) {

            UsuarioModel usuarioCadastrar = new UsuarioModel(
                nome: usuario.Nome,
                email: usuario.Email,
                dataNascimento: usuario.DataNascimento,
                senha: usuario.Senha
            );
            if (usuario.foto != null && usuario.foto.Length > 0) {
                // Extrai apenas o nome do arquivo
                var fileName = Path.GetFileName (usuario.foto.FileName);
                
                // Define o nome do arquivo
                var NomeArquivo = Guid.NewGuid ().ToString ().Replace ("-", "") + Path.GetExtension (fileName);

                
                //define um caminho para o arquivo
                var CaminhoArquivo = Path.Combine (Directory.GetCurrentDirectory (), "wwwroot\\uploads\\imgs", NomeArquivo);

                
                using (var StreamImagem = new FileStream (CaminhoArquivo, FileMode.Create)) {
                    usuario.foto.CopyTo(StreamImagem);
                }

                usuarioCadastrar.UrlFoto = "/uploads/imgs/" + NomeArquivo;
            }



            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();
            usuarioRepositorio.CadastrarUsuario (usuarioCadastrar);

            return RedirectToAction ("Index", "Usuario");
        }
    

        [HttpGet]
        public IActionResult Listar () {
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();
            ViewData["usuarios"] = usuarioRepositorio.Listar ();

            return View ();
        }

        [HttpGet]
        public IActionResult Editar (int id) {
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();
            UsuarioModel usuarioRecuperado = usuarioRepositorio.BuscarPorId (id);
            if (usuarioRecuperado != null) {
                ViewBag.usuario = usuarioRecuperado;
            } else {
                TempData["mensagem"] = "Usuário não encontrado";
                return RedirectToAction ("Listar");
            }

            return View ();
        }

        [HttpPost]
        public IActionResult Editar (IFormCollection form) {

            UsuarioModel usuario = new UsuarioModel (
                id: int.Parse (form["id"]),
                nome: form["nome"],
                email: form["email"],
                senha: form["senha"],
                dataNascimento: DateTime.Parse (form["dataNascimento"]),
                foto: form["foto"]
            );

            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();
            usuarioRepositorio.EditarUsuario (usuario);

            TempData["mensagem"] = $"{usuario.Nome} editado com sucesso";
            return RedirectToAction ("Listar");

        }
    }
}
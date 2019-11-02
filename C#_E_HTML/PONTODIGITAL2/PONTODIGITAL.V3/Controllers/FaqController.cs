using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PONTODIGITAL.Models;
using PONTODIGITAL.Repositorio;
using PONTODIGITAL.Repositorios;

namespace PONTODIGITAL.Controllers {
    public class FaqController : Controller {

        private FaqRepositorio FaqRepositorio = new FaqRepositorio ();
        string Comentario;
        string Usuario;

        [HttpGet]
        public IActionResult FaqDeslogado(){
            return View();
        }

        [HttpGet]
        public IActionResult Faq () {
            return View ();
        }

        public IActionResult Comentar(IFormCollection form) {
            Faq comentario = new Faq();
            comentario.Comentario = form["comentario"];
        
            FaqRepositorio.Inserir(comentario);
            ViewBag.Comentar = comentario;
            return View("Faq");
        }
        
        public IActionResult Aprovar(IFormCollection form){
            Faq coment = new Faq ();
            coment.Comentario = form["coment"];
            
            FaqRepositorio.Inserir(coment);
            return RedirectToAction("Admin", "Admin");
        }

        public IActionResult QuantidadeUsers(){
            
            ViewBag.QntUser = ClienteRepositorio.CONT;
            
            return null;
        }
    }
}
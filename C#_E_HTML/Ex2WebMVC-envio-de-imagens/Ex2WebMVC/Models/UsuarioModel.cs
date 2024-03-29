using System;
using Microsoft.AspNetCore.Http;

namespace Ex2WebMVC.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string UrlFoto { get; set; }
        public IFormFile foto {get;set;}
        public DateTime DataNascimento { get; set; }

        public UsuarioModel(){
            
        }

        public UsuarioModel(string nome, string email, string senha, DateTime dataNascimento){
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.DataNascimento = dataNascimento;
        }
          public UsuarioModel(int id, string nome, string email, string senha, DateTime dataNascimento, string foto){
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.DataNascimento = dataNascimento;
            this.UrlFoto = foto;
        }
    }
}
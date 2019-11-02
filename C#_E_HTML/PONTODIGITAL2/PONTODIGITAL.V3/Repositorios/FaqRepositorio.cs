using System;
using System.Collections.Generic;
using System.IO;
using PONTODIGITAL.Models;
using static PONTODIGITAL.Repositorios.BaseRepositorio;

namespace PONTODIGITAL.Repositorios {
    public class FaqRepositorio : BaseRepositorios
    {
        private const string PATH = "Database/Comentario.csv";

        private const string PATH_FAQ = "Database/Comentario.csv";

        private List<Faq> coment = new List<Faq> ();

        public FaqRepositorio () {
            if (!File.Exists (PATH_FAQ)) {
                File.Create (PATH_FAQ).Close ();
            }
        
        }
        public bool Inserir (Faq coment) {

            string linha = PrepararRegistroCSV (coment);
            File.AppendAllText (PATH, linha);

            return true;
        }
        private string PrepararRegistroCSV (Faq Coment) {
            return $"Comentario = {coment.Comentario}\n";
        }

        private Faq ConverterEmObjeto (string registro) {

            Faq coment = new Faq();
            System.Console.WriteLine ("REGISTRO:" + registro);
            coment.Comentario = ExtrairCampo ("nome", registro);
            
            return coment;
        }

        public List<Faq> ListarComentarios () {
            var linhas = ObterRegistrosCSV (PATH);
            foreach (var item in linhas) {

                Faq coment = ConverterEmObjeto (item);

                this.coment.Add (coment);
            }
            return this.coment;
        }
    }
}
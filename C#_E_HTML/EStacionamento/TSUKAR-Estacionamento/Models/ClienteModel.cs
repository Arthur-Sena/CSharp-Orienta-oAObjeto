using System;
using Microsoft.Extensions.Primitives;

namespace TSUKAR_Estacionamento.Models {
    public class ClienteModel {
        public string Nome { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Placa { get; set; }
        public DateTime DataEntrada { get; set; }
        public int Id {get;set;}

        public ClienteModel(int id, StringValues nome, StringValues modelo, StringValues marca, StringValues placa, DateTime dataEntrada)
        {
            Id = id;
            Nome = nome;
            Modelo = modelo;
            Marca = marca;
            Placa = placa;
            DataEntrada = dataEntrada;
        }

        public ClienteModel(StringValues nome, StringValues modelo, StringValues marca, StringValues placa)
        {
            Nome = nome;
            Modelo = modelo;
            Marca = marca;
            Placa = placa;
        }
    }
}
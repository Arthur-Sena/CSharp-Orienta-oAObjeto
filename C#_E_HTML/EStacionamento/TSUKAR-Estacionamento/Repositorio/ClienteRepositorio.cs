using System;
using System.Collections.Generic;
using System.IO;
using TSUKAR_Estacionamento.Models;

namespace TSUKAR_Estacionamento.Repositorio
{
    public class ClienteRepositorio
    {
        public ClienteModel CadastrarCliente(ClienteModel cliente){
            if(File.Exists ("Database/cliente.csv")){
                cliente.Id = File.ReadAllLines ("Database/cliente.csv").Length + 1;
            } else {
                cliente.Id = 1;
            }

            cliente.DataEntrada = DateTime.Now;

            StreamWriter sw = new StreamWriter ("Database/cliente.csv", true);
            sw.WriteLine ($"{cliente.Id};{cliente.Nome};{cliente.Modelo};{cliente.Marca};{cliente.Placa};{cliente.DataEntrada}\n");
            sw.Close();

            return cliente;
        }

        public List<ClienteModel> Listar(){
            List<ClienteModel> listarClientes = new List<ClienteModel>();
            string[] linhas = File.ReadAllLines ("Database/cliente.csv");
            ClienteModel cliente;

            foreach (var item in linhas){
                if (string.IsNullOrEmpty (item)){
                    continue;
                }
                string[] linha = item.Split(";");

                cliente = new ClienteModel(
                    id: int.Parse(linha[0]),
                    nome: linha[1],
                    modelo: linha[2],
                    marca: linha[3],
                    placa: linha[4],
                    dataEntrada: DateTime.Parse(linha[5])
                );

                listarClientes.Add (cliente);
            }
            return listarClientes;
        }
        public ClienteModel BuscarPorId (int id) {
            List<ClienteModel> listaDeUsuarios = Listar ();

            foreach (var item in listaDeUsuarios) {
                if (id == item.Id) {
                    return item;
                }
            }
            return null;
        }
        public ClienteModel EditarCliente (ClienteModel cliente){
            string[] linhas = File.ReadAllLines ("Database/cliente.csv");

            for (int i = 0; i < linhas.Length; i++)
            {
                if (string.IsNullOrEmpty(linhas[i])){
                    continue;
                }
                string[] listar = linhas[i].Split(";");
                if (cliente.Id.ToString() == listar[0])
                {
                    linhas[i] = $"{cliente.Id};{cliente.Nome};{cliente.Modelo};{cliente.Marca};{cliente.Placa};{cliente.DataEntrada}";
                    break;
                }
            }
            File.WriteAllLines("Database/cliente.csv", linhas);
            return cliente;
        }
    }
};
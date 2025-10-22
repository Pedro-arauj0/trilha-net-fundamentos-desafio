using System;
using System.Collections.Generic;
using System.Linq;
using ProjetoEstacionamento.Models;

namespace Projetos.Services
{
    public class Estacionamento
    {
        private List<Veiculo> veiculos = new List<Veiculo>();
        private decimal precoInicial = 5.0m;
        private decimal precoPorHora = 2.0m;

        public void CadastrarVeiculo(string placa, string modelo)
        {
            var veiculo = new Veiculo(placa, modelo);
            veiculos.Add(veiculo);
            Console.WriteLine($"✅ Veículo {modelo} - {placa} cadastrado com sucesso!");
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("\n🚗 Veículos estacionados:");
                foreach (var v in veiculos)
                {
                    Console.WriteLine($"- {v.Modelo} | Placa: {v.Placa} | Entrada: {v.HoraEntrada}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum veículo cadastrado.");
            }
        }

        public void RemoverVeiculo(string placa)
        {
            var veiculo = veiculos.FirstOrDefault(v => v.Placa.ToUpper() == placa.ToUpper());
            if (veiculo != null)
            {
                Console.Write("Informe a quantidade de horas que o veículo permaneceu: ");
                if (int.TryParse(Console.ReadLine(), out int horas))
                {
                    decimal valorTotal = precoInicial + precoPorHora * horas;
                    veiculos.Remove(veiculo);
                    Console.WriteLine($"\n🅿️ Veículo {veiculo.Modelo} - {placa} removido com sucesso!");
                    Console.WriteLine($"💰 Valor a pagar: R$ {valorTotal:F2}");
                }
                else
                {
                    Console.WriteLine("❌ Valor de horas inválido.");
                }
            }
            else
            {
                Console.WriteLine("🚫 Veículo não encontrado.");
            }
        }
    }
}

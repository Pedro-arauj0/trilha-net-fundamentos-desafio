using System;

namespace ProjetoEstacionamento.Models
{
    public class Veiculo
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public DateTime HoraEntrada { get; set; }

        public Veiculo(string placa, string modelo)
        {
            Placa = placa;
            Modelo = modelo;
            HoraEntrada = DateTime.Now;
        }
    }
}

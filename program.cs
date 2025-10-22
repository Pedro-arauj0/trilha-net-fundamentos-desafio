using Projetos.Services;
using System;

class Program
{
    static void Main()
    {
        Estacionamento estacionamento = new Estacionamento();
        bool exibirMenu = true;

        while (exibirMenu)
        {
            Console.WriteLine("\n===== MENU PRINCIPAL =====");
            Console.WriteLine("1 - Cadastrar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Encerrar");
            Console.Write("Escolha uma opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Informe a placa: ");
                    string placa = Console.ReadLine();

                    Console.Write("Informe o modelo: ");
                    string modelo = Console.ReadLine();

                    estacionamento.CadastrarVeiculo(placa, modelo);
                    break;

                case "2":
                    Console.Write("Informe a placa do veículo a ser removido: ");
                    string placaRemover = Console.ReadLine();
                    estacionamento.RemoverVeiculo(placaRemover);
                    break;

                case "3":
                    estacionamento.ListarVeiculos();
                    break;

                case "4":
                    exibirMenu = false;
                    Console.WriteLine("Encerrando o programa...");
                    break;

                default:
                    Console.WriteLine("❌ Opção inválida, tente novamente.");
                    break;
            }
        }

        Console.WriteLine("Programa finalizado!");
    }
}

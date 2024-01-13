using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
        
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placaVeicular = Console.ReadLine();

            while (placaVeicular == null || placaVeicular == "" || placaVeicular.Length > 7)
            {
                Console.WriteLine($"Por favor, digite a placa do Veiculo, ate 7 dígitos alfanuméricos:");
                placaVeicular = Console.ReadLine();
            }

            veiculos.Add(placaVeicular);
            Console.WriteLine($"Placa do veiculo {placaVeicular.Substring(0, 3)}-{placaVeicular.Substring(3)}, Cadastrada");

        }
        public void RemoverVeiculo()
        {

            string placa = "";
            Console.WriteLine("Digite a placa do veículo para remover:");
            placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                int horas = 0;
                decimal valorTotal = 0;
              
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                horas = Convert.ToInt32(Console.ReadLine());

                valorTotal = precoInicial + precoPorHora * horas;

                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");

            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach (string veiculoEstacionados in veiculos)
                {
                    Console.WriteLine($"Veiculos Estacionados : {veiculoEstacionados}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}

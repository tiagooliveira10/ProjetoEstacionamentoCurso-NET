namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        public DateTime horarioChegada { get; set; }
        public DateTime horarioSaida { get; set; }
        public decimal valorTotal { get; set; }
        public TimeSpan horas { get; set; }

        public int horarioSaidaManual { get; set; }


        public Estacionamento(decimal precoInicial, decimal precoPorHora, DateTime horarioChegada, DateTime horarioSaida)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
            this.horarioChegada = horarioChegada;
            this.horarioSaida = horarioSaida;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            veiculos.Add(Console.ReadLine());

            horarioChegada = DateTime.Now;
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Quantas horas o veículo permaneceu estacionado?");
                horarioSaidaManual = Convert.ToInt32(Console.ReadLine());

                veiculos.Remove(placa);

                valorTotal = horarioSaidaManual * precoPorHora;
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} permaneceu estacionado por {horarioSaidaManual} hora(s), foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}

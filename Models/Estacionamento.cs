namespace dio.Models
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
            String carro_adcionar = Console.ReadLine();
            veiculos.Add(carro_adcionar);
            Console.WriteLine("Carro adicionado! ");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string carro_remover = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == carro_remover.ToUpper()))
            {

                Console.WriteLine("Quantas horas o veiculo permaneceu parado: ");
                decimal horas_estacionamento = Decimal.Parse(Console.ReadLine());
                decimal total = precoInicial + precoPorHora * horas_estacionamento;


                veiculos.Remove(carro_remover);

                Console.WriteLine($"O veículo {carro_remover} foi removido e o preço total foi de: R$ {total}");
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

                foreach(String carro in veiculos){
                    Console.WriteLine(carro);

                }

            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices.Marshalling;

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
            //IMPLEMENTADO!!!!!!!!!
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine("Veiculo Adcionado!");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            //IMPLEMENTADO!!!!!!!!!
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
           
                //IMPLEMENTADO!!!!!!!!!
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");


                int horas = 0;
                decimal valorTotal = 0;
                horas = int.Parse(Console.ReadLine());
                valorTotal = (precoInicial + precoPorHora * horas);

                //IMPLEMENTADO!!!!!!!!!
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
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                //IMPLEMENTADO!!!!!!!!!
                foreach (var placa in veiculos) 
                Console.WriteLine(placa);
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}

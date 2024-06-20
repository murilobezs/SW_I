namespace exe11
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("My car");

            // Solicita ao usuário informações sobre o carro
            Console.WriteLine("\nDigite as informações do seu carro:");
            Console.Write("Modelo: ");
         
            string modeloDoCarro = Console.ReadLine();
            Console.Write("Ano: ");
            int anoDeFabricacao = int.Parse(Console.ReadLine());

            // Cria um objeto da classe Carro com as informações fornecidas pelo usuário
            Carro carro = new Carro(modeloDoCarro, anoDeFabricacao);

            // resultado
            Console.WriteLine("\n Resultado");
            Console.WriteLine($"Modelo: {carro.Modelo}, Ano: {carro.Ano}, Velocidade: {carro.Velocidade}");

            // Chama o método Acelerar do carro duas vezes e exibe a nova velocidade
            carro.Acelerar();
            Console.WriteLine($"Acelerando... Velocidade: {carro.Velocidade}");
            carro.Acelerar();
            Console.WriteLine($"Acelerando mais uma vez. Velocidade: {carro.Velocidade}");

            // Chama o método Frear do carro duas vezes e exibe a nova velocidade
            carro.Frear();
            Console.WriteLine($"Freando uma vez. Velocidade: {carro.Velocidade}");
            carro.Frear();
            Console.WriteLine($"Freando. Velocidade: {carro.Velocidade}");

            // Chama o método Acelerar do carro duas vezes e exibe a nova velocidade
            carro.Acelerar();
            Console.WriteLine($"Acelerando mais uma vez. Velocidade: {carro.Velocidade}");
            carro.Acelerar();
            Console.WriteLine($"Acelerando mais uma vez. Velocidade: {carro.Velocidade}");

            // Aguarda até que o usuário pressione qualquer tecla para encerrar o programa
            Console.ReadKey();
        }
    }
}
namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CorretoraImoveis corretora = new CorretoraImoveis();
            int opcao;

            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Inserir imóvel");
                Console.WriteLine("2. Alterar preço do imóvel");
                Console.WriteLine("3. Apresentar todos os imóveis");
                Console.WriteLine("4. Calcular valor médio dos imóveis");
                Console.WriteLine("5. Sair");
                Console.Write("\nSelecione uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        InserirImovel(corretora);
                        break;
                    case 2:
                        AlterarPrecoImovel(corretora);
                        break;
                    case 3:
                        ApresentarImoveis(corretora);
                        break;
                    case 4:
                        CalcularValorMedio(corretora);
                        break;
                    case 5:
                        Console.WriteLine("\nSaindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            } while (opcao != 5);
        }

        static void InserirImovel(CorretoraImoveis corretora)
        {
            Console.Write("Endereço: ");
            string endereco = Console.ReadLine();
            Console.Write("Preço: ");
            decimal preco = decimal.Parse(Console.ReadLine());
            Console.Write("Tipo: ");
            string tipo = Console.ReadLine();

            Imovel imovel = new Imovel(endereco, preco, tipo);
            corretora.AdicionarImovel(imovel);

            Console.WriteLine("Imóvel adicionado com sucesso.");
        }

        static void AlterarPrecoImovel(CorretoraImoveis corretora)
        {
            Console.Write("Endereço do imóvel a alterar: ");
            string endereco = Console.ReadLine();
            Console.Write("Novo preço: ");
            decimal novoPreco = decimal.Parse(Console.ReadLine());

            corretora.AlterarPrecoImovel(endereco, novoPreco);
        }

        static void ApresentarImoveis(CorretoraImoveis corretora)
        {
            Console.WriteLine("\nLista de imóveis:");
            corretora.ListarImoveis();
        }

        static void CalcularValorMedio(CorretoraImoveis corretora)
        {
            decimal valorMedio = corretora.CalcularValorMedio();
            Console.WriteLine($"Valor médio dos imóveis: {valorMedio:C}");
        }
    }
}
namespace exe12
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Agenda de Contatos");

            Agenda agenda = new Agenda();

            // Loop infinito para exibir o menu e processar as opções do usuário
            while (true)
            {
                // Exibe o menu de opções
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Adicionar Pessoa");
                Console.WriteLine("2. Remover Pessoa");
                Console.WriteLine("3. Buscar Pessoa");
                Console.WriteLine("4. Imprimir Agenda");
                Console.WriteLine("5. Sair");

                // Solicita ao usuário que escolha uma opção do menu
                Console.Write("\nOpção: ");
                int opcao = int.Parse(Console.ReadLine());

                // Executa uma ação com base na opção escolhida pelo usuário
                switch (opcao)
                {
                    case 1:
                        // Adiciona uma pessoa à agenda
                        Console.WriteLine("\nDigite os dados da pessoa: ");
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Idade: ");
                        int idade = int.Parse(Console.ReadLine());
                        Console.Write("Altura: ");
                        float altura = float.Parse(Console.ReadLine());
                        agenda.ArmazenaPessoa(nome, idade, altura);
                        break;

                    case 2:
                        // Remove uma pessoa da agenda
                        Console.Write("Nome da pessoa a ser removida: ");
                        string nomeParaRemocao = Console.ReadLine();
                        agenda.RemovePessoa(nomeParaRemocao);
                        break;

                    case 3:
                        // Busca uma pessoa na agenda pelo nome
                        Console.Write("Nome da pessoa que deseja buscar: ");
                        string nomeParaBusca = Console.ReadLine();
                        Pessoa pessoa = agenda.BuscaPessoa(nomeParaBusca);

                        // Exibe os dados da pessoa encontrada, se existir
                        if (pessoa != null)
                        {
                            Console.WriteLine($"Pessoa encontrada - Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, Altura: {pessoa.Altura}");
                        }
                        else
                        {
                            Console.WriteLine("Pessoa não encontrada na agenda!");
                        }
                        break;

                    case 4:
                        // Imprime todos os contatos da agenda
                        agenda.ImprimeAgenda();
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opção inválida, tente novamente!");
                        break;
                }
            }
        }
    }
}
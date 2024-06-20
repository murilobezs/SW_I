namespace exe07
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo(a) à sua playlist!");

            // Solicita ao usuário o nome do dono da playlist e armazena na variável donoDaPlaylist
            Console.Write("Informe o nome do dono da playlist: ");
            string donoDaPlaylist = Console.ReadLine();

            // Cria uma nova instância da classe Playlist com o nome do dono informado
            Playlist minhaPlaylist = new Playlist(donoDaPlaylist);

            // Loop infinito para exibir o menu de opções e processar as escolhas do usuário
            while (true)
            {
                // Exibe as opções disponíveis no menu
                Console.WriteLine("\nOpções:");
                Console.WriteLine("1 - Adicionar música");
                Console.WriteLine("2 - Tocar música aleatória");
                Console.WriteLine("3 - Sair");

                Console.Write("Escolha uma opção: ");
                // Lê a opção escolhida pelo usuário
                string escolha = Console.ReadLine();

                // Verifica a opção escolhida pelo usuário e executa a ação correspondente
                if (escolha == "1")
                {
                    // Adiciona uma nova música à playlist
                    Console.Write("Informe o nome da música: ");
                    string nome = Console.ReadLine();

                    Console.Write("Informe o nome do autor: ");
                    string autor = Console.ReadLine();

                    Console.Write("Informe o nome da gravadora: ");
                    string gravadora = Console.ReadLine();

                    // Cria uma nova instância da classe Musica com os dados fornecidos e a adiciona à playlist
                    Musica novaMusica = new Musica(nome, autor, gravadora);
                    minhaPlaylist.AdicionarMúsica(novaMusica);
                }
                else if (escolha == "2")
                {
                    // Toca uma música aleatória da playlist
                    minhaPlaylist.TocarMúsicaAleatória();
                }
                else if (escolha == "3")
                {
                    // Encerra a execução do programa
                    break;
                }
                else
                {
                    // Exibe uma mensagem caso a opção escolhida seja inválida
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }
            }
        }

    }
}
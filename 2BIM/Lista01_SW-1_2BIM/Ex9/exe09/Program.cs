namespace exe09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Solicita ao usuário informações sobre o livro
                Console.Write("Informe o título do livro: ");
                string tituloLivro = Console.ReadLine();
                Console.Write("Informe o autor do livro: ");
                string autorLivro = Console.ReadLine();

                // Cria um objeto Livro com as informações feita pelo usuario
                Livro livro = new Livro(tituloLivro, autorLivro);

                // Exibe as informações do livro cadastrado
                Console.WriteLine("\nInformações do livro cadastrado:");
                Console.WriteLine($"Título: {livro.Titulo}");
                Console.WriteLine($"Autor: {livro.Autor}");
            }
            catch (ArgumentException ex)
            {
                // Captura exceções de argumento inválido (título ou autor vazio) e exibe uma mensagem de erro
                Console.WriteLine($"Erro ao cadastrar livro: {ex.Message}");
            }
        }
    }
}
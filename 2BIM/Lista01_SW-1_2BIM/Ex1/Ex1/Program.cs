namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto("Vinil - 1989 (Taylor's Version) [Taylor Swift]", 250.00m, 10);

            Console.WriteLine(produto);

            produto.AdicionarEstoque(5);
            Console.WriteLine("\nApós adicionar 5 itens ao estoque:");
            Console.WriteLine(produto);

            produto.RemoverEstoque(3);
            Console.WriteLine("\nApós remover 3 itens do estoque:");
            Console.WriteLine(produto);

            Console.WriteLine("\nTentando remover 20 itens do estoque...");
            try
            {
                produto.RemoverEstoque(20);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nErro: {ex.Message}");
            }
        }
    }
}
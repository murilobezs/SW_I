namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto("Macacão - Renner", 239.90m);
            Produto produto2 = new Produto("Jaqueta de couro - Renner", 199.90m);

            RegistroCompras registroCompras = new RegistroCompras(DateTime.Now, produto1, produto1.Preco);//o horário é o da hora em que o progrma foi executado, por isso o .Now

            // Adicionando compras
            registroCompras.AdicionarCompra(new RegistroCompras(DateTime.Now, produto1, produto1.Preco));
            registroCompras.AdicionarCompra(new RegistroCompras(DateTime.Now, produto2, produto2.Preco));

            // Listando compras
            Console.WriteLine("Lista de Compras:");
            registroCompras.ListarCompras();
        }
    }
}
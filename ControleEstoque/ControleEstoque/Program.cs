namespace ControleEstoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto(0123, "Celular", 0, 2300);
            p.imprimir();
            p.entrada(20);
            p.imprimir();
            p.venda(5);
            p.imprimir();
        }
    }
}
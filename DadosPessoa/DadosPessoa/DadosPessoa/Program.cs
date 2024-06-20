namespace DadosPessoa
{
    internal class Program
    {
        public static string Nome { get; private set; }
        public static DateTime dataNascimento { get; private set; }
        public static float Altura { get; private set; }
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.Nome = "Murilo";
            p.dataNascimento = new DateTime(2007, 8, 12, 16, 09, 00);
            p.Altura = 1.62f;

            p.ImprimirDados();

            int idade = p.CalcularIdade();

            Console.WriteLine("Idade: " + idade);

            Console.ReadKey();
        }
    }
}
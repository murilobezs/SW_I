namespace FolhaPagamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os dados do funcionário:");

            FolhaDePagamentos funcionario = new FolhaDePagamentos();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Salário: R$");
            funcionario.SAL = Convert.ToDouble(Console.ReadLine());

            Console.Write("Horas extras diurnas: ");
            funcionario.HED = Convert.ToInt32(Console.ReadLine());

            Console.Write("Horas extras noturnas: ");
            funcionario.HEN = Convert.ToInt32(Console.ReadLine());

            Console.Write("Número de dependentes: ");
            funcionario.NumDependentes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Faltas em horas: ");
            funcionario.Faltas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Descontos eventuais: R$");
            funcionario.DescontosEv = Convert.ToDouble(Console.ReadLine());

            Console.Write("Gastos com refeições feitas na empresa: R$");
            funcionario.GastosRef = Convert.ToDouble(Console.ReadLine());

            Console.Write("Vales retirados durante o mês: R$");
            funcionario.Vales = Convert.ToDouble(Console.ReadLine());

            funcionario.CalculoFolha();
        }
    }
}
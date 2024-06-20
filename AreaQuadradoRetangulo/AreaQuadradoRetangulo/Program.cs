namespace AreaQuadradoRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BEM-VINDO!");
            Console.WriteLine("Cálculo de Área de Quadrado, Retângulo ou Triângulo!");
            Area area= new Area();
            Console.WriteLine("Digite o valor da Base:");
            area.Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor da Altura:");
            area.Altura = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Area: " + area.Calcular());
            Console.WriteLine("Área - " + area.Calcular2());

            area.MostraDetalhes();

        }
    }
}
namespace exe10
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Animal");

            // Solicita ao usuário as informações sobre o animal
            Console.WriteLine("\nDigite as informações do Animal: ");
            Console.Write("Nome: ");
            string nomeDoAnimal = Console.ReadLine();
            Console.Write("Espécie: ");
            string especieDoAnimal = Console.ReadLine();
            Console.Write("Idade: ");
            int idadeDoAnimal = int.Parse(Console.ReadLine());
            Console.Write("Som: ");
            string somDoAnimal = Console.ReadLine();

            // Cria um objeto da classe Animal com as informações fornecidas pelo usuário
            Animal animal = new Animal(nomeDoAnimal, especieDoAnimal, idadeDoAnimal);

            // Exibe o resultado das informações do animal
            Console.WriteLine("\n Resultado");
            Console.WriteLine($"Nome: {animal.Nome}");
            Console.WriteLine($"Espécie: {animal.Especie}");
            Console.WriteLine($"Idade: {animal.Idade} anos");
            Console.Write($"O animal emite o som: ");
            // Chama o método EmitirSom para exibir o som do animal
            animal.EmitirSom(somDoAnimal);

            // Aguarda até que o usuário pressione qualquer tecla para encerrar o programa
            Console.ReadKey();
        }

    }
}
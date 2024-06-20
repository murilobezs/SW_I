namespace AlbumDeFotos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número total de páginas do álbum:");
            int numeroTotalDePaginas = Convert.ToInt32(Console.ReadLine());

            AlbumDeFotos album = new AlbumDeFotos(numeroTotalDePaginas);

            Console.WriteLine("Informe o número de fotos a serem adicionadas:");
            int numeroDeFotos = Convert.ToInt32(Console.ReadLine());

            album.NumeroDeFotos = numeroDeFotos;
        }
    }
}
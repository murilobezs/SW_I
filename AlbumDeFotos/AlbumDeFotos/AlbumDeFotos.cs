using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumDeFotos
{
    public class AlbumDeFotos
    {
        public int _numeroTotalDePaginas;
        public int _numeroDeFotos;

        public AlbumDeFotos(int numeroTotalDePaginas)
        {
            _numeroTotalDePaginas = numeroTotalDePaginas;
        }

        public int NumeroTotalDePaginas
        {
            get { return _numeroTotalDePaginas; }
        }

        public int NumeroTotalDeFotos
        {
            get { return _numeroTotalDePaginas * 2; }
        }

        public int NumeroDeFotos
        {
            get { return _numeroDeFotos; }
            set
            {
                if (value > NumeroTotalDeFotos)
                {
                    Console.WriteLine("Erro: Número de fotos excede o limite total de páginas.");
                }
                else
                {
                    _numeroDeFotos = value;
                    Console.WriteLine("As fotos podem ser adicionadas ao álbum.");
                }
            }
        }
    }
}
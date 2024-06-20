using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe09
{
    public class Livro
    {
        // Propriedades auto-implementadas para o título e autor do livro
        public string Titulo { get; set; }
        public string Autor { get; set; }

        // Construtor da classe Livro
        public Livro(string titulo, string autor)
        {
            // Verifica se o título e o autor não são vazios
            if (string.IsNullOrEmpty(titulo))
            {
                throw new ArgumentException("O título do livro não pode ser vazio.");
            }

            if (string.IsNullOrEmpty(autor))
            {
                throw new ArgumentException("O autor do livro não pode ser vazio.");
            }

            // Define o título e o autor do livro
            Titulo = titulo;
            Autor = autor;
        }
    }
}

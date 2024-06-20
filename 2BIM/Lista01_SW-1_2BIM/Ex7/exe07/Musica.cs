using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe07
{
    public class Musica
    {
        public string nome;
        public string autor;
        public string gravadora;

        // Construtor da classe Musica que inicializa os atributos com os valores fornecidos
        public Musica(string nome, string autor, string gravadora)
        {
            this.nome = nome;
            this.autor = autor;
            this.gravadora = gravadora;
        }
    }
}

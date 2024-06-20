using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe10
{
    public class Animal
    {
        // Declaração de campos privados para armazenar o nome, a espécie e a idade do animal
        private string _nome;
        private string _especie;
        private int _idade;

        // Construtor da classe Animal que inicializa os campos do animal com os valores passados como parâmetros
        public Animal(string nome, string especie, int idade)
        {
            _nome = nome;
            _especie = especie;
            _idade = idade;
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Especie
        {
            get { return _especie; }
            set { _especie = value; }
        }

        public int Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }

        // Método EmitirSom que imprime na tela o som do animal
        public void EmitirSom(string somDoAnimal)
        {
            Console.WriteLine(somDoAnimal);
        }
    }

}

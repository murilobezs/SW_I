using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosPessoa
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime dataNascimento { get; set;}
        public float Altura { get;set;}

        public string GetNome()
        { 
            return Nome;
        }

        public DateTime Nascimento() 
        {
            return dataNascimento;
        }

        public float GetAltura()
        {
            return Altura;
        }

        public void ImprimirDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Data de Nascimento: " + dataNascimento);
            Console.WriteLine("Altura: " + Altura);
        }

        public int CalcularIdade()
        {
            return DateTime.Today.Year - dataNascimento.Year;
        }
    }

}

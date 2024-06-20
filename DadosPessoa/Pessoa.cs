using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosPessoa
{
    class Pessoa
    {
        private string Nome;
        private DateTime dataNascimento;
        private float Altura;

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public DateTime DataNascimento
        {
            get
            {
                return dataNascimento;
            }
            set
            {
                dataNascimento = value;
            }
        }

        public float Altura
        {
            get
            {
                return altura;
            }
            set
            {
                altura = value;
            }
        }

        public int CalcularIdade()
        {
            return DateTime.Today.Year - dataNascimento.Year;
        }
    }
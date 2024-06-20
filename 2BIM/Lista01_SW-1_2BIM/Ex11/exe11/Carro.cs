using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe11
{
    public class Carro
    {
        // Declaração de campos privados para armazenar o modelo, o ano e a velocidade
        private string _modelo;
        private int _ano;
        private int _velocidade;

        // Construtor da classe Carro que inicializa os campos do carro com os valores passados
        public Carro(string modelo, int ano)
        {
            _modelo = modelo;
            _ano = ano;
            _velocidade = 0; // A velocidade inicial é definida como 0
        }

        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        public int Ano
        {
            get { return _ano; }
            set { _ano = value; }
        }

        // Propriedade Velocidade que encapsula o campo _velocidade, permitindo acesso externo apenas para leitura
        public int Velocidade
        {
            get { return _velocidade; }
        }

        // Método Acelerar que aumenta a velocidade do carro em 10 
        public void Acelerar()
        {
            _velocidade += 10;
        }

        // Método Frear que diminui a velocidade do carro em 10 , até no mínimo 0
        public void Frear()
        {
            if (_velocidade >= 10)
            {
                _velocidade -= 10;
            }
            else
            {
                _velocidade = 0;
            }
        }
    }

}

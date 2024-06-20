using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
        public class Produto
        {
            // Atributos
            public string Nome { get; private set; }
            public decimal Preco { get; private set; }

            // Construtor
            public Produto(string nome, decimal preco)
            {
                Nome = nome;
                Preco = preco;
            }

            // Método para exibir informações do produto
            public override string ToString()
            {
                return $"{Nome} - {Preco:C}";
            }
        }

        public class RegistroCompras
        {
            // Atributos
            public DateTime Data { get; private set; }
            public Produto Produto { get; private set; }
            public decimal Valor { get; private set; }

            // Lista de compras
            private List<RegistroCompras> compras = new List<RegistroCompras>();

            // Construtor
            public RegistroCompras(DateTime data, Produto produto, decimal valor)
            {
                Data = data;
                Produto = produto;
                Valor = valor;
            }

            // Método para adicionar uma compra
            public void AdicionarCompra(RegistroCompras compra)
            {
                compras.Add(compra);
            }

            // Método para listar todas as compras
            public void ListarCompras()
            {
                foreach (var compra in compras)
                {
                    Console.WriteLine(compra.ToString());
                }
            }

            // Método para exibir informações da compra
            public override string ToString()
            {
                return $"\nData: {Data}, Produto: {Produto}, Valor: {Valor:C}";
            }
        }
    }

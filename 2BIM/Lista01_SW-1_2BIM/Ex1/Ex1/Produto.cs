using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class Produto
    {
        // Atributos
        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
        public int QuantidadeEstoque { get; private set; }

        // Construtor
        public Produto(string nome, decimal preco, int quantidadeEstoque)
        {
            Nome = nome;
            Preco = preco;
            QuantidadeEstoque = quantidadeEstoque;
        }

        // Método para adicionar itens ao estoque
        public void AdicionarEstoque(int quantidade)
        {
            if (quantidade < 0)
            {
                throw new ArgumentException("A quantidade a adicionar deve ser positiva.");
            }
            QuantidadeEstoque += quantidade;
        }

        // Método para remover itens do estoque
        public void RemoverEstoque(int quantidade)
        {
            if (quantidade < 0)
            {
                throw new ArgumentException("A quantidade a remover deve ser positiva.");
            }
            if (quantidade > QuantidadeEstoque)
            {
                throw new InvalidOperationException("Não há estoque suficiente para remover a quantidade solicitada.");
            }
            QuantidadeEstoque -= quantidade;
        }

        // Método para exibir informações do produto
        public override string ToString()
        {
            return $" Produto: {Nome}\r\n Preço: {Preco:C}\r\n Quantidade em Estoque: {QuantidadeEstoque}";
        }
    }
}
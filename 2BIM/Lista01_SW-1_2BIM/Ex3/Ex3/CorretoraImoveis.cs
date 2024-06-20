using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public class Imovel
    {
        // Atributos
        public string Endereco { get; set; }
        public decimal Preco { get; set; }
        public string Tipo { get; set; }

        // Construtor
        public Imovel(string endereco, decimal preco, string tipo)
        {
            Endereco = endereco;
            Preco = preco;
            Tipo = tipo;
        }

        // Método para exibir informações do imóvel
        public override string ToString()
        {
            return $"Endereço: {Endereco}, Preço: {Preco:C}, Tipo: {Tipo}";
        }
    }

    public class CorretoraImoveis
    {
        // Lista de imóveis
        private List<Imovel> imoveis = new List<Imovel>();

        // Método para adicionar um imóvel
        public void AdicionarImovel(Imovel imovel)
        {
            imoveis.Add(imovel);
        }

        // Método para listar todos os imóveis
        public void ListarImoveis()
        {
            if (imoveis.Count == 0)
            {
                Console.WriteLine("Nenhum imóvel disponível.");
                return;
            }

            foreach (var imovel in imoveis)
            {
                Console.WriteLine(imovel.ToString());
            }
        }

        // Método para alterar o preço de um imóvel
        public void AlterarPrecoImovel(string endereco, decimal novoPreco)
        {
            var imovel = imoveis.FirstOrDefault(i => i.Endereco == endereco);
            if (imovel != null)
            {
                imovel.Preco = novoPreco;
                Console.WriteLine("Preço do imóvel atualizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Imóvel não encontrado.");
            }
        }

        // Método para calcular o valor médio dos imóveis
        public decimal CalcularValorMedio()
        {
            if (imoveis.Count == 0)
            {
                return 0;
            }

            return imoveis.Average(i => i.Preco);
        }
    }

}

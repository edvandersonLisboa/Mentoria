using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.GerenciamentoEstoque
{
/**
    * Atividade 2: 
    *   Gerenciamento de Estoque
    * Problema: 
    *   Crie um sistema de estoque que: 
    *   Use List para armazenar produtos 
    *   Use Dictionary para categorias de produtos 
    *   Calcule valor total do estoque usando LINQ
*/
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Categoria { get; set; }

    }

    public class Estoque
    {
        private List<Produto> _produtos = new();
        private Dictionary<int, string> _categorias = new();

        public void AddProduto(Produto p) => _produtos.Add(p);

        public void AddCategoria(int codigo, string nome) => _categorias.Add(codigo, nome);

        public decimal ValorTotalEstoque => _produtos.Sum(p => p.Preco);

        public IEnumerable<Produto> GetProdutosPorCategoria(string categoria)
        {
            return _produtos.Where(p => p.Categoria == categoria);
        }
    }
}

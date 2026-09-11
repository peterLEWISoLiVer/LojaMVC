using System.ComponentModel.DataAnnotations;

namespace LojaMVC.Models
{
    public class Produto
    {
        [Key]
        public int id_produto {  get; set; }
        public string nome_produto { get; set; }
        public decimal preco_produto { get; set; }
        public int estoque_produto { get; set; }

        public bool produtoValidation()
        {
            return preco_produto > 0 && estoque_produto > 0 && !string.IsNullOrWhiteSpace(nome_produto);

        }
    }
}

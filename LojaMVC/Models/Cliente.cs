using System.ComponentModel.DataAnnotations;

namespace LojaMVC.Models
{
    public class Cliente
    {
        [Key]
        public int id_cliente { get; set; }
        public string nome_cliente { get; set; }
        public string email_cliente { get; set; }
        public int idade_cliente { get; set; }
        public string status_cliente { get; set; }

        public bool clientValidation()
        {
            return idade_cliente > 18 && email_cliente.Contains("@") && !string.IsNullOrWhiteSpace(nome_cliente);
        }
        public bool canBuying() 
        {
            return status_cliente == "ativo"; 
        }
        public bool credentialsValidation()
        {
            return status_cliente == "ativo" && idade_cliente >= 18 && !string.IsNullOrWhiteSpace(email_cliente) ;
        }
    }
}

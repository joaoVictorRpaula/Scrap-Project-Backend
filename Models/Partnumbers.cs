using System.ComponentModel.DataAnnotations;

namespace SCRAP_API.Models
{
    public class Partnumbers
    {
        [Key]
        [Required]
        public int IdPartnumber { get; set; }

        [Required]
        public string Partnumber {get; set;}

        [Required]
        public int ProdutoId {get; set;}

        [Required]
        public virtual Produtos Produto {get; set;}
    }
}

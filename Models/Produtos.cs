using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SCRAP_API.Models
{
    public class Produtos
    {
        [Key]
        [Required]
        public int IdProduto { get; set; }

        [Required]
        public string ProdutoNome { get; set; }

        [Required]
        [JsonIgnore]
        public virtual List<Partnumbers> Partnumbers { get; set; }
    }
}

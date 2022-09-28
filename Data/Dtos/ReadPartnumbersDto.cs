using SCRAP_API.Models;
using System.ComponentModel.DataAnnotations;

namespace SCRAP_API.Data.Dtos
{
    public class ReadPartnumbersDto
    {
        [Required]
        public string Partnumber { get; set; }

        [Required]
        public virtual Produtos Produto { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace SCRAP_API.Models
{
    public class Defeitos
    {
        [Key]
        [Required]
        public int IdDefeito { get; set; }
        [Required]
        public string DefeitoNome { get; set; }
        [Required]
        public string DefeitoCodigo { get; set; }
    }
}

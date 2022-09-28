using System.ComponentModel.DataAnnotations;

namespace SCRAP_API.Data.Dtos
{
    public class ReadDefeitosDto
    {
        [Required]
        public string DefeitoNome { get; set; }
        [Required]
        public string DefeitoCodigo { get; set; }
    }
}

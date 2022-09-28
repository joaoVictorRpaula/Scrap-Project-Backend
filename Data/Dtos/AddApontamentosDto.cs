using System.ComponentModel.DataAnnotations;

namespace SCRAP_API.Data.Dtos
{
    public class AddApontamentosDto
    {

        [Required]
        public string Edv { get; set; }
        [Required]
        public string Partnumber { get; set; }
        [Required]
        public string Operation { get; set; }
        [Required]
        public string Machine {get; set; }
        [Required]
        public string Defeito { get; set; }
        [Required]
        public int Quantidade { get; set; }
        public string Observacoes { get; set; }
    }
}

using SCRAP_API.Models;
using System.ComponentModel.DataAnnotations;

namespace SCRAP_API.Data.Dtos
{
    public class ReadUsersDto
    {
        [Required]
        public string Edv { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public CostCenter CentroCusto { get; set; }

    }
}

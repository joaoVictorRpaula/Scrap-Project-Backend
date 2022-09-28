using System.ComponentModel.DataAnnotations;

namespace SCRAP_API.Data.Dtos
{
    public class ReadOperationsDto
    {
        [Required]
        public int IdOperation { get; set; }
        [Required]
        public string Operation { get; set; }
    }
}

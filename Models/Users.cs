using System.ComponentModel.DataAnnotations;

namespace SCRAP_API.Models
{
    public class Users
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Edv { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public int CostCenterId { get; set; }

        [Required]
        public virtual CostCenter CentroCusto { get; set; }
    }
}

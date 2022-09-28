using System.ComponentModel.DataAnnotations;

namespace SCRAP_API.Models
{
    public class Machines
    {
        [Key]
        [Required]
        public int IdMachine { get; set; }
        [Required]
        public string MachineName { get; set; }
        [Required]
        public string Inventario { get; set; }
        [Required]
        public int OperationId { get; set; }
        [Required]
        public virtual Operations Operation { get; set; }
    }
}

using SCRAP_API.Models;
using System.ComponentModel.DataAnnotations;

namespace SCRAP_API.Data.Dtos
{
    public class ReadMachinesDto
    {
        [Required]
        public string MachineName { get; set; }
        [Required]
        public string Inventario { get; set; }
        [Required]
        public virtual Operations operation { get; set; }

    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SCRAP_API.Models
{
    public class Operations
    {
        [Key]
        [Required]
        public int IdOperation { get; set; }
        [Required]
        public string Operation { get; set; }

        [Required]
        [JsonIgnore]
        public virtual List<Machines> Machines { get; set; }
    }
}

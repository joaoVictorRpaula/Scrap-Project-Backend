using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SCRAP_API.Models
{
    public class CostCenter
    {
        [Key]
        [Required]
        public int IdCostCenter { get; set; }

        [Required]
        public string CentroCusto { get; set; }

        [Required]
        [JsonIgnore]
        public virtual List<Users> Users{ get; set; }
    }
}

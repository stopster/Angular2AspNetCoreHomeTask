using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vega.Models
{
    [Table("Models")]
    public class Model
    {
        public int Id {get; set;}

        public int MakeId{get; set;}
        
        [Required]
        [StringLength(255)]
        public string Name{get; set;}
    }
}
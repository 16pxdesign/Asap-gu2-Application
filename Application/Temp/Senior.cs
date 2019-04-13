using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class Senior 
    {
        [Key]
        [ForeignKey("Player")]
        public string SRU { get; set; }
        public virtual Player Player { get; set; }
        //public virtual Kin Kin { get; set; }

    }
}
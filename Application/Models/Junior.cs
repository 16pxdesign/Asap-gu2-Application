using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class Junior 
    {
        [Key]
        [ForeignKey("Player")]
        public string SRU { get; set; }
        public virtual Player Player { get; set; }
        //public virtual Guardian Guardian { get; set; }
        //public virtual Guardian Guardian2 { get; set; }


    }
}
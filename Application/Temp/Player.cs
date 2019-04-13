using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class Player
    {
        [Key]
        [ForeignKey("Member")]
        public string SRU { get; set; }
        public virtual Member Member { get; set; }
        public virtual Junior Junior { get; set; }
        public virtual Senior Senior { get; set; }
        //public virtual PlayerPosition Position { get; set; }
        //public virtual Doctor Doctor { get; set; }
        //public virtual HealthIssue HealthIssue { get; set; }

    }
}
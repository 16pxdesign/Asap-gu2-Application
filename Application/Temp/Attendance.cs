using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class Attendance
    {
        [Key]
        [Column(Order=1)]
        [ForeignKey("Player")]
        public  string PlayerId { get; set; }
        [Key]
        [Column(Order=2)]
        [ForeignKey("Training")]
        public int TrainingId { get; set; }
        
        public virtual Player Player { get; set; }
        public virtual Training Training { get; set; }
    }
}
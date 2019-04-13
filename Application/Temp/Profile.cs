using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class Profile
    {
        [Key]
        [Column(Order=1)]
        [ForeignKey("Player")]
        public  string PlayerId { get; set; }
        [Key]
        [Column(Order=2)]
        [ForeignKey("Skill")]
        public int SkillId { get; set; }
        public int Score { get; set; }
        public string Description { get; set; }
        
        public virtual Player Player { get; set; }
        public virtual Skill Skill { get; set; }
    }
    
    
}
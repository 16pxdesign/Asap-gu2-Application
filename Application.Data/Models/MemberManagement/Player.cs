using System.Collections.Generic;

namespace Application.Data.Models
{
    public class Player
    {
        //Primary
        public string SRU { get; set; }

        //Properties
        public PlayerPosition Position { get; set; }

        //Relations
        public virtual Member Member { get; set; }
        public virtual Senior Senior { get; set; }
        public virtual Junior Junior { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual List<HealthIssue> HealthIssues { get; set; }
        
    }
}
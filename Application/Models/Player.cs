namespace Application.Models
{
    public class Player : Member
    {
        public virtual PlayerPosition Position { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual HealthIssue HealthIssue { get; set; }
    }
}
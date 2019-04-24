namespace Application.Data.Models
{
    public class Skill
    {
        //Primary
        public int Id { get; set; }
        //Properties
        public string Name { get; set; }
        public SkillType Type { get; set; }
        public int? ParentId { get; set; }
        //Relations
        public virtual Skill Parent { get; set; }
    }
}
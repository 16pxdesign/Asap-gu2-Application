namespace Application.Repository.Models
{
    public class Skill
    {
        //Primary
        public int Id { get; set; }
        //Properties
        public string Name { get; set; }
        public bool Evaluable { get; set; }
        //Relations
        public virtual Skill Partent { get; set; }
    }
}
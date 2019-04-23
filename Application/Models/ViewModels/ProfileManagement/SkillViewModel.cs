namespace Application.Models
{
    public class SkillViewModel
    {
        public int Id { get; set; }
        //Properties
        public string Name { get; set; }
        public bool Evaluable { get; set; }
        public SkillViewModel Partent { get; set; }

    }
}
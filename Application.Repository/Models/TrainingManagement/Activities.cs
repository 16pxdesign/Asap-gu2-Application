namespace Application.Repository.Models
{
    public class Activities
    {
        //Primary
        public int Id { get; set; }

        //Properties
        public string Name { get; set; }

        //Relations
        public virtual Training Training { get; set; }
    }
}
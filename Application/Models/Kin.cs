namespace Application.Models
{
    public class Kin
    {
        //Primary
        public int Id { get; set; }
       
        //Properties
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Relationship { get; set; }
        //Relations
        public virtual Senior Senior { get; set; }
    }
}
namespace Application.Repository.Models
{
    public class Doctor
    {
        //Primary
        public int Id { get; set; }

        //Properties
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        
        //Relations
        public virtual Address Address { get; set; }
        public virtual Player Player { get; set; }
        
        }
}
namespace Application.Data.Models
{
    public class Kin
    {
        public string SeniorSRU { get; set; }
        public int AddressId { get; set; }

        //Primary
        public int Id { get; set; }
       
        //Properties
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Relationship { get; set; }
        //Relations
        public virtual Senior Senior { get; set; }
        public virtual Address Address { get; set; }
    }
}
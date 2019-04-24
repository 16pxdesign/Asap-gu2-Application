namespace Application.Models
{
    public class MemberShortViewModel
    {
        public string SRU { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fullname => string.Concat(Name, " ", Surname);

    }
}
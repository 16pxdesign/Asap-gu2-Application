namespace Application.Models
{
    public class Senior
    {
        //Primary
        public string SRU { get; set; }

        //Properties
        public string Kin { get; set; }

        //Relations
        public virtual Player Player { get; set; }
    }
}
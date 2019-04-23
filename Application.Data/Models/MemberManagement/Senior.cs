namespace Application.Data.Models
{
    public class Senior
    {
        //Primary
        public string SRU { get; set; }

        //Properties


        //Relations
        public virtual Player Player { get; set; }
        public virtual Kin Kin { get; set; }
        
    }
}
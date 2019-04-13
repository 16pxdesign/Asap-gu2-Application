namespace Application.Models
{
    public class Junior
    {
        //Primary
        public string SRU { get; set; }

        //Properties
        public string Gurad { get; set; }

        //Relations
        public virtual Player Player { get; set; }
    }
}
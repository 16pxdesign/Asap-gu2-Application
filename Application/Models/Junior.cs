namespace Application.Models
{
    public class Junior : Player
    {
        public virtual Guardian Guardian { get; set; }
        public virtual Guardian Guardian2 { get; set; }
    }
}
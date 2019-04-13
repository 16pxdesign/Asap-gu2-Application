namespace Application.Models
{
    public class Attendance
    {
        //Primary
        public int TrainingId { get; set; }
        public string PlayerSRU { get; set; }
        //Properties

        //Relations
        public virtual Training Training { get; set; }
        public virtual Player Player { get; set; }
    }
}
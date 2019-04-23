namespace Application.Data.Models
{
    public class Attendance
    {
        //Primary
        public string Id { get; set; }
        //Properties
        public int TrainingId { get; set; }
        public string PlayerSRU { get; set; }
        //Relations
        public virtual Training Training { get; set; }
        public virtual Player Player { get; set; }
    }
}
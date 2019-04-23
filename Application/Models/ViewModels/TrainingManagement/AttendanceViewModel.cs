namespace Application.Models
{
    public class AttendanceViewModel
    {
        public virtual TrainingViewModel Training { get; set; }
        public virtual PlayerViewModel Player { get; set; }
    }
}
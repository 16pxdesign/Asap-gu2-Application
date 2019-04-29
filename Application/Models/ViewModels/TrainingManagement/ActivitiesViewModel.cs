using System.ComponentModel.DataAnnotations;

namespace Application.Models
{
    public class ActivitiesViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
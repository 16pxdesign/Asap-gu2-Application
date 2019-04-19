using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Models
{
    public class HealthIssueViewModel
    {
        public HealthIssueViewModel()
        {
            Date = DateTime.Today;
        }

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}

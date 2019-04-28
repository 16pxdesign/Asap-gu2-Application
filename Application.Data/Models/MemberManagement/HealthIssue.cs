using System;
using System.ComponentModel.DataAnnotations;

namespace Application.Data.Models
{
    public class HealthIssue
    {
        //Primary
        public int Id { get; set; }
        //Properties
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string PlayerSRU { get; set; }

        //Relations
        public virtual Player Player { get; set; }

    }
}
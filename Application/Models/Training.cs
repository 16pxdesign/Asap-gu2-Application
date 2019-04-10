using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.CodeAnalysis;

namespace Application.Models
{
    public class Training
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public virtual Member Coach { get; set; }
        public DateTime _dateTime { get; set; }
        public string Location { get; set; }
        
    }
}
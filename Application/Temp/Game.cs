using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Models
{
    public class Game
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Opposition  { get; set; }
        public DateTime Date { get; set; }
        public DateTime KO { get; set; }
        public string Location { get; set; }
        public virtual GameHalf Half { get; set; }
        public virtual GameHalf Half2 { get; set; }
        
        //score
        //Result
        
    }
}
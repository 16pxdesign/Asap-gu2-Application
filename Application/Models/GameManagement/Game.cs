using System;
using System.Collections.Generic;

namespace Application.Models
{
    public class Game
    {
        //Primary
        public int Id { get; set; }

        //Properties
        public string Opposition { get; set; }
        public DateTime Date { get; set; }
        public DateTime KO { get; set; }
        public GameLocation Location { get; set; }
        public GameResult Result { get; set; }

        //Relations
        public virtual List<Scores> Scores { get; set; }
    }
}
using System;
using System.Collections.Generic;
using Application.Data.Models;

namespace Application.Models
{
    public class GameViewModel
    {
        public int Id { get; set; }

        //Properties
        public string Opposition { get; set; }
        public DateTime Date { get; set; }
        public DateTime KO { get; set; }
        public GameLocation Location { get; set; }
        public GameResult Result { get; set; }

        //Relations
        public List<Scores> Scores { get; set; }
    }
}
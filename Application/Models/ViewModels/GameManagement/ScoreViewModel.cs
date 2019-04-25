using System;
using Application.Data.Models;

namespace Application.Models
{
    public class ScoreViewModel
    {
        public int Id { get; set; }
        //Properties
        public GameHalf Half { get; set; }
        public DateTime Time { get; set; }
        public int Points { get; set; }
        public GameTeam Team { get; set; }
        public string Comment { get; set; }
    }
}
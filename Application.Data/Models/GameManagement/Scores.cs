using System;

namespace Application.Data.Models
{
    public class Scores
    {
        //Primary
        public int Id { get; set; }
        //Properties
        public GameHalf Half { get; set; }
        public DateTime Time { get; set; }
        public int Points { get; set; }
        public GameTeam Team { get; set; }
        public string Comment { get; set; }
        //Relations
        public virtual int GameId { get; set; }
        public virtual Game Game { get; set; }
    }
}
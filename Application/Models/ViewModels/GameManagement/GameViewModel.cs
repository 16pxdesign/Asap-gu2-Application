using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Application.Data.Models;

namespace Application.Models
{
    public class GameViewModel
    {
        
        public int Id { get; set; }

        //Properties
        public string Opposition { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public DateTime KO { get; set; }
        public GameLocation Location { get; set; }
        public GameResult Result { get; set; }

        //Relations
        public List<ScoreViewModel> Scores { get; set; }

        public int? OppositionPoints
        {
            get
            {
                var points = 0;
                if(Scores!= null && Scores.Any(x => x.Team == GameTeam.Opposition)) points = Scores.Where(x => x.Team == GameTeam.Opposition).Aggregate(points, (current, score) => current + score.Points);
                return points;
            }
        }
        
        public int? SimpleRugbyPoints
        {
            get
            {
                var points = 0;
                if(Scores!= null && Scores.Any(x => x.Team == GameTeam.SimpleRugby)) points = Scores.Where(x => x.Team == GameTeam.SimpleRugby).Aggregate(points, (current, score) => current + score.Points);

                return points;
            }
        }

    }
}
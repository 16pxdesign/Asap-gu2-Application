using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Application.Data.Models;

namespace Application.Models
{
    public class TrainingViewModel
    {
        public TrainingViewModel()
        {
            Date = DateTime.Now;
        }
        public int? Id { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public DateTime Time { get; set; }
        public string Location { get; set; }
        public string CoachSRU { get; set; }
        public MemberViewModel Coach { get; set; }
        public List<ActivitiesViewModel> Activities { get; set; }
        public string[] Attended { get; set; }
        public List<MemberViewModel> Attendance { get; set; }
    }
}
namespace Application.Models
{
    public class ProfileViewModel
    {
        public string PlayerSRU { get; set; }
        public int SkillId { get; set; }
        //Properties
        public string Description { get; set; }
        public int Score { get; set; }
        
        
        public  SkillViewModel Skill { get; set; }
        public  PlayerViewModel Player { get; set; }
    }
}
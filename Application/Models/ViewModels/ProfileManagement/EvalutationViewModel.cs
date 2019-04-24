using System.Collections.Generic;

namespace Application.Models
{
    public class EvalutationViewModel
    {
        public string id { get; set; }
        public MemberShortViewModel Player { get; set; }
        public List<SkillViewModel> Categories { get; set; }
        public List<SkillViewModel> Skills { get; set; }
        public List<ProfileViewModel> Scores { get; set; }
    }
}
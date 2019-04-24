using System.Collections.Generic;
using System.ComponentModel;
using Application.Data.Models;

namespace Application.Models
{
    public class SkillViewModel
    {
        public int Id { get; set; }
        //Properties
        public string Name { get; set; }
        [DisplayName("Type")]
        public SkillType Type { get; set; }
        [DisplayName("Category")]
        public int? ParentId { get; set; }
        public SkillViewModel Parent { get; set; }
        public List<SkillViewModel> Categories { get; set; }

    }
}
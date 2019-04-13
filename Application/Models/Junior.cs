using System.Collections.Generic;

namespace Application.Models
{
    public class Junior
    {
        //Primary
        public string SRU { get; set; }

        //Properties


        //Relations
        public virtual Player Player { get; set; }
        public virtual List<Guardian> Guardians { get; set; }
    }
}
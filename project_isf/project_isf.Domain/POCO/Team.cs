using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_isf.Domain.POCO
{
    public class Team
    {
        public int TeamId { get; set; }
        public int CategoryId { get; set; }
        public int CoachId { get; set; }
        public int SchoolId { get; set; }
        public string TeamNaam { get; set; }
        public Boolean Category { get; set; }
        public string ImageUrl { get; set; }

        public virtual Coach Coach { get; set; }
        public virtual School School { get; set; }
        public List<Student> Students { get; set; }

    }
}

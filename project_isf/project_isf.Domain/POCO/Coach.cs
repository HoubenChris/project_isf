using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_isf.Domain.POCO
{
  class Coach
  {
    public int CoachId { get; set; }
    public string Name { get; set; }
    public string FirstName { get; set; }
    public int LocationId { get; set; }
    public string Adress { get; set; }

    public virtual Location Location { get; set; }
  }
}

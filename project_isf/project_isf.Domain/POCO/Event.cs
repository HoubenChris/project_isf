using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_isf.Domain.POCO
{
  public class Event
  {
    public int EventId { get; set; }
    public string Name { get; set; }
    public Boolean Category { get; set; } // TO DO: enum van maken
    public string Description { get; set; }
    public string RecordHolder { get; set; }

  }
}

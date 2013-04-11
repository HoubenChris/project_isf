using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_isf.Domain.POCO
{
  public class ISFEvent
  {
    public int ISFEventId { get; set; }
    public string Name { get; set; }
    public Boolean Category { get; set; } // TO DO: enum van maken
    public Boolean TimeOrDistance { get; set; }
    public Boolean SchoolCupEvent { get; set; }
    public DateTime TimeMinimum { get; set; }
    public DateTime TimeMaximum { get; set; }
    public int DistanceMinimum { get; set; }
    public int DistanceMaximum { get; set; }
    public string Description { get; set; }
    public string RecordHolder { get; set; }

  }
}

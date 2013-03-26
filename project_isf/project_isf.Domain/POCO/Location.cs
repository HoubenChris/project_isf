using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_isf.Domain.POCO
{
  public class Location
  {
    public int LocationId { get; set; }
    public string Continent { get; set; }
    public string Country { get; set; }
    public string Region { get; set; }
  }
}

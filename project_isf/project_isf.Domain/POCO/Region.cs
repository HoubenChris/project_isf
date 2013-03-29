using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_isf.Domain.POCO
{
  public class Region
  {
    public int RegionId { get; set; }
    public string Name { get; set; }
    public virtual Country LandId { get; set; }
  }
}

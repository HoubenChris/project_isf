using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_isf.Domain.POCO
{
  public class AdvertisementLocation
  {
    public int AdvertisementLocationId { get; set; }
    public int LocationId { get; set; }
    public int AdvertisementId { get; set; }

    public virtual Location Location { get; set; }
    public virtual Advertisement Advertisement { get; set; }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_isf.Domain.POCO
{
  public class Advertisement
  {
    public int AdvertisementId { get; set; }
    public string Company { get; set; }
    public int AdvertisementLocationId { get; set; }

    public virtual AdvertisementLocation AdvertisementLocation { get; set; }
  }
}

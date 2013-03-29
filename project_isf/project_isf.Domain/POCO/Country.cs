using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_isf.Domain.POCO
{
  public class Country
  {
    public int CountryId { get; set; }
    public string Name { get; set; }
    public virtual Continent ContinentId { get; set; }

  }
}

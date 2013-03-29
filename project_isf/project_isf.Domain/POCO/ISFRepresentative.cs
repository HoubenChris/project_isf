using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace project_isf.Domain.POCO
{
  public class ISFRepresentative
  {
    public int ISFRepresentativeId { get; set; }
    public string Name { get; set; }
    public string FirstName { get; set; }
    public string Address { get; set; }
    public int RegionId { get; set; }

    public virtual Region Region { get; set; }
  }
}

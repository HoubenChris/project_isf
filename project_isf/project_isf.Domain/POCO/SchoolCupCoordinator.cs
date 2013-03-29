using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_isf.Domain.POCO
{
  public class SchoolCupCoordinator
  {
    public int SchoolCupCoordinatorId { get; set; }
    public string Name { get; set; }
    public string FirstName { get; set; }
    public string Adress { get; set; }
    public int RegionId { get; set; }
    public int SchoolId { get; set; }

    public virtual Region Region { get; set; }
    public virtual School School { get; set; }

  }
}

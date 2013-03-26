using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_isf.Domain.POCO
{
  class ISFRepresentative
  {
    public int RepresentativeId { get; set; }
    public String Name { get; set; }
    public String FirstName { get; set; }
    public String Adress { get; set; }
    public String LocationId { get; set; }

    public virtual Location Location { get; set; }
  }
}

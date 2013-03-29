using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace project_isf.Domain.POCO
{
  public class NSFRepresentative
  {
    
    public int NSFRepresentativeId { get; set; }
    public string Name { get; set; }
    public string FirstName { get; set; }
    public string Adress { get; set; }
    public int RegionId { get; set; }

    public virtual Region Region { get; set; }
  }
}

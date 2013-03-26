using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_isf.Domain.POCO
{
  public class Student
  {
    public int StudentId { get; set; }
    public int TeamId { get; set; }
    public string Name { get; set; }
    public string FirstName { get; set; }
    public string Adress { get; set; }
    public DateTime DateOfBirth { get; set; }
    public int LocationId { get; set; }

    public virtual Team Team { get; set; }
    public virtual Location Location { get; set; }
  }
}

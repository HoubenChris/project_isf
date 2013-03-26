using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_isf.Domain.POCO
{
  public class Enrollment
  {
    public int EnrollmentId { get; set; }
    public int MeetingId { get; set; }
    public int TeamId { get; set; }

    public virtual Meeting Meeting { get; set; }
    public virtual Team Team { get; set; }

  }
}

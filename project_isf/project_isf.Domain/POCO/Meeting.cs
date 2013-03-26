using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_isf.Domain.POCO
{
  public class Meeting
  {
    public int MeetingId { get; set; }
    public int MeetingEventId { get; set; }
    public int EnrollmentId { get; set; }
    public int RepresentativeId { get; set; }
    public string StartTime { get; set; }
    public string EndTime { get; set; }
    public string Date { get; set; }
    public string Adress { get; set; }

    public virtual MeetingEvent MeetingEvent { get; set; }
    public virtual Enrollment Enrollment { get; set; }
    public virtual NSFRepresentative NSFRepresentative { get; set; }

  }
}

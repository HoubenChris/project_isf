using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_isf.Domain.POCO
{
  public class MeetingEvent
  {
    public int MeetingEventId { get; set; }
    public int EventId { get; set; }
    public int MeetingId { get; set; }

    public virtual ISFEvent Event { get; set; }
    public virtual Meeting Meeting { get; set; }
  }
}

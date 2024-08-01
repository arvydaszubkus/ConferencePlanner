using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Data
{
    public class SessionAttendee
    {
     public int SessionId { get; set; }
 
     public Session Session { get; set; } = null!;
 
     public int AttendeeId { get; set; }
 
     public Attendee Attendee { get; set; } = null!;
    }
}
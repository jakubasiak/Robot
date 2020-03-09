using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.ActivityLogger
{
    public abstract class InputEvent
    {
        public EventType EventType { get; set; }
        public long EventTimeInTicks { get; set; }
    }
}

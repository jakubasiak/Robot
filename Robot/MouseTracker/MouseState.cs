using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.MouseTracker
{
    public class MouseState
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public bool LeftButtonDown { get; set; }
        public bool RightButtonDown { get; set; }
        public bool MiddleButtonDown { get; set; }
        public long EventTimeInTicks { get; set; }

        public override string ToString()
        {
            return
                $"X: {this.PositionX}, Y: {this.PositionY}, LeftButton: {this.LeftButtonDown}, MiddleButton: {this.MiddleButtonDown}, RightButton: {this.RightButtonDown}, Time: {this.EventTimeInTicks}";
        }
    }
}

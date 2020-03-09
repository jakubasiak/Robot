using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robot.Keyboard;

namespace Robot.ActivityLogger
{
    public class KeyboardEvent: InputEvent
    {
        public Keys Key { get; set; }
        public bool IsShift { get; set; }
        public bool IsAlt { get; set; }
        public bool IsCtrl { get; set; }

        public override string ToString()
        {
            return $"Key: {this.Key}, IsShift: {this.IsShift}, IsAlt: {this.IsAlt}, IsCtrl: {IsCtrl}, Time: {this.EventTimeInTicks}";
        }
    }
}

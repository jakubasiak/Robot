using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robot.Keyboard;

namespace Robot.KeyboardTracker
{
    public class KeyboardState
    {
        public Keys Key { get; set; }
        public bool IsShift { get; set; }
        public bool IsAlt { get; set; }
        public bool IsCtrl { get; set; }
        public bool IsWin { get; set; }
        public long EventTimeInTicks { get; set; }

        public override string ToString()
        {
            return $"Key: {this.Key}, IsShift: {this.IsShift}, IsAlt: {this.IsAlt}, IsCtrl: {this.IsCtrl}, IsWin: {this.IsWin} Time: {this.EventTimeInTicks}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Keyboard
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int c = 0; c <= 10; c++)
            //{
            //    Keyboard.WriteText("${!@^Dziwne Znaki} & ĄżŹĆ");
            //}
            var keyboardTracker = new KeyboardTracker.KeyboardTracker();
            keyboardTracker.Track();
        }
    }
}


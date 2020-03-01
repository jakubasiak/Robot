using Robot.Keyboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Robot.ActivityLogger
{
    public class ActivityLogger
    {
        public void TrackActivities()
        {
            var track = true;
            bool shift = false;
            bool alt = false;
            while (track)
            {
                Thread.Sleep(5);
                for (int i = 0; i < 255; i++)
                {
                    int key = WinApi.GetAsyncKeyState(i);
                    if (key == -32767)
                    {
                        shift = WinApi.GetAsyncKeyState(16) < 0;
                        alt = WinApi.GetAsyncKeyState(18) < 0;
                        var virtualKey = (Keys)i;
                        var c = Keyboard.Keyboard.GetCharacter(virtualKey, shift, alt);
                        Console.Write(c);
                        //Console.WriteLine(i);

                    }
                }
            }

        }
    }
}

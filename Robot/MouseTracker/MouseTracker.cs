using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Robot.Keyboard;

namespace Robot.MouseTracker
{
    public class MouseTracker
    {
        public void Track()
        {
            var track = true;
            WinApi.POINT previousPoint = new WinApi.POINT(0,0);
            while (track)
            {
                Thread.Sleep(2);
                WinApi.POINT point;
                WinApi.GetCursorPos(out point);

                if (previousPoint.X != point.X || previousPoint.Y != point.Y)
                {
                    Console.WriteLine($"{point.X} - {point.Y}");
                    previousPoint = point;
                }

                for (int i = 0; i < 4; i++)
                {
                    int key = WinApi.GetAsyncKeyState(i);
                    if (key == -32767)
                    {
                        var lmb = WinApi.GetAsyncKeyState(1);
                        var rmb = WinApi.GetAsyncKeyState(2);
                        var mmb = WinApi.GetAsyncKeyState(4);

                        if (lmb < 0)
                        {
                            Console.WriteLine("Left Mouse Button");
                        }
                        if (rmb < 0)
                        {
                            Console.WriteLine("Right Mouse Button");
                        }
                        if (mmb < 0)
                        {
                            Console.WriteLine("Middle Mouse Button");
                        }
                    }
                }

            }
        }
    }
}

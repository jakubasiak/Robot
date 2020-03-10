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
        public bool IsTracking { get; set; }

        public void Track()
        {
            this.IsTracking = true;
            var previousState = new MouseState();
            while (this.IsTracking)
            {
                Thread.Sleep(2);
                var mouseState = this.GetMouseState();
                if (mouseState != null && this.StateChanged(previousState, mouseState))
                {
                    IntPtr hWnd = WinApi.WindowFromPoint(new WinApi.POINT(mouseState.PositionX, mouseState.PositionY));
                    if (hWnd != IntPtr.Zero) WinApi.SetWindowText(hWnd, "Window Found");


                    previousState = mouseState;
                    Console.WriteLine(mouseState.ToString());
                }
            }
        }

        public void StropTracking()
        {
            this.IsTracking = false;
        }

        public MouseState GetMouseState()
        {
            var mouseState = new MouseState();

            WinApi.GetCursorPos(out var point);
            mouseState.PositionX = point.X;
            mouseState.PositionY = point.Y;

            var lmb = WinApi.GetAsyncKeyState(1);
            var rmb = WinApi.GetAsyncKeyState(2);
            var mmb = WinApi.GetAsyncKeyState(4);

            if (lmb < 0)
            {
                mouseState.LeftButtonDown = true;
            }
            if (rmb < 0)
            {
                mouseState.RightButtonDown = true;
            }
            if (mmb < 0)
            {
                mouseState.MiddleButtonDown = true;
            }


            mouseState.EventTimeInTicks = DateTime.Now.Ticks;
            return mouseState;
        }

        public bool StateChanged(MouseState previous, MouseState current)
        {
            return previous.PositionX != current.PositionX ||
                   previous.PositionY != current.PositionY;
        }
    }
}

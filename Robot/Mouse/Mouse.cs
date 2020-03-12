using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using WindowsInput;
using Robot.ActivityLogger;

namespace Robot.Mouse
{
    public static class Mouse
    {
        public static int Delay { get; set; } = 15;
        public static InputSimulator InputSimulator { get; set; } = new InputSimulator();

        public static void SetPosition(WinApi.POINT point)
        {
            Thread.Sleep(Delay);
            WinApi.SetCursorPos(point.X, point.Y);
        }


        public static void SetPosition(int mouseEventPositionX, int mouseEventPositionY)
        {
            var point = new WinApi.POINT(mouseEventPositionX, mouseEventPositionY);
            Thread.Sleep(Delay);
            WinApi.SetCursorPos(point.X, point.Y);
        }

        public static void MouseEvent(MouseButtons button, EventType type = EventType.Click)
        { 

            if (type == EventType.Click)
            {
                switch (button)
                {
                    case MouseButtons.Left:
                        InputSimulator.Mouse.LeftButtonClick();
                        break;
                    case MouseButtons.Middle:
                        InputSimulator.Mouse.MiddleButtonClick();
                        break;
                    case MouseButtons.Right:
                        InputSimulator.Mouse.RightButtonClick();
                        break;
                }

            }
            if (type == EventType.Down)
            {
                switch (button)
                {
                    case MouseButtons.Left:
                        InputSimulator.Mouse.LeftButtonDown();
                        break;
                    case MouseButtons.Middle:
                        InputSimulator.Mouse.MiddleButtonDown();
                        break;
                    case MouseButtons.Right:
                        InputSimulator.Mouse.RightButtonDown();
                        break;
                }
            }
            if (type == EventType.Up)
            {
                switch (button)
                {
                    case MouseButtons.Left:
                        InputSimulator.Mouse.LeftButtonUp();
                        break;
                    case MouseButtons.Middle:
                        InputSimulator.Mouse.MiddleButtonUp();
                        break;
                    case MouseButtons.Right:
                        InputSimulator.Mouse.RightButtonUp();
                        break;
                }
            }
        }
    }
}


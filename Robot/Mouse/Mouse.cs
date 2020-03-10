using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;
using Robot.ActivityLogger;

namespace Robot.Mouse
{
    public static class Mouse
    {
        public static int Delay { get; set; } = 15;

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

        public static void MouseEvent(MouseButtons button, EventType type = EventType.Click, bool doubleClick = false)
        {

            WinApi.MouseEventFlag flagUp = new WinApi.MouseEventFlag();
            WinApi.MouseEventFlag flagDown = new WinApi.MouseEventFlag();

            switch (button)
            {
                case MouseButtons.Left:
                    flagUp = WinApi.MouseEventFlag.LeftUp;
                    flagDown = WinApi.MouseEventFlag.LeftDown;
                    break;
                case MouseButtons.Middle:
                    flagUp = WinApi.MouseEventFlag.MiddleUp;
                    flagDown = WinApi.MouseEventFlag.MiddleDown;
                    break;
                case MouseButtons.Right:
                    flagUp = WinApi.MouseEventFlag.RightUp;
                    flagDown = WinApi.MouseEventFlag.RightDown;
                    break;
                default://defaul left button
                    flagUp = WinApi.MouseEventFlag.LeftUp;
                    flagDown = WinApi.MouseEventFlag.LeftDown;
                    break;
            }

            if (type == EventType.Click)
            {
                int count = doubleClick == false ? 1 : 2;//check
                for (int i = 0; i < count; i++)
                {
                    WinApi.mouse_event(flagDown, 0, 0, 0, 0);
                    WinApi.mouse_event(flagUp, 0, 0, 0, 0);
                }
            }
            else
            {
                if (type == EventType.Down)
                    WinApi.mouse_event(flagDown, 0, 0, 0, 0);
                else if (type == EventType.Up)
                    WinApi.mouse_event(flagUp, 0, 0, 0, 0);
            }
        }
    }

}

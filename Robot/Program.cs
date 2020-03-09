using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robot.Mouse;

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

            var mouseTracker = new MouseTracker.MouseTracker();
            mouseTracker.Track();

            //Mouse.Mouse.SetPosition(new WinApi.POINT(250, 250));
            //Mouse.Mouse.MouseEvent(MouseButtons.Left, EventType.Down);
            //for (int i = 1; i < 500; i++)
            //{
            //    Mouse.Mouse.SetPosition(new WinApi.POINT(i, i));
            //}
            //Mouse.Mouse.SetPosition(new WinApi.POINT(501, 501));
            //Mouse.Mouse.MouseEvent(MouseButtons.Left, EventType.Up);
        }
    }
}


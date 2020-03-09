using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Robot.ActivityLogger;
using Robot.Keyboard;
using Robot.Mouse;
using EventType = Robot.ActivityLogger.EventType;

namespace Robot.ActivityRobot
{
    public class ActivityRobot
    {
        public List<InputEvent> InputEvents { get; set; } = new List<InputEvent>();

        public void RunFromEvents()
        {
            long previousEventTimeInTicks = -1;
            foreach (var inputEvent in this.InputEvents)
            {
                if (inputEvent.EventType == EventType.Mouse)
                {
                    var mouseEvent = (MouseEvent) inputEvent;
                    if (previousEventTimeInTicks > 0)
                    {
                        Mouse.Mouse.Delay = TimeSpan.FromTicks(mouseEvent.EventTimeInTicks - previousEventTimeInTicks).Milliseconds;
                    }

                    Mouse.Mouse.SetPosition(mouseEvent.PositionX, mouseEvent.PositionY);
                    if (mouseEvent.LeftButtonDown)
                    {
                        Mouse.Mouse.MouseEvent(MouseButtons.Left);
                    }
                    if (mouseEvent.MiddleButtonDown)
                    {
                        Mouse.Mouse.MouseEvent(MouseButtons.Left);
                    }
                    if (mouseEvent.RightButtonDown)
                    {
                        Mouse.Mouse.MouseEvent(MouseButtons.Left);
                    }

                    previousEventTimeInTicks = mouseEvent.EventTimeInTicks;

                    Console.WriteLine(mouseEvent.ToString());
                }
                if (inputEvent.EventType == EventType.Keyboard)
                {
                    var keyboardEvent = (KeyboardEvent)inputEvent;
                    if (previousEventTimeInTicks > 0)
                    {
                        Keyboard.Keyboard.Delay = TimeSpan.FromTicks(keyboardEvent.EventTimeInTicks - previousEventTimeInTicks).Milliseconds;
                        Console.WriteLine(Keyboard.Keyboard.Delay);
                    }

                    if (keyboardEvent.IsShift)
                    {
                        Keyboard.Keyboard.KeyDown(Keys.Shift);
                    }

                    if (keyboardEvent.IsCtrl)
                    {
                        Keyboard.Keyboard.KeyDown(Keys.Control);
                    }

                    if (keyboardEvent.IsAlt)
                    {
                        Keyboard.Keyboard.KeyDown(Keys.Menu);
                    }

                    if (keyboardEvent.IsWin)
                    {
                        Keyboard.Keyboard.KeyDown(Keys.LeftWindows);
                    }

                    Keyboard.Keyboard.KeyDown(keyboardEvent.Key);
                    Keyboard.Keyboard.KeyUp(keyboardEvent.Key);

                    if (keyboardEvent.IsShift)
                    {
                        Keyboard.Keyboard.KeyUp(Keys.Shift);
                    }

                    if (keyboardEvent.IsCtrl)
                    {
                        Keyboard.Keyboard.KeyUp(Keys.Control);
                    }

                    if (keyboardEvent.IsAlt)
                    {
                        Keyboard.Keyboard.KeyUp(Keys.Menu);
                    }

                    if (keyboardEvent.IsWin)
                    {
                        Keyboard.Keyboard.KeyUp(Keys.LeftWindows);
                    }

                    previousEventTimeInTicks = keyboardEvent.EventTimeInTicks;

                    Console.WriteLine(keyboardEvent.ToString());
                }
            }
        }

        public void LoadEvents(string loadingPath)
        {
            JsonConverter[] converters = { new EventConverter() };
            this.InputEvents = JsonConvert.DeserializeObject<List<InputEvent>>(File.ReadAllText(loadingPath), converters);

        }
    }
}

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
using Robot.MouseTracker;
using EventType = Robot.ActivityLogger.EventType;

namespace Robot.ActivityRobot
{
    public class ActivityRobot
    {
        public List<InputEvent> InputEvents { get; set; } = new List<InputEvent>();

        public void RunFromEvents()
        {
            long previousEventTimeInTicks = -1;

            for (int i = 0; i < this.InputEvents.Count; i++)
            {
                if (this.InputEvents[i].EventType == EventType.Mouse)
                {
                    var mouseEvent = (MouseEvent)this.InputEvents[i];
                    var previousEvent = i > 0 ? this.GetMouseEvent(this.InputEvents[i - 1]) : null;
                    var nextEvent = i < this.InputEvents.Count - 1 ? this.GetMouseEvent(this.InputEvents[i + 1]) : null;
                    if (previousEventTimeInTicks > 0)
                    {
                        Mouse.Mouse.Delay = TimeSpan.FromTicks(mouseEvent.EventTimeInTicks - previousEventTimeInTicks).Milliseconds;
                    }

                    Mouse.Mouse.SetPosition(mouseEvent.PositionX, mouseEvent.PositionY);
                    this.PerformMouseEvent(previousEvent, mouseEvent, nextEvent);

                    previousEventTimeInTicks = mouseEvent.EventTimeInTicks;

                    Console.WriteLine(mouseEvent.ToString());
                }
                if (this.InputEvents[i].EventType == EventType.Keyboard)
                {
                    var keyboardEvent = (KeyboardEvent)this.InputEvents[i];
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

        private MouseEvent GetMouseEvent(InputEvent inputEvent)
        {
            if (inputEvent.EventType != EventType.Mouse)
            {
                return null;
            }
            else
            {
                return (MouseEvent) inputEvent;
            }
        }

        private void PerformMouseEvent(MouseEvent previous, MouseEvent current, MouseEvent next)
        {

            if (current.LeftButtonDown)
            {
                if (previous == null && next == null)
                {
                    Mouse.Mouse.MouseEvent(MouseButtons.Left);
                }

                if (previous == null && next != null && next.LeftButtonDown)
                {
                    Mouse.Mouse.MouseEvent(MouseButtons.Left, Mouse.EventType.Down);
                }

                if (previous != null && previous.LeftButtonDown && next != null && next.LeftButtonDown)
                {
                    Mouse.Mouse.MouseEvent(MouseButtons.Left, Mouse.EventType.Down);
                }

                if (previous != null && previous.LeftButtonDown && next == null)
                {
                    Mouse.Mouse.MouseEvent(MouseButtons.Left, Mouse.EventType.Down);
                    Mouse.Mouse.MouseEvent(MouseButtons.Left, Mouse.EventType.Up);
                }
            }
            else
            {
                Mouse.Mouse.MouseEvent(MouseButtons.Left, Mouse.EventType.Up);
            }

            if (current.MiddleButtonDown)
            {
                if (previous == null && next == null)
                {
                    Mouse.Mouse.MouseEvent(MouseButtons.Middle);
                }

                if (previous == null && next != null && next.MiddleButtonDown)
                {
                    Mouse.Mouse.MouseEvent(MouseButtons.Middle, Mouse.EventType.Down);
                }

                if (previous != null && previous.MiddleButtonDown && next != null && next.MiddleButtonDown)
                {
                    Mouse.Mouse.MouseEvent(MouseButtons.Middle, Mouse.EventType.Down);
                }

                if (previous != null && previous.MiddleButtonDown && next == null)
                {
                    Mouse.Mouse.MouseEvent(MouseButtons.Middle, Mouse.EventType.Down);
                    Mouse.Mouse.MouseEvent(MouseButtons.Middle, Mouse.EventType.Up);
                }
            }
            else
            {
                Mouse.Mouse.MouseEvent(MouseButtons.Middle, Mouse.EventType.Up);
            }

            if (current.RightButtonDown)
            {
                if (previous == null && next == null)
                {
                    Mouse.Mouse.MouseEvent(MouseButtons.Right);
                }

                if (previous == null && next != null && next.RightButtonDown)
                {
                    Mouse.Mouse.MouseEvent(MouseButtons.Right, Mouse.EventType.Down);
                }

                if (previous != null && previous.RightButtonDown && next != null && next.RightButtonDown)
                {
                    Mouse.Mouse.MouseEvent(MouseButtons.Right, Mouse.EventType.Down);
                }

                if (previous != null && previous.RightButtonDown && next == null)
                {
                    Mouse.Mouse.MouseEvent(MouseButtons.Right, Mouse.EventType.Down);
                    Mouse.Mouse.MouseEvent(MouseButtons.Right, Mouse.EventType.Up);
                }
            }
            //else
            //{
            //    Mouse.Mouse.MouseEvent(MouseButtons.Right, Mouse.EventType.Up);
            //}

        }

        public void LoadEvents(string loadingPath)
        {
            JsonConverter[] converters = { new EventConverter() };
            this.InputEvents = JsonConvert.DeserializeObject<List<InputEvent>>(File.ReadAllText(loadingPath), converters);

        }
    }
}

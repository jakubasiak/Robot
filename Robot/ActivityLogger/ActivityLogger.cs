using Robot.Keyboard;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Robot.KeyboardTracker;
using Robot.MouseTracker;

namespace Robot.ActivityLogger
{
    public class ActivityLogger
    {
        public string SavePath { get; set; }
        public bool IsTracking { get; set; }
        public KeyboardTracker.KeyboardTracker KeyboardTracker { get; set; } = new KeyboardTracker.KeyboardTracker();
        public MouseTracker.MouseTracker MouseTracker { get; set; } = new MouseTracker.MouseTracker();
        public List<InputEvent> InputEvents { get; set; } = new List<InputEvent>();

        public ActivityLogger(string savePath)
        {
            this.SavePath = savePath;
        }

        public void Track()
        {
            this.IsTracking = true;
            var previousMouseState = new MouseState();
            while (this.IsTracking)
            {
                Thread.Sleep(2);

                var mouseState = this.MouseTracker.GetMouseState();
                var keyboardState = this.KeyboardTracker.GetKeyboardState();

                if (mouseState != null && this.MouseTracker.StateChanged(previousMouseState, mouseState))
                {
                    previousMouseState = mouseState;
                    var mouseEvent = new MouseEvent()
                    {
                        PositionX = mouseState.PositionX,
                        PositionY = mouseState.PositionY,
                        LeftButtonDown = mouseState.LeftButtonDown,
                        MiddleButtonDown = mouseState.MiddleButtonDown,
                        RightButtonDown = mouseState.RightButtonDown,
                        EventTimeInTicks = mouseState.EventTimeInTicks,
                        EventType = EventType.Mouse
                    };
                    this.InputEvents.Add(mouseEvent);
                    Console.WriteLine(mouseEvent.ToString());
                }

                if (keyboardState != null)
                {
                    var keyboardEvent = new KeyboardEvent()
                    {
                        Key = keyboardState.Key,
                        IsShift = keyboardState.IsShift,
                        IsCtrl = keyboardState.IsCtrl,
                        IsAlt = keyboardState.IsAlt,
                        EventTimeInTicks = keyboardState.EventTimeInTicks,
                        EventType = EventType.Keyboard
                    };
                    this.InputEvents.Add(keyboardEvent);
                    Console.WriteLine(keyboardEvent.ToString());
                }
            }
        }

        public void StopTracking()
        {
            this.IsTracking = false;
            this.Save();
        }

        private void Save()
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(this.SavePath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, this.InputEvents);
            }
        }
    }
}

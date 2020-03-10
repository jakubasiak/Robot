using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Robot.ActivityLogger;

namespace Robot.ActivityRobot
{
    public class EventConverter: JsonConverter
    {

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            JObject jo = JObject.Load(reader);
            if (jo["EventType"].Value<int>() == 0)
                return jo.ToObject<MouseEvent>(serializer);

            if (jo["EventType"].Value<int>() == 1)
                return jo.ToObject<KeyboardEvent>(serializer);

            return null;

        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(InputEvent);
        }
    }
}

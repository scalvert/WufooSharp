using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WufooSharp
{
    public class MySqlDateTimeConverter: DateTimeConverterBase
    {
        public const string MySqlNullDateTime = "0000-00-00 00:00:00";

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(((DateTime)value).ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK"));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (this.CanConvert(objectType))
            {
                if (reader.TokenType.Equals(JsonToken.String))
                {
                    if (reader.Value.Equals(MySqlNullDateTime))
                    {
                        return DateTime.MinValue;
                    }

                    return DateTime.Parse(existingValue.ToString());
                }
            }

            return DateTime.MinValue;
        }
    }
}
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WebinarMasterDetailDemo.Common
{
    public class JsonNumberToDateConverter : JsonConverter<object>
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return true;
        }
        public override object? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Number)
            {
                var value = reader.GetDouble();
                var date = DateTime.FromOADate(value);
                return date;
            }
            else
            {
                return null;
            }
        }

        public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}

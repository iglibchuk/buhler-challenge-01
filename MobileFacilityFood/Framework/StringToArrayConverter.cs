using Newtonsoft.Json;

namespace MobileFacilityFood.Framework;

public class StringToArrayConverter : JsonConverter
{
    private const string FoodDelimiter = ":";

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        throw new NotImplementedException("Not implemented yet");
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        return reader.TokenType switch
        {
            JsonToken.Null => string.Empty,
            JsonToken.String => (reader.Value as string)?.ToLowerInvariant().Split(FoodDelimiter, StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries) ?? [],
            _ => serializer.Deserialize(reader, objectType)!
        };
    }

    public override bool CanWrite => false;

    public override bool CanConvert(Type objectType)
    {
        return false;
    }
}

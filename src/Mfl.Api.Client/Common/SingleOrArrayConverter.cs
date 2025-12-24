using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Mfl.Api.Common;

/// <summary>
/// Converts between a single JSON object and a JSON array of objects for properties of type List<T> during
/// serialization and deserialization.
/// </summary>
/// <remarks>This converter allows a property of type List<T> to accept either a single object or an array of
/// objects in JSON. When deserializing, if the JSON token is a single object, it is wrapped in a list; if it is an
/// array, it is deserialized as a list. When serializing, the value is always written as a JSON array. This is useful
/// for APIs that may return either a single item or an array for the same property.</remarks>
/// <typeparam name="T">The type of elements in the list to convert.</typeparam>
public class SingleOrArrayConverter<T> : JsonConverter<List<T>>
{
    public override List<T>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Null)
        {
            return null;
        }

        if (reader.TokenType == JsonTokenType.StartObject)
        {
            // Single object case: deserialize as T and wrap in list
            T? item = JsonSerializer.Deserialize<T>(ref reader, options);
            return item is null ? [] : [item];
        }

        if (reader.TokenType == JsonTokenType.StartArray)
        {
            // Array case: deserialize directly into List<T>
            var list = JsonSerializer.Deserialize<List<T>>(ref reader, options);
            return list ?? [];
        }

        // Fallback for unexpected tokens (e.g., string, number, true/false)
        throw new JsonException(
            $"Unexpected token parsing List<{typeof(T).Name}>. Expected StartObject or StartArray, but got {reader.TokenType}.");
    }

    public override void Write(Utf8JsonWriter writer, List<T> value, JsonSerializerOptions options)
    {
        // Always serialize as an array for consistency (MFL expects arrays on input anyway)
        if (value is null)
        {
            writer.WriteNullValue();
        }
        else
        {
            JsonSerializer.Serialize(writer, value, options);
        }
    }

    // Optional: Improve performance by allowing this converter on nullable contexts
    public override bool CanConvert(Type typeToConvert)
    {
        return typeof(List<T>).IsAssignableFrom(typeToConvert);
    }
}
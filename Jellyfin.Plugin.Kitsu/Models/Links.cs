using System.Text.Json.Serialization;

namespace Jellyfin.Plugin.Kitsu.Models;

public record Links(
    [property: JsonPropertyName("self")] string Self,
    [property: JsonPropertyName("related")] string Related,
    [property: JsonPropertyName("first")] string First,
    [property: JsonPropertyName("next")] string Next,
    [property: JsonPropertyName("last")] string Last
    );

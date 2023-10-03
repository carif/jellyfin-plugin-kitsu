using System.Text.Json.Serialization;

namespace Jellyfin.Plugin.Kitsu.Models;

public record Titles(
    [property: JsonPropertyName("en")] string English,
    [property: JsonPropertyName("en_jp")] string Romaji,
    [property: JsonPropertyName("ja_jp")] string Japanese
    );

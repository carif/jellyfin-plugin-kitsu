using System.Text.Json.Serialization;

namespace Jellyfin.Plugin.Kitsu.Models;

public record Relationships(
    [property: JsonPropertyName("links")] Links Links
    );

using System.Text.Json.Serialization;

namespace Jellyfin.Plugin.Kitsu.Models;

public record KitsuIoResponse(
    [property: JsonPropertyName("data")] KitsuData Data
    );


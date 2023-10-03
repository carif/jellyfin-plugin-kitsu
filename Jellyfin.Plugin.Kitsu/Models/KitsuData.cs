using System.Text.Json.Serialization;

namespace Jellyfin.Plugin.Kitsu.Models;

public record KitsuData(
    [property: JsonPropertyName("type")] string Type,
    [property: JsonPropertyName("subtype")] Subtype Subtype,
    [property: JsonPropertyName("id")]
    [property: JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    int Id,
    [property: JsonPropertyName("attributes")] Attributes Attributes,
    [property: JsonPropertyName("relationships")] Relationships Relationships,
    [property: JsonPropertyName("ageRating")] AgeRating AgeRating,
    [property: JsonPropertyName("ageRatingGuide")] string AgeRatingGuide
    );

public enum AgeRating
{
    G,
    Pg,
    R,
    R18
}

public enum Subtype
{
    Ona,
    Ova,
    Tv,
    Movie,
    Music,
    Special
}

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Jellyfin.Plugin.Kitsu.Models;

public record Attributes(
    [property: JsonPropertyName("slug")] string Slug,
    [property: JsonPropertyName("titles")] Titles Titles,
    [property: JsonPropertyName("canonicalTitle")] string CanonicalTitle,
    [property: JsonPropertyName("abbreviatedTitles")] List<string> AbbreviatedTitles,
    [property: JsonPropertyName("episodeCount")] int? EpisodeCount
    );

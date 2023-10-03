using System;

namespace Jellyfin.Plugin.Kitsu.ApiClient.Models
{
    public class KitsuEpisodeAttributes
    {
        public string Synopsis { get; set; }
        public KitsuTitles Titles { get; set; }
        public int? Number { get; set; }
        public int? SeasonNumber { get; set; }
        public DateTime? AirDate { get; set; }
        public int? Length { get; set; }
        public KitsuImage Thumbnail { get; set; }
    }
}

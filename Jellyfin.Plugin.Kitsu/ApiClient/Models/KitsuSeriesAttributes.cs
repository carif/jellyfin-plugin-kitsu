﻿using System;

namespace Jellyfin.Plugin.Kitsu.ApiClient.Models
{
    public class KitsuSeriesAttributes
    {
        public string Synopsis { get; set; }
        public KitsuTitles Titles { get; set; }
        public string AverageRating { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public KitsuImage PosterImage { get; set; }
        public KitsuImage CoverImage { get; set; }
    }
}

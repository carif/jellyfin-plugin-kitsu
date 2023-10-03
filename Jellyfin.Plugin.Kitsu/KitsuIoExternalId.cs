using MediaBrowser.Controller.Entities.Movies;
using MediaBrowser.Controller.Entities.TV;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Model.Entities;
using MediaBrowser.Model.Providers;

namespace Jellyfin.Plugin.Kitsu
{
    public class KitsuIoExternalId : IExternalId
    {
        public bool Supports(IHasProviderIds item)
            => item is Series or Movie;

        public string ProviderName
            => "Kitsu";

        public string Key
            => "Kitsu";

        public ExternalIdMediaType? Type
            => ExternalIdMediaType.Series;

        public string UrlFormatString
            => "https://kitsu.io/anime/{0}";
    }
}

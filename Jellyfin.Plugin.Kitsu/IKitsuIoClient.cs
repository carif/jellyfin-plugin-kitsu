namespace Jellyfin.Plugin.Kitsu;

public interface IKitsuIoClient
{
    void GetEpisode();
    void GetSeries();
    void GetManga();
    void GetCategories();
}

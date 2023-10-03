using System;
using System.Collections.Generic;
using Jellyfin.Plugin.Kitsu.Configuration;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;

namespace Jellyfin.Plugin.Kitsu
{
    /// <summary>
    /// Plugin class for the Kitsu library.
    /// </summary>
    public class Plugin : BasePlugin<PluginConfiguration>, IHasWebPages
    {
        /// <summary>
        /// Initializes a new instance of the &lt;see cref="Plugin"/&gt; class.
        /// </summary>
        /// <param name="applicationPaths">application paths</param>
        /// <param name="xmlSerializer">xml serializer</param>
        public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer) : base(applicationPaths, xmlSerializer)
        {
            Instance = this;
        }

        /// <summary>
        /// Gets the instance of Kitsu plugin.
        /// </summary>
        public static Plugin Instance { get; private set; }

        /// <inheritdoc/>
        public override string Name => "Kitsu";

        /// <inheritdoc/>
        public override Guid Id => Guid.Parse("88d809e2-056b-47f4-9911-073949b9963f");

        /// <summary>
        /// Return the plugin configuration page.
        /// </summary>
        /// <returns>PluginPageInfo.</returns>
        public IEnumerable<PluginPageInfo> GetPages()
        {
            return new[]
            {
                new PluginPageInfo
                {
                    Name = this.Name,
                    EmbeddedResourcePath = $"{GetType().Namespace}.Configuration.configPage.html"
                }
            };
        }
    }
}

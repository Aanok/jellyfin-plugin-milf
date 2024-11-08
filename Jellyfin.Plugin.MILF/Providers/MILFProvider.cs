using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using MediaBrowser.Controller.Entities.Movies;
using MediaBrowser.Controller.Entities.TV;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Model.Providers;

namespace Jellyfin.Plugin.MILF.Providers
{
    public class MILFProvider : IRemoteMetadataProvider<Movie, MovieInfo>, IRemoteMetadataProvider<Episode, EpisodeInfo>
    {
        /// <inheritdoc />
        public string Name => Plugin.PluginName;

        private string GetName(string path)
        {
            string name = Path.GetFileName(path);
            if (! string.IsNullOrEmpty(Plugin.Instance.Configuration.Naughty))
            {
                name = Regex.Replace(name, Plugin.Instance.Configuration.Naughty, string.Empty);
            }
            return name;
        }

        /// <inheritdoc />
        public async Task<MetadataResult<Movie>> GetMetadata(MovieInfo info, CancellationToken cancellationToken)
        {
            return new MetadataResult<Movie>
            {
                HasMetadata = true,
                Item = new Movie()
                {
                    Name = GetName(info.Path)
                }
            };
        }

        /// <inheritdoc />
        public async Task<MetadataResult<Episode>> GetMetadata(EpisodeInfo info, CancellationToken cancellationToken)
        {
            return new MetadataResult<Episode>
            {
                HasMetadata = true,
                Item = new Episode()
                {
                    Name = GetName(info.Path)
                }
            };
        }

        /// <inheritdoc />
        public Task<IEnumerable<RemoteSearchResult>> GetSearchResults(MovieInfo searchInfo, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public Task<IEnumerable<RemoteSearchResult>> GetSearchResults(EpisodeInfo searchInfo, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public Task<HttpResponseMessage> GetImageResponse(string url, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}

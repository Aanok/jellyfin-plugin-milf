using MediaBrowser.Model.Plugins;

namespace Jellyfin.Plugin.MILF.Configuration;

/// <summary>
/// Plugin configuration.
/// </summary>
public class PluginConfiguration : BasePluginConfiguration
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PluginConfiguration"/> class.
    /// </summary>
    public PluginConfiguration()
    {
        Naughty = "^\\[SubsPlease\\] |^\\[Erai\\-raws\\] |\\....$";
    }

    /// <summary>
    /// Gets or sets a string setting.
    /// </summary>
    public string Naughty { get; set; }
}

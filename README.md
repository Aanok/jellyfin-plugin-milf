# Metadata? I Like Filenames

This plugin adds a metadata provider that sets the Name property of Movie and Episode media to their filename.

It can be slightly customized with a regular expression to clean up the result a little. The default strips file extensions as well as prefixes for a couple anime release groups.

## Installation

I'm a lazy bastard so I'm not setting up a proper plugin repo. We ride and die by manual installation only in this household.

1. Get a hold of the dll, either by building the project or downloading a prebuilt binary from the Releases page.

2. Install the dll into your plugins folder on the server. On my machine it looks like
```
/var/lib/jellyfin/plugins/MILF/Jellyfin.Plugin.MILF.dll
```
3. Make sure the folder and file are readable by the user running the server binary.

## FAQ

- **Do you take bug reports?**

  Absolutely, if something is actually broken. It's likely you'll consider a bug something I consider a missing feature I don't care about, and then...

- **Do you take feature requests?**

  Nope. This already does everything I need it to do.

- **But isn't the regex thing really annoying to troubleshoot?**

  Yes it is. It sure could use a little sandbox to play with. I won't add it.

- **Did you name the plugin MILF just so you could define a MILFProvider class?**

  Correct.


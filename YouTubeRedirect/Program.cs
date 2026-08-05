using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;

namespace YouTubeRedirect
{
    internal class Program
    {
        static readonly Dictionary<string, string> Channels =
            new(StringComparer.OrdinalIgnoreCase)
        {
            // You can add the YouTube channel URLs of the artists you want here. Format: { "Artist Name", "YouTube Channel URL" }
            { "Oğuzhan Koç", "https://www.youtube.com/channel/UCwKIvPAKtlLAcc1c8-_J3uQ" }
            { "Gazapizm", "https://www.youtube.com/channel/UCi4_FLeTvoNs8cgV2cTBSWQ" },
            { "Ceza", "https://www.youtube.com/channel/UCJuok0XMLXfVoDUA-FLWXSQ" },
        };
        // Don't change the code below this line unless you know what you're doing.
        static void Main(string[] args)
        {
            if (args.Length == 0)
                return;

            string artist = args[0];

            if (artist.StartsWith("ytartist:", StringComparison.OrdinalIgnoreCase))
                artist = artist.Substring("ytartist:".Length);

            artist = WebUtility.UrlDecode(artist);

            if (Channels.TryGetValue(artist, out string channel))
            {
                Open(channel);
            }
            else
            {
                Open("https://www.youtube.com/results?search_query=" +
                     Uri.EscapeDataString(artist));
            }
        }

        static void Open(string url)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
    }
}
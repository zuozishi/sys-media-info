using NPSMLib;
using System;
using System.Text.Json;

var sessionManager = new NowPlayingSessionManager();
var session = sessionManager.CurrentSession;
var mediaSource = session?.ActivateMediaPlaybackDataSource();

if (session is null || mediaSource is null)
{
    Console.Write("{}");
    Environment.Exit(-1);
}

var obj = new
{
    Session = session,
    Playback = mediaSource.GetMediaPlaybackInfo(),
    MediaInfo = mediaSource.GetMediaObjectInfo(),
    Timeline = mediaSource.GetMediaTimelineProperties(),
};

string json = JsonSerializer.Serialize(obj, new JsonSerializerOptions
{
    WriteIndented = false
});
Console.Write(json);
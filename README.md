# sys-media-info

[![nuget](https://img.shields.io/nuget/v/sys-media-info?style=for-the-badge)](https://www.nuget.org/packages/sys-media-info)

## Description

.NET global tool. Get windows current NowPlayingSession info with json data.

## Prerequisites

* Windows 10 1511 (10586) or newer
* .NET 5 CLI or newer

## Installation

```shell
dotnet tool install --global sys-media-info
```

## Usage

```shell
> sys-media-info
```

Sample output:

```json
{
	"Session": {
		"PID": 23364,
		"RenderDeviceId": "Local",
		"SourceAppId": "C:\\Users\\Administrator\\AppData\\Roaming\\Spotify\\Spotify.exe",
		"SourceDeviceId": "Local",
		"Connection": null
	},
	"Playback": {
		"PropsValid": 47,
		"PlaybackCaps": 46326,
		"PlaybackState": 5,
		"PlaybackMode": 1,
		"RepeatMode": 1,
		"PlaybackRate": 0,
		"ShuffleEnabled": false,
		"LastPlayingFileTime": "2021-08-14T02:03:09.2339077+08:00"
	},
	"MediaInfo": {
		"AlbumArtist": "MYTH \u0026 ROID",
		"AlbumTitle": "eYe\u0027s",
		"Subtitle": "",
		"Title": "Paradisus-Paradoxum",
		"Artist": "MYTH \u0026 ROID",
		"MediaClassPrimaryID": "{D1607DBC-E323-4BE2-86A1-48A42A28441E}",
		"Genres": [],
		"AlbumTrackCount": 0,
		"TrackNumber": 3
	},
	"Timeline": {
		"StartTime": {
			"Ticks": 0,
			"Days": 0,
			"Hours": 0,
			"Milliseconds": 0,
			"Minutes": 0,
			"Seconds": 0,
			"TotalDays": 0,
			"TotalHours": 0,
			"TotalMilliseconds": 0,
			"TotalMinutes": 0,
			"TotalSeconds": 0
		},
		"EndTime": {
			"Ticks": 2311060000,
			"Days": 0,
			"Hours": 0,
			"Milliseconds": 106,
			"Minutes": 3,
			"Seconds": 51,
			"TotalDays": 0.002674837962962963,
			"TotalHours": 0.0641961111111111,
			"TotalMilliseconds": 231106,
			"TotalMinutes": 3.851766666666667,
			"TotalSeconds": 231.106
		},
		"MinSeekTime": {
			"Ticks": 0,
			"Days": 0,
			"Hours": 0,
			"Milliseconds": 0,
			"Minutes": 0,
			"Seconds": 0,
			"TotalDays": 0,
			"TotalHours": 0,
			"TotalMilliseconds": 0,
			"TotalMinutes": 0,
			"TotalSeconds": 0
		},
		"MaxSeekTime": {
			"Ticks": 2311060000,
			"Days": 0,
			"Hours": 0,
			"Milliseconds": 106,
			"Minutes": 3,
			"Seconds": 51,
			"TotalDays": 0.002674837962962963,
			"TotalHours": 0.0641961111111111,
			"TotalMilliseconds": 231106,
			"TotalMinutes": 3.851766666666667,
			"TotalSeconds": 231.106
		},
		"Position": {
			"Ticks": 1985030000,
			"Days": 0,
			"Hours": 0,
			"Milliseconds": 503,
			"Minutes": 3,
			"Seconds": 18,
			"TotalDays": 0.002297488425925926,
			"TotalHours": 0.05513972222222222,
			"TotalMilliseconds": 198503,
			"TotalMinutes": 3.3083833333333335,
			"TotalSeconds": 198.503
		},
		"PositionSetFileTime": "2021-08-14T02:03:05.0461775+08:00"
	}
}
```

### Roadmap

* [ ] Parameterization Support
* [ ] Console Table Output
* [ ] Watch Mode
* [ ] Intergrated SMTC (System Media Control) Capabilities

### Dependencies and References

* **[ADeltaX/NPSMLib](https://github.com/ADeltaX/NPSMLib)** - A NowPlayingSessionManager private API wrapper library.

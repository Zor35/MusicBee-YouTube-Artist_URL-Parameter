# MusicBee-YouTube-Artist_URL-Parameter

Warning: This repository was built entirely using AI.

Required parameter for MusicBee: `ytartist:<Artist>`

```Windows Registry Editor Version 5.00

[HKEY_CLASSES_ROOT\ytartist]
@="URL:YouTube Artist"
"URL Protocol"=""

[HKEY_CLASSES_ROOT\ytartist\DefaultIcon]
@="C:\\Path\\To\\YouTubeRedirect.exe,0"

[HKEY_CLASSES_ROOT\ytartist\shell]

[HKEY_CLASSES_ROOT\ytartist\shell\open]

[HKEY_CLASSES_ROOT\ytartist\shell\open\command]
@="\"C:\\Path\\To\\YouTubeRedirect.exe\" \"%1\""``` 


Replace `C:\\Path\\To\\YouTubeRedirect.exe` with the full path to `YouTubeRedirect.exe` inside your MusicBee `Local URLS` folder.

Example:
`C:\\Program Files (x86)\\MusicBee\\Local URLS\\YouTubeRedirect.exe`

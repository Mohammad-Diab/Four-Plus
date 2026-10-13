# Four Plus

A number-guessing duel for Windows, in the style of Bulls and Cows. You and your opponent each hide a four-digit number, and you take turns guessing the other's number. Written in C# with WPF on .NET Framework 4.8.

## How to play

- A number has four different digits from 1 to 9.
- After every guess you get a hint: one **+** for each right digit in the right place, one **>** for each right digit in the wrong place. `NO THING` means none of the digits are in the number.
- The first to get **++++** wins the round.

## Features

- **Single player:** play against the computer. Enter your secret number first; the computer keeps every possible number and drops the ones that don't fit its hints, so it closes in quickly.
- **Local multiplayer:** two players on one PC take turns; each enters a secret number hidden behind a password box.
- On-screen keypad, round counter and win counters, pause menu, and a New Game button that resets the score.
- The Options screen and the LAN and Internet multiplayer entries are only in the menu; they are not wired up.

## Requirements

Windows with .NET Framework 4.8. Windows 10 (May 2019 Update or later) and Windows 11 already include it.

## Usage

Download `Four-Plus-v1.0.0.7z` from [Releases](https://github.com/Mohammad-Diab/Four-Plus/releases), extract it, and run `Four Plus WPF.exe`. There is no installer.

The exe is not signed, so Windows SmartScreen may warn the first time you run it: click **More info**, then **Run anyway**.

## Building

```
git clone https://github.com/Mohammad-Diab/Four-Plus.git
```

Open `Four Plus WPF.sln` in Visual Studio and build, or run:

```
MSBuild "Four Plus WPF.sln" /p:Configuration=Release
```

The exe is written to `Four Plus WPF\bin\Release`.

## Other versions

- `Windows-8.1` holds the universal app for Windows 8.1 and Windows Phone 8.1 (single player, Arabic interface). Building it needs Visual Studio 2015 with the Windows 8.1 and Windows Phone 8.1 SDKs.
- Tag [`v0.1.0`](https://github.com/Mohammad-Diab/Four-Plus/tree/v0.1.0) is the first version, a console game named Number Game.
- [Four-Plus in Mini-Web-Projects](https://github.com/Mohammad-Diab/Mini-Web-Projects/tree/main/Four-Plus) is a JavaScript version for the browser.

## Author

Mohammad Diab

## License

[Apache 2.0](LICENSE)

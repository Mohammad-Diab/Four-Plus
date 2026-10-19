# Four Plus

A number-guessing duel for Windows, in the style of Bulls and Cows. You and your opponent each hide a four-digit number, and you take turns guessing the other's number. Written in C# with WPF on .NET Framework 4.8. The repository also holds the earlier universal app for Windows 8.1 and Windows Phone 8.1, whose Windows app also builds as a UWP app for Windows 10 and 11.

## How to play

- A number has four different digits from 1 to 9.
- After every guess you get a hint: one **+** for each right digit in the right place, one **>** for each right digit in the wrong place. `NO THING` means none of the digits are in the number.
- The first to get **++++** wins the round.

## Features

- **Single player:** play against the computer. Enter your secret number first; the computer keeps every possible number and drops the ones that don't fit its hints, so it closes in quickly.
- **Local multiplayer:** two players on one PC take turns; each enters a secret number hidden behind a password box.
- On-screen keypad, round counter and win counters, pause menu, and a New Game button that resets the score.
- The Options screen and the LAN and Internet multiplayer entries are only in the menu; they are not wired up.

### UWP edition

The Windows app from `Windows-8.1`, packaged for Windows 10 and 11. Single player against the computer, with an Arabic interface: you guess the computer's number, then type the hint for the computer's guess (**+** and **>**, or nothing when no digit is right). Your guesses and the computer's are listed side by side with their hints, and the app bar has New Game, Give up and About.

## Requirements

- WPF: Windows with .NET Framework 4.8. Windows 10 (May 2019 Update or later) and Windows 11 already include it.
- UWP edition: Windows 10 version 1709 or later, or Windows 11, x64.

## Usage

### WPF

Download `Four-Plus-v1.0.0.7z` from [Releases](https://github.com/Mohammad-Diab/Four-Plus/releases), extract it, and run `Four Plus WPF.exe`. There is no installer.

The exe is not signed, so Windows SmartScreen may warn the first time you run it: click **More info**, then **Run anyway**.

### UWP edition

1. Download `Four-Plus-v0.2.0-win-x64.7z` from [Releases](https://github.com/Mohammad-Diab/Four-Plus/releases) and extract it.
2. Double-click `Install.cmd` in the extracted folder and accept the administrator prompt. The script adds the package's certificate to **Trusted People** on the PC, installs the framework packages the app needs that are missing, then installs the signed app package. Developer Mode is not needed.
3. Start Four Plus from the Start menu.

The package is signed with a self-signed certificate, which is why the certificate is added to Trusted People first; only that step needs elevation, the app is installed for the current user. To remove the app, uninstall it from the Start menu.

## Building

```
git clone https://github.com/Mohammad-Diab/Four-Plus.git
```

### WPF

Open `Four Plus WPF.sln` in Visual Studio and build, or run:

```
MSBuild "Four Plus WPF.sln" /p:Configuration=Release
```

The exe is written to `Four Plus WPF\bin\Release`.

### UWP edition

The Windows app is a Windows 8.1 app, and the Windows 8.1 SDK no longer comes with Visual Studio, so it builds as a Universal Windows app: `Windows-8.1\Four Plus\Four Plus.Windows\Directory.Build.targets` adds the UWP package and a Windows 10 manifest with the same identity, the logos, and Mohammad Diab as publisher (`Windows-8.1\Four Plus\Four Plus.Windows\_uwp`). Needs Visual Studio (or its Build Tools) with the **Universal Windows Platform development** workload and the Windows SDK 10.0.22621.0:

```
set P=/p:Configuration=Release /p:Platform=x64 /p:TargetPlatformIdentifier=UAP /p:TargetPlatformVersion=10.0.22621.0 /p:TargetPlatformMinVersion=10.0.16299.0 /p:UseDotNetNativeToolchain=true
MSBuild "Windows-8.1\Four Plus\Four Plus.Windows\Four Plus.Windows.csproj" /t:Restore %P%
MSBuild "Windows-8.1\Four Plus\Four Plus.Windows\Four Plus.Windows.csproj" %P% /p:AppxBundle=Never /p:AppxPackageSigningEnabled=false /p:GenerateAppxPackageOnBuild=true /p:UapAppxPackageBuildMode=SideloadOnly /p:AppxPackageDir=<output>\
```

Run the commands from a Developer Command Prompt for Visual Studio, so `MSBuild` is on the path. The package is written to `<output>\Four Plus.Windows_1.0.0.0_x64_Test\Four Plus.Windows_1.0.0.0_x64.appx`, next to its `Dependencies` folder; Release builds compile with .NET Native and take a few minutes. .NET Native (`ilc`) fails on long paths, so build from a short path: for example `subst R: <clone folder>` (any free drive letter), then run the commands from `R:\`. The package is built unsigned; sign it with your own certificate before installing it:

```
signtool sign /fd SHA256 /f <certificate.pfx> /p <password> "<output>\Four Plus.Windows_1.0.0.0_x64_Test\Four Plus.Windows_1.0.0.0_x64.appx"
```

The certificate's subject must be `CN=Mohammad Diab`, the publisher in the manifest. The logos are rendered from the XAML files in `_uwp\icon` with `_uwp\icon\render.ps1`.

## Other versions

- `Windows-8.1` holds the universal app for Windows 8.1 and Windows Phone 8.1 (single player, Arabic interface). Its Windows app builds as the UWP edition (see Building); building the original Windows 8.1 and Windows Phone 8.1 apps needs Visual Studio 2015 with the Windows 8.1 and Windows Phone 8.1 SDKs.
- Tag [`v0.1.0`](https://github.com/Mohammad-Diab/Four-Plus/tree/v0.1.0) is the first version, a console game named Number Game.
- [Four-Plus in Mini-Web-Projects](https://github.com/Mohammad-Diab/Mini-Web-Projects/tree/main/Four-Plus) is a JavaScript version for the browser.

## Author

Mohammad Diab

## License

[Apache 2.0](LICENSE)

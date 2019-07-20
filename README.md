# Multiple Copy Plugin for ILSpy

[![Build status](https://ci.appveyor.com/api/projects/status/ys3eq1hg202woqpa?svg=true)](https://ci.appveyor.com/project/lpubsppop01/ilspymultiplecopy)

A plugin for ILSpy that add "Copy text" menu item to context menu in tree view.

## Features

When you click the "Copy text" menu item, output text of selected tree view item to clipboard.
The "Copy text" menu item is available for multiple tree view items, unlike standard "Copy FQ name" menu item.

This is a simple plug-in, but it is useful when pasting the contents of a tree view into a message or document.

## Download

Latest Build:
- [Lpubsppop01.ILSpyMultipleCopy.Plugin.dll](https://ci.appveyor.com/api/projects/lpubsppop01/ilspymultiplecopy/artifacts/ILSpyMultipleCopy/bin/Release/Lpubsppop01.ILSpyMultipleCopy.Plugin.dll)

## Requirements

- ILSpy 4.0.1 to use
- Visual Studio 2019 to build

## Author

[lpubsppop01](https://github.com/lpubsppop01)

## License

[zlib License](https://github.com/lpubsppop01/ILSpyMultipleCopy/raw/master/LICENSE.txt)

This software uses the following NuGet packages:
- [System.ComponentModel.Composition](https://www.nuget.org/packages/System.ComponentModel.Composition/)  
  Copyright (c) .NET Foundation and Contributors  
  Released under the [MIT License](https://github.com/dotnet/corefx/blob/master/LICENSE.TXT)

When you build this software, ILSpy binary files are downloaded and referenced during the build.

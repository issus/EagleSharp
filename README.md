

# EagleSharp: .NET Library for Parsing and Manipulating EAGLE PCB Files

[![NuGet](https://img.shields.io/nuget/v/OriginalCircuit.EagleSharp.svg)](https://www.nuget.org/packages/OriginalCircuit.EagleSharp) [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

EagleSharp is a easy-to-use .NET library for parsing and anipulating EAGLE PCB files. It allows you to load and read data from EAGLE PCB files and make changes to them programmatically. With EagleSharp, you can easily automate tasks such as updating component symbols and library definitions, or extracting data for use in other tools.

## Features

-   Load and parse EAGLE PCB files
-   Access and modify data in EAGLE files such as component symbols, library definitions, and schematics
-   Serialize modified EAGLE files back to disk

## Getting Started

You can install EagleSharp through NuGet by searching for `OriginalCircuit.EagleSharp` in the NuGet Package Manager or by using the following command in the Package Manager Console:

`Install-Package OriginalCircuit.EagleSharp` 


### Example: Reading Pins from a Symbol Definition

Here is an example of how to use EagleSharp to load a library file and read the pins from each symbol:

```csharp
using OriginalCircuit.EagleSharp;

...

var xs = new XmlSerializer(typeof(Eagle),"");
Eagle lbr = (Eagle)xs.Deserialize(stream);

if (lbr.Drawing.Library == null)
    return;

foreach (var deviceSet in lbr.Drawing.Library.DeviceSets.DeviceSet)
{
    string name = deviceSet.Name;
    foreach (var device in deviceSet.Devices.Device)
    {
        var pins = device.Connects.Connect.Select(o => new PinDefinition(o.Pad, o.Pin));
        // Add the pins to a symbol definition object here
        // ...
    }
}
```

## License

EagleSharp is released under the MIT license. See the [LICENSE](https://github.com/issus/EagleSharp/blob/main/LICENSE) file for details.
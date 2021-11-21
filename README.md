# EagleSharp
 .NET Library for reading/writing EAGLE PCB files. At this point, it's just a series of .NET classes generated from the published Eagle DTD with a lot of cleanup of names. This has only been tested by reading a couple of library files.. so there is a very high chance it will fail to load some files with xml errors. 
 
 If you have issues, feel free to fix them and submit a pull request, or submit the error + your file as a bug.


If you are interested in this, you may also be interested in [@ThisIsNotRocketScience's](https://github.com/ThisIsNotRocketScience/) [Gerber Tools](https://github.com/ThisIsNotRocketScience/GerberTools). He has a similar implementation of the Eagle DTD in the EagleLoaders folder, however it only uses fields with all lowercase names and doesn't match typical C# style guides. It is more likely to load a board/schematic than this is, at this point of EagleSharp's development.
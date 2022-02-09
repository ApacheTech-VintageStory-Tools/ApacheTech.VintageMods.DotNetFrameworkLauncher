# Launcher App

This project is needed to load the .NET Framework 4.6.1 Debugging Engine, meaning that debugging features
such as "Apply Code Changes" (aka "Edit and Continue") will work with mods made in .NET Standard 2.0.

It is assumed that you will have followed the pre-install steps for this template, however, it is possible to
change the environment variables used within this application, by setting the **%VINTAGE_STORY%** environment
variable to the game's install directory, and then Unloading, and Reloading the project within Visual Studio.

This app should be set as the Startup Project for the solution, and will only launch Vintage Story when the
solution is in Debug configuration.

If you have any issues with the automatic setting of file and folder locations, please add the relevant details
manually within the Debug tab of the project Properties.

### Default Properties Settings:
 --addOrigin="$(SolutionDir)$(SolutionName)\bin\$(Configuration)\netstandard2.0\assets" --addOrigin="$(SolutionDir)$(SolutionName)\bin\$(Configuration)\netstandard2.0\_Includes\assets"

```xml
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="Current" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
	<PropertyGroup Condition="'$(Configuration)|$(Platform)' == 'Package|AnyCPU'">
		<StartAction>Program</StartAction>
		<StartProgram>$(VINTAGE_STORY)\Vintagestory.exe</StartProgram>
		<StartArguments>--tracelog --addModPath="$(SolutionDir).releases"</StartArguments>
		<StartWorkingDirectory>$(VINTAGE_STORY)</StartWorkingDirectory>
	</PropertyGroup>
	<PropertyGroup Condition="'$(Configuration)|$(Platform)' != 'Package|AnyCPU'">
		<StartAction>Program</StartAction>
		<StartProgram>$(VINTAGE_STORY)\Vintagestory.exe</StartProgram>
		<StartArguments>--tracelog --addModPath="$(SolutionDir)$(SolutionName)\bin\$(Configuration)"</StartArguments>
		<StartWorkingDirectory>$(VINTAGE_STORY)</StartWorkingDirectory>
	</PropertyGroup>
</Project>
```
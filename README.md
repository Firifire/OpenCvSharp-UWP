# OpenCvSharp UWP
C# Wrapper of OpenCV for UWP applications. This Wrapper is based off [OpenCvSharp](https://github.com/shimat/opencvsharp/) 3.3.1 by Shimat and I have similar changes implemented in [opencv-hololens](https://github.com/sylvain-prevost/opencv-hololens) by Sylvain Prevost on the 3.3.1 version of OpenCV

I have made some changes to the wrapper to make it compatible with UWP builds.

## Compatibility
I have originally made this to use OpenCV with hololens applications built on Unity.

I have not tried it, but it may be compatible with UWP in general.

Currently the dll in the included Nuget is only for x86 Release Build.

## Dependencies
Please use the included Nuget
When installing the Nuget: **Dont Overwrite anything**

[Microsoft.NETCore.UniversalWindowsPlatform Nuget](https://www.nuget.org/packages/Microsoft.NETCore.UniversalWindowsPlatform/5.0.0)  (v5.0.0 recommended for Unity compatiblity)  

For Unity, copy all the built dll to the plugins folder

## Usage
Plese refer to [OpenCvSharp](https://github.com/shimat/opencvsharp/)

Include the DLLs from the release section in to your project.

UWP dll does not work in unity Editor, only works when building the UWP app.

## Issues
As I have recently built this, it has been working well so far. It probably has a lot of bugs present and I will fix them as I discover them. It would be helpfull if any issues discovered are reported.

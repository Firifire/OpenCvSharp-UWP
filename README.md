# OpenCvHololens
C# Wrapper of OpenCV for UWP applications. This Wrapper is based off [OpenCvSharp](https://github.com/shimat/opencvsharp/) 3.1 by Shimat and uses [opencv-hololens](https://github.com/sylvain-prevost/opencv-hololens) by Sylvain Prevost

I have made some changes to the wrapper to make it compatible with UWP builds.

## Compatibility
I have originally made this to use OpenCV with hololens applications built on Unity.

I have not tried it, but it may be compatible with UWP in general.

## Dependencies
[OpenCV-Hololens Nuget](https://www.nuget.org/packages/OpenCV-Hololens/)

[Microsoft.NETCore.UniversalWindowsPlatform Nuget](https://www.nuget.org/packages/Microsoft.NETCore.UniversalWindowsPlatform/5.0.0)  (v5.0.0 recommended for Unity compatiblity)  


## Usage
Plese refer to [OpenCvSharp](https://github.com/shimat/opencvsharp/)

I have replaced the namespace OpencvSharp with OpenCvHololens to prevent conflicts.

UWP dll does not work in unity Editor

## Issues
As I have recently built this, it has been working well so far. It probably has a lot of bugs present and I will fix them as I discover them. It would be helpfull if any issues discovered are reported.

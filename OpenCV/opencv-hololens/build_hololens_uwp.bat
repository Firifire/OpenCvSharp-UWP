REM 1/ Prepare opencv files for future build (and generate project/solutions files)
REM 2/ -b option of 'setup_winrt' triggers the 'Release' build once preparation is complete (assumes MS build)

set Basedir=%~dp0
set ContribModulesDir="C:\Users\Mazin\Desktop\opencv-hololens-contrib\modules"

rmdir /S /Q Junk
rmdir /S /Q CMakeFiles

cd %Basedir%\platforms\winrt
cmd /C setup_winrt -b "WS" "10.0" "x86" "OFF" -g "Visual Studio 12 2013" -c %ContribModulesDir%
cd %Basedir%
pause
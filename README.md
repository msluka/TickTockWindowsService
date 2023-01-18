Windows Service created as Console Application

Note: This service will not work without Topshelf Nuget Package

-----

Installation:

We can install the service without deploying the application. 
In Visual Studio Project Repository we have to find the .exe file in bin/debug folder 
and run the following command in CMD with administrator mode:

TickTockWindowsService.exe install start

we can uninstall the service:

TickTockWindowsService.exe uninstall

The original, not modified code can be found at:
https://www.youtube.com/watch?v=y64L-3HKuP0#

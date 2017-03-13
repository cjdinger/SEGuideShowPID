# Show the Windows PID in SEGuide window title - SEGuideShowPID
A custom task that adds the Windows process ID (PID) into the application title bar.  It works by initializing itself when you start SAS Enterprise Guide.

The bulk of the work is in ShowPID.cs.  It's just a few lines of code that detects the process, grabs the Windows handle, then uses pinvoke methods to set the window title on the current SEGuide.exe process.

To use the task:
 - copy the SEGuideShowPID.DLL to %appdata%\SAS\EnterpriseGuide\<ver>\Custom, where <ver> is the version of SAS Enterprise Guide you're running.
 - You might need to create the Custom subfolder in that location
 - The task should work with SAS Enterprise Guide 4.3 and later.
 


# Show the Windows PID in SEGuide window title - SEGuideShowPID
A custom task that adds the Windows process ID (PID) into the application title bar.  It works by initializing itself when you start SAS Enterprise Guide.

![Screenshot of the task](https://github.com/cjdinger/SEGuideShowPID/blob/master/pids_example.png?raw=true "Task in action")

The bulk of the work is in [ShowPID.cs](https://github.com/cjdinger/SEGuideShowPID/blob/master/ShowPID.cs).  It's just a few lines of code that detects the process, grabs the Windows handle, then uses pinvoke methods to set the window title on the current SEGuide.exe process.

To use the task:
 - copy the TaskDLL/SEGuideShowPID.DLL to %appdata%\SAS\EnterpriseGuide\(ver)\Custom, where (ver) is the version of SAS Enterprise Guide you're running.
 - You might need to create the Custom subfolder in that location
 - The task should work with SAS Enterprise Guide 4.3 and later.
 - You might need to "unblock" the DLL [per these instructions](http://blogs.sas.com/content/sasdummy/2013/05/19/unblocking-custom-task-dlls/)
 


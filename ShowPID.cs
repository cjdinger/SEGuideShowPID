using SAS.Shared.AddIns;
using SAS.Tasks.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

// Copyright 2017 SAS Institute Inc
// Provided for example purposes only
// Support: Chris Hemedinger
namespace SEGuideShowPID
{
    [ClassId("41700F6D-F399-4442-811F-851477BD42A0")]
    [InputRequired(InputResourceType.None)]
    public class ShowPID : SAS.Tasks.Toolkit.SasTask
    {
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool SetWindowText(IntPtr hwnd, String lpString);

        // this constructor might be called multiple times, but we want
        // to set the title just once
        static bool handled = false;

        public ShowPID()
        {
            // Check if this is SEGuide.exe process
            IntPtr hwnd = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;
            if (null != hwnd && 
                (System.Diagnostics.Process.GetCurrentProcess().MainWindowTitle == "SAS Enterprise Guide") && 
                (!handled))
            {
                try
                {
                    string title = string.Format("{0} (PID={1})", 
                        System.Diagnostics.Process.GetCurrentProcess().MainWindowTitle,
                        System.Diagnostics.Process.GetCurrentProcess().Id);
                    SetWindowText(hwnd, title);

                }
                catch { };

                ShowPID.handled = true;
            }
        }

    }
}

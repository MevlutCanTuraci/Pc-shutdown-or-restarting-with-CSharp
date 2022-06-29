/*
Syntax

      SHUTDOWN [logoff_option]  [/m \\Computer] [options]

logoff_option:
    /i         Display the GUI (must be the first option)
    /l         Log off. This cannot be used with /m or /d option
    /s         Shutdown
    /r         Shutdown and Restart
    /a         Abort a system shutdown.
               (only during the time-out period)
    /p         Turn off the local computer with no time-out or warning
               (only with /d)
    /h         Hibernate the local computer (only with /f )
    /e         Document the reason for an unexpected shutdown of a computer

Options:

   /m \\Computer  : A remote computer to shutdown.

   /t:xxx         : Time until system shutdown in seconds. 
                    The valid range is xxx=0-600 seconds. [default=30]
   /c "Msg"       : An optional shutdown message [Max 127 chars]

   /f             : Force running applications to close.
                    This will not prompt for File-Save in any open applications.
                    so will result in a loss of all unsaved data!!!

   /d u:xx:yy     : List a USER reason code for the shutdown. 
   /d P:xx:yy     : List a PLANNED reason code for the shutdown.
                     xx Specifies the major reason code (0-255)
                     yy Specifies the minor reason code (0-65536)


WebSite : https://ss64.com/nt/shutdown.html

*/


/* 

using System.Diagnostics;  //Required library 

*/


/* Pc Shutdown code  */

Process.Start("ShutDown", "/s"); 


/* Pc Restart code */
Process.Start("ShutDown", "/r");


/* Code that shuts down computer after 10 seconds */
Process.Start("shutdown","/s /t 10");


/* Code that restarting computer after 10 seconds */

Process.Start("shutdown","/r /t 10");



using System;

namespace OpenGlHost
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            OpenGlHost glHost = new OpenGlHost();
            glHost.Run();
        }
    }
}

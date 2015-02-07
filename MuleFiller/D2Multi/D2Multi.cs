using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Runtime.InteropServices;

namespace MuleFiller.D2Multi
{
    public static class D2Multi
    {
        private const int SW_SHOWNORMAL = 1;
        private const int SW_SHOWMINIMIZED = 2;
        private const int SW_SHOWMAXIMIZED = 3;

        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
        

        private static String D2MConfig = @"D2Multi.ini";
        private static String D2MExe = @"D2Multi.exe";

        /// <summary>
        /// Runs Diablo II session with D2Multi.exe
        /// </summary>
        /// <param name="fileName">Path to Diablo II.exe in Diablo directory</param>
        /// <param name="windowed">true / false to run in window mode</param>
        /// <param name="title">Set custom window name</param>
        /// <returns>Process</returns>
        public static Process Run(string fileName, bool windowed, bool cacheFix, string title = "Diablo II")
        {
            String args = "";
            makeConfig(Directory.GetParent(fileName).ToString());

            if (windowed)
                args += "-w ";

            if (cacheFix)
                args += "-cachefix ";

            args += "-title \"" + title + "\"";

            ProcessStartInfo PSI = new ProcessStartInfo();
            PSI.FileName = D2MExe;
            PSI.Arguments = args;

            return Process.Start(PSI);
        }

        /// <summary>
        /// Makes a configuration file for D2Multi.exe
        /// </summary>
        /// <param name="filename">Path to Diablo II directory</param>
        private static void makeConfig(String dirName)
        {
            String config = "[Settings]\nD2Folder = \"" + dirName + "\"";
            using (StreamWriter writer = new StreamWriter(D2MConfig))
            {
                writer.WriteLine("[Settings]");
                writer.WriteLine("D2Folder = \"" + dirName + "\\\"");
            }
        }
    }
}

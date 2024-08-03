using System.Collections;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace YTDL_GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }

        static int dlCounter = 1;
        static List<Downloader> dlList = [];

        public static void newDownloader()
        {
            Downloader dl = new Downloader(dlCounter++);
            dlList.Add(dl);
        }

        public static int getCounter()
        {
            return dlCounter;
        }

        public static Downloader getDownloader(int index)
        {
            return dlList[index];
        }
    }
}
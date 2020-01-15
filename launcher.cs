using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Diagnostics;

namespace mcLaunch
{
    class Program
    {
        static void DownloadJavaUnpack(string Version)
        {
            System.Net.WebClient Downloader = new System.Net.WebClient();
            print("Downloading minecraft jars.... (Version) " + Version);
            Downloader.DownloadFile("http://liab.890m.com/minecraft/mc.zip", "mc.zip");
            print("Jar data length > " + Downloader.Headers.AllKeys.Length.ToString());
            System.IO.Directory.CreateDirectory(@"C:\Users\" + Environment.UserName + @"\AppData\Roaming\.minecraft\versions\" + Version);
            ZipFile.ExtractToDirectory("mc.zip", @"C:\Users\" + Environment.UserName + @"\AppData\Roaming\.minecraft\versions\" + Version);
            print("launching minecraft... (Version)" + Version);
            Process.Start(@"C: \Users\" + Environment.UserName + @"\AppData\Roaming\.minecraft\versions\" + Version + @"\" + Version + ".jar");
            Console.Read();
        }
        static void col(ConsoleColor test)
        {
            Console.ForegroundColor = test;
        }
        static void print(string toPrint)
        {
            Console.WriteLine(toPrint);
        }
        static void Main(string[] args)
        {
            col(ConsoleColor.Red);
            print("CraftLauncher 1.0 (OpenSource|Hirako)");
            print("Load time << " + System.DateTime.Now.Hour.ToString() + ":" + System.DateTime.Now.Minute);
            DownloadJavaUnpack("1.15.1");
            
        }
    }
}

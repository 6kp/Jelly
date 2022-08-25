using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jelly
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }



        public static string AppName = "Jelly"; //Change this to your desired app name
        public static string BuildVer = "1.0.0"; //Change this to the current build version

        public static void getVer()
        {
            WebClient wc = new WebClient();
            var ver = wc.DownloadString("https://pastebin.com/raw/Dxv5RbWN"); //Make a Pastebin document containing your latest version

            if (ver.Contains(BuildVer))
            {
                return;
            }
            else
            {
                MessageBox.Show("You don't have the latest version!", AppName);
                Environment.Exit(0);
            }
        }
    }
}

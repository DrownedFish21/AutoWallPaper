using System.Runtime.InteropServices;

namespace WallPaper
{
    internal static class Program
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        private const int SPI_SETDESKWALLPAPER = 20;
        private const int SPIF_UPDATEINIFILE = 0x01;
        private const int SPIF_SENDWININICHANGE = 0x02;

        public static string[] wallpaperPaths;
        [STAThread]
        static void Main()
        { 
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmMain());
        }

        public static void GetWallPapers()
        {
            string str;
            if (FrmMain.PNGfile != null)
            {
                str = FrmMain.PNGfile;
            }
            else
                str = @"C:\Wallpapers";
            wallpaperPaths = Directory.GetFiles(str + @"\", "*.png");
        }
        public static void ChangeWallpaper(int index)
        { 
            string newWallpaper;

            newWallpaper = wallpaperPaths[index];
           
           
            SetDesktopBackground(newWallpaper);
        }
        private static void SetDesktopBackground(string wallpaperPath)
        {
            int result = SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, wallpaperPath, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);

            if (result == 0)
            {
                Console.WriteLine("更换失败");
            }
            else
            {
                Console.WriteLine("更换成功");
            }
        }

    }



}
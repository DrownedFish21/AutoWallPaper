using Microsoft.Win32;
using System.Data;

namespace WallPaper
{
    public partial class FrmMain : Form
    {
        public static int Sindex;
        public static string? PNGfile;
        public static bool isFollowTime = false;
        public static Event evn;
        public FrmMain()
        {

            Sindex = 0;
            InitializeComponent();
            txtPath.Text = @"C:\Wallpapers";
            SetStartup();
            Program.GetWallPapers();
            evn = new Event();
            //evn.Temp= 0;


            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick1;
            timer.Start();
            Program.ChangeWallpaper(evn.Temp);

            evn.OntempChange += new Event.tempChange(ven_OntempChange);

        }

        private void ven_OntempChange(object sender, EventArgs e)
        {

        }

        private void Timer_Tick1(object? sender, EventArgs e)
        {

            DateTime now = DateTime.Now;
            TextTimeLabel.Text = now.ToString();
            MorningBgn.Value = NightEnd.Value;
            NoonBgn.Value = MorningEnd.Value;
            AfternoonBgn.Value = NoonEnd.Value;
            NightBgn.Value = AfternoonEnd.Value;
            if (now.Hour > MorningBgn.Value.Hour && now.Hour <= MorningEnd.Value.Hour)
            {
                //上午
                //index = 0;
                evn.Temp = 0;
            }
            else if (now.Hour > NoonBgn.Value.Hour && now.Hour <= NoonEnd.Value.Hour)
            {
                //中午
                //index = 1;
                evn.Temp = 1;
            }
            else if (now.Hour > AfternoonBgn.Value.Hour && now.Hour <= AfternoonEnd.Value.Hour)
            {
                //日落

                //index = 2;
                evn.Temp = 2;
            }
            else if (now.Hour > NightBgn.Value.Hour && now.Hour < NightEnd.Value.Hour)
            {
                //夜晚
                //index = 3;
                evn.Temp = 3;
            }
            label2.Text = @"当前壁纸编号：" + evn.Temp.ToString();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            //Program.ChangeWallpaper(Sindex);         
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.Description = "请选择文件夹";
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialog.ShowNewFolderButton = true;
            if (txtPath.Text.Length > 0) folderBrowserDialog.SelectedPath = txtPath.Text;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = folderBrowserDialog.SelectedPath;
            }
            PNGfile = txtPath.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.GetWallPapers();
            MessageBox.Show("已获取壁纸！");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("先选择你放置的文件路径（四张风景图）[一定要确认路径是正确的！！！]，然后点击确定。可以自定义设置时间范围。");
        }


        private void FrmMain_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }

        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要退出程序吗？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                notifyIcon1.Visible = false;
                Close();
                Dispose();
                Application.Exit();
            }

        }

        private void hideMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void showMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            Activate();

        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
                Hide();
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                Show();
                WindowState = FormWindowState.Normal;
                Activate();
            }

        }

        //设置开机自启动
        private void SetStartup()
        {
            string exePath = Application.ExecutablePath;
            string appName = Path.GetFileNameWithoutExtension(exePath);
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            rk?.SetValue(appName, exePath);
        }
        //移除开机自启动
        private void RemoveStartup()
        {
            string appName = Path.GetFileNameWithoutExtension(Application.ExecutablePath);
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            rk?.DeleteValue(appName, false);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        #region keyPress
        private void MorningBgn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void MorningEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void NoonBgn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void NoonEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void NightEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void AfternoonEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        #endregion

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
    public class Event
    {
        public delegate void tempChange(object sender, EventArgs e);
        public event tempChange? OntempChange;
        public static int temp = 0;
        public int Temp
        {
            get
            {
                return temp;
            }
            set
            {
                if (temp != value)
                {
                    OntempChange(this, new EventArgs());
                    int i = value;
                    Program.ChangeWallpaper(i);
                }
                temp = value;
            }
        }
    }

}

namespace WallPaper
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            TextTimeLabel = new Label();
            folderBrowserDialog = new FolderBrowserDialog();
            button2 = new Button();
            txtPath = new TextBox();
            button3 = new Button();
            label1 = new Label();
            button4 = new Button();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            exitMenuItem = new ToolStripMenuItem();
            hideMenuItem = new ToolStripMenuItem();
            showMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            label3 = new Label();
            TimeSetPanel = new Panel();
            NightEnd = new DateTimePicker();
            NightBgn = new DateTimePicker();
            AfternoonEnd = new DateTimePicker();
            AfternoonBgn = new DateTimePicker();
            NoonEnd = new DateTimePicker();
            NoonBgn = new DateTimePicker();
            MorningEnd = new DateTimePicker();
            MorningBgn = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            timeBindingSource = new BindingSource(components);
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            contextMenuStrip1.SuspendLayout();
            TimeSetPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)timeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // TextTimeLabel
            // 
            TextTimeLabel.AutoSize = true;
            TextTimeLabel.Location = new Point(79, 20);
            TextTimeLabel.Margin = new Padding(2, 0, 2, 0);
            TextTimeLabel.Name = "TextTimeLabel";
            TextTimeLabel.Size = new Size(104, 17);
            TextTimeLabel.TabIndex = 1;
            TextTimeLabel.Text = "暂未获取当前时间";
            // 
            // button2
            // 
            button2.Location = new Point(192, 85);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(72, 25);
            button2.TabIndex = 2;
            button2.Text = "选择文件夹";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(19, 85);
            txtPath.Margin = new Padding(2, 3, 2, 3);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(169, 23);
            txtPath.TabIndex = 3;
            txtPath.Text = "C:\\Wallpapers";
            // 
            // button3
            // 
            button3.Location = new Point(268, 85);
            button3.Margin = new Padding(2, 3, 2, 3);
            button3.Name = "button3";
            button3.Size = new Size(72, 25);
            button3.TabIndex = 5;
            button3.Text = "确定";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 20);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 6;
            label1.Text = "当前时间";
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.Location = new Point(613, 12);
            button4.Margin = new Padding(2, 3, 2, 3);
            button4.Name = "button4";
            button4.Size = new Size(72, 25);
            button4.TabIndex = 7;
            button4.Text = "帮助";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "我的壁纸";
            notifyIcon1.Visible = true;
            notifyIcon1.DoubleClick += notifyIcon1_DoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { exitMenuItem, hideMenuItem, showMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(101, 70);
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(100, 22);
            exitMenuItem.Text = "退出";
            exitMenuItem.Click += exitMenuItem_Click;
            // 
            // hideMenuItem
            // 
            hideMenuItem.Name = "hideMenuItem";
            hideMenuItem.Size = new Size(100, 22);
            hideMenuItem.Text = "隐藏";
            hideMenuItem.Click += hideMenuItem_Click;
            // 
            // showMenuItem
            // 
            showMenuItem.Name = "showMenuItem";
            showMenuItem.Size = new Size(100, 22);
            showMenuItem.Text = "显示";
            showMenuItem.Click += showMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 65);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 8;
            label2.Text = "选择壁纸路径";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 11);
            label3.Name = "label3";
            label3.Size = new Size(80, 17);
            label3.TabIndex = 9;
            label3.Text = "自定义时间域";
            // 
            // TimeSetPanel
            // 
            TimeSetPanel.BorderStyle = BorderStyle.FixedSingle;
            TimeSetPanel.Controls.Add(label11);
            TimeSetPanel.Controls.Add(label10);
            TimeSetPanel.Controls.Add(label9);
            TimeSetPanel.Controls.Add(label8);
            TimeSetPanel.Controls.Add(NightEnd);
            TimeSetPanel.Controls.Add(NightBgn);
            TimeSetPanel.Controls.Add(AfternoonEnd);
            TimeSetPanel.Controls.Add(AfternoonBgn);
            TimeSetPanel.Controls.Add(NoonEnd);
            TimeSetPanel.Controls.Add(NoonBgn);
            TimeSetPanel.Controls.Add(MorningEnd);
            TimeSetPanel.Controls.Add(MorningBgn);
            TimeSetPanel.Controls.Add(label7);
            TimeSetPanel.Controls.Add(label6);
            TimeSetPanel.Controls.Add(label5);
            TimeSetPanel.Controls.Add(label4);
            TimeSetPanel.Controls.Add(label3);
            TimeSetPanel.Location = new Point(19, 142);
            TimeSetPanel.Name = "TimeSetPanel";
            TimeSetPanel.Size = new Size(496, 200);
            TimeSetPanel.TabIndex = 10;
            // 
            // NightEnd
            // 
            NightEnd.CustomFormat = "HH:00";
            NightEnd.Format = DateTimePickerFormat.Custom;
            NightEnd.Location = new Point(308, 152);
            NightEnd.Name = "NightEnd";
            NightEnd.ShowUpDown = true;
            NightEnd.Size = new Size(61, 23);
            NightEnd.TabIndex = 21;
            NightEnd.Value = new DateTime(2023, 6, 11, 5, 0, 0, 0);
            NightEnd.KeyPress += NightEnd_KeyPress;
            // 
            // NightBgn
            // 
            NightBgn.CustomFormat = "HH:00";
            NightBgn.Enabled = false;
            NightBgn.Format = DateTimePickerFormat.Custom;
            NightBgn.Location = new Point(140, 151);
            NightBgn.Name = "NightBgn";
            NightBgn.ShowUpDown = true;
            NightBgn.Size = new Size(61, 23);
            NightBgn.TabIndex = 20;
            NightBgn.Value = new DateTime(2023, 6, 11, 19, 54, 0, 0);
            // 
            // AfternoonEnd
            // 
            AfternoonEnd.CustomFormat = "HH:00";
            AfternoonEnd.Format = DateTimePickerFormat.Custom;
            AfternoonEnd.Location = new Point(308, 118);
            AfternoonEnd.Name = "AfternoonEnd";
            AfternoonEnd.ShowUpDown = true;
            AfternoonEnd.Size = new Size(61, 23);
            AfternoonEnd.TabIndex = 19;
            AfternoonEnd.Value = new DateTime(2023, 6, 11, 19, 54, 0, 0);
            AfternoonEnd.KeyPress += AfternoonEnd_KeyPress;
            // 
            // AfternoonBgn
            // 
            AfternoonBgn.CustomFormat = "HH:00";
            AfternoonBgn.Enabled = false;
            AfternoonBgn.Format = DateTimePickerFormat.Custom;
            AfternoonBgn.Location = new Point(140, 122);
            AfternoonBgn.Name = "AfternoonBgn";
            AfternoonBgn.ShowUpDown = true;
            AfternoonBgn.Size = new Size(61, 23);
            AfternoonBgn.TabIndex = 18;
            AfternoonBgn.Value = new DateTime(2023, 6, 11, 17, 54, 0, 0);
            // 
            // NoonEnd
            // 
            NoonEnd.CustomFormat = "HH:00";
            NoonEnd.Format = DateTimePickerFormat.Custom;
            NoonEnd.Location = new Point(308, 85);
            NoonEnd.Name = "NoonEnd";
            NoonEnd.ShowUpDown = true;
            NoonEnd.Size = new Size(61, 23);
            NoonEnd.TabIndex = 17;
            NoonEnd.Value = new DateTime(2023, 6, 11, 17, 54, 0, 0);
            NoonEnd.KeyPress += NoonEnd_KeyPress;
            // 
            // NoonBgn
            // 
            NoonBgn.CustomFormat = "HH:00";
            NoonBgn.Enabled = false;
            NoonBgn.Format = DateTimePickerFormat.Custom;
            NoonBgn.Location = new Point(140, 89);
            NoonBgn.Name = "NoonBgn";
            NoonBgn.ShowUpDown = true;
            NoonBgn.Size = new Size(61, 23);
            NoonBgn.TabIndex = 16;
            NoonBgn.Value = new DateTime(2023, 6, 11, 10, 54, 0, 0);
            NoonBgn.KeyPress += NoonBgn_KeyPress;
            // 
            // MorningEnd
            // 
            MorningEnd.CustomFormat = "HH:00";
            MorningEnd.Format = DateTimePickerFormat.Custom;
            MorningEnd.Location = new Point(308, 55);
            MorningEnd.Name = "MorningEnd";
            MorningEnd.ShowUpDown = true;
            MorningEnd.Size = new Size(61, 23);
            MorningEnd.TabIndex = 15;
            MorningEnd.Value = new DateTime(2023, 6, 11, 10, 54, 0, 0);
            MorningEnd.KeyPress += MorningEnd_KeyPress;
            // 
            // MorningBgn
            // 
            MorningBgn.CustomFormat = "HH:00";
            MorningBgn.Enabled = false;
            MorningBgn.Format = DateTimePickerFormat.Custom;
            MorningBgn.Location = new Point(140, 56);
            MorningBgn.Name = "MorningBgn";
            MorningBgn.ShowUpDown = true;
            MorningBgn.Size = new Size(61, 23);
            MorningBgn.TabIndex = 14;
            MorningBgn.Value = new DateTime(2023, 6, 11, 5, 0, 0, 0);
            MorningBgn.KeyPress += MorningBgn_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(102, 156);
            label7.Name = "label7";
            label7.Size = new Size(32, 17);
            label7.TabIndex = 13;
            label7.Text = "夜晚";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(102, 123);
            label6.Name = "label6";
            label6.Size = new Size(32, 17);
            label6.TabIndex = 12;
            label6.Text = "落日";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(102, 90);
            label5.Name = "label5";
            label5.Size = new Size(32, 17);
            label5.TabIndex = 11;
            label5.Text = "中午";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(102, 56);
            label4.Name = "label4";
            label4.Size = new Size(32, 17);
            label4.TabIndex = 10;
            label4.Text = "日出";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(207, 60);
            label8.Name = "label8";
            label8.Size = new Size(95, 17);
            label8.TabIndex = 22;
            label8.Text = "——————>";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(207, 90);
            label9.Name = "label9";
            label9.Size = new Size(95, 17);
            label9.TabIndex = 23;
            label9.Text = "——————>";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(207, 123);
            label10.Name = "label10";
            label10.Size = new Size(95, 17);
            label10.TabIndex = 24;
            label10.Text = "——————>";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(207, 157);
            label11.Name = "label11";
            label11.Size = new Size(95, 17);
            label11.TabIndex = 25;
            label11.Text = "——————>";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 382);
            Controls.Add(TimeSetPanel);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(txtPath);
            Controls.Add(button2);
            Controls.Add(TextTimeLabel);
            Margin = new Padding(2, 3, 2, 3);
            MaximumSize = new Size(712, 421);
            MinimumSize = new Size(712, 421);
            Name = "FrmMain";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "壁纸";
            WindowState = FormWindowState.Minimized;
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            SizeChanged += FrmMain_SizeChanged;
            contextMenuStrip1.ResumeLayout(false);
            TimeSetPanel.ResumeLayout(false);
            TimeSetPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)timeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label TextTimeLabel;
        private FolderBrowserDialog folderBrowserDialog;
        private Button button2;
        private TextBox txtPath;
        private Button button3;
        private Label label1;
        private Button button4;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem exitMenuItem;
        private ToolStripMenuItem hideMenuItem;
        private ToolStripMenuItem showMenuItem;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label5;
        public Panel TimeSetPanel;
        private BindingSource timeBindingSource;
        private DateTimePicker MorningBgn;
        private DateTimePicker MorningEnd;
        private DateTimePicker NoonEnd;
        private DateTimePicker NoonBgn;
        private DateTimePicker NightEnd;
        private DateTimePicker NightBgn;
        private DateTimePicker AfternoonEnd;
        private DateTimePicker AfternoonBgn;
        private Label label8;
        private Label label11;
        private Label label10;
        private Label label9;
    }
}
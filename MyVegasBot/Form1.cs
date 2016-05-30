using System;
using System.Drawing;
using System.Windows.Forms;
using MyVegasBot.Slots.Excalibur;
using System.Threading;
using MyVegasBot.Properties;
using AutoHotkey.Interop;

namespace MyVegasBot
{
    public partial class Form1 : Form
    {
        public string browser { get; set; }
        private string Game { get; set; }
        public int autoSpin { get; set; }
        private Thread t { get; set; }
        public bool testMode { get; set; }
        public static Form1 _Form1;
        //autohotkey initializer
        AutoHotkeyEngine ahk = new AutoHotkeyEngine();

        public Form1()
        {
            InitializeComponent();
            //Defualt browser is chrome.
            browser = chromeToolStripMenuItem.Text;
            //Defualt Game is Excalibur.
            Game = excaliburToolStripMenuItem.Text;
            //Defualt stop button state
            Stop.Enabled = false;
            //Instance of form
            _Form1 = this;
            //testmode
            testMode = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void Start_Button(object sender, EventArgs e)
        {
            InitializeGame begin = new InitializeGame();
            if (autoSpin == 0)
            {
                Log("Please set auto-spin value.");
            }
            else
            {
                if (Game == "Excalibur")
                {
                    Excalibur ex = new Excalibur();
                    t = new Thread(ex.Start);
                    Log(string.Format("Starting {0}...", Game));
                    AutoSpin.Enabled = false;
                    Start.Enabled = false;
                    Stop.Enabled = true;
                    t.Start();
                    while (!t.IsAlive) ;
                    Thread.Sleep(1);
                    if (hideOnStartToolStripMenuItem.Checked) Hide();
                }
                //else if(Game == ???)
            }
        }

        private void Stop_Button(object sender, EventArgs e)
        {
            if (t.IsAlive == true)
            {
                Log(string.Format("{0} stopped...", Game));
                t.Abort();
                AutoSpin.Enabled = true;
                Start.Enabled = true;
                Stop.Enabled = false;
            }
        }
        #region browsers
        /// <summary>
        /// Sets browser to Chrome.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chromeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            browser = chromeToolStripMenuItem.Text;
            chromeToolStripMenuItem.CheckState = CheckState.Checked;
            firefoxToolStripMenuItem.CheckState = CheckState.Unchecked;
            internetExplorerToolStripMenuItem.CheckState = CheckState.Unchecked;
        }
        /// <summary>
        /// Sets browser to firefox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void firefoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            browser = firefoxToolStripMenuItem.Text;
            firefoxToolStripMenuItem.CheckState = CheckState.Checked;
            chromeToolStripMenuItem.CheckState = CheckState.Unchecked;
            internetExplorerToolStripMenuItem.CheckState = CheckState.Unchecked;
        }
        /// <summary>
        /// Sets browser to Internet Explorer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void internetExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            browser = "IEXPLORE";
            internetExplorerToolStripMenuItem.CheckState = CheckState.Checked;
            firefoxToolStripMenuItem.CheckState = CheckState.Unchecked;
            chromeToolStripMenuItem.CheckState = CheckState.Unchecked;
        }
        #endregion

        #region Menu Stuff
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        
        private void excaliburToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game = excaliburToolStripMenuItem.Text;
            excaliburToolStripMenuItem.CheckState = CheckState.Checked;
            slotsToolStripMenuItem.CheckState = CheckState.Checked;
        }
        
        private void slotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyVegas.Icon = Resources.VslotsLogo;
            Icon = Resources.VslotsLogo;
        }

        private void blackJackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyVegas.Icon = Resources.VblackjackLogo;
            Icon = Resources.VblackjackLogo;
        }

        private void hideOnStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
                
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }
        #endregion
        private void AutoSpin_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] tokens = AutoSpin.SelectedItem.ToString().Split(' ');
            autoSpin = Convert.ToInt32(tokens.GetValue(tokens.Length - 1));
            Log(string.Format("Auto spin set to {0}...", autoSpin));
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }
        public static void MoveCursorAndClick(int x, int y, int xOff, int yOff)
        {
            // Set the Current cursor, move the cursor's Position
            if (x != 0 && y != 0)
            {
                Cursor.Position = new Point(x + xOff, y + yOff);
                Thread.Sleep(500);
            }
        }
        private void MyVegas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }
        public void Log(string s)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(Log), new object[] { s });
                return;
            }

            if (s.Substring(0,1) != "/")
            {
                s += Environment.NewLine;
            }
            else
            {
                s = s.Substring(1);
            }
            textBox1.AppendText(s);
            if(!Visible)
                MyVegas.ShowBalloonTip(1000, "", s, ToolTipIcon.None);
        }

        private void showPicturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (showPicturesToolStripMenuItem.CheckState == CheckState.Checked)
            {
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                ClientSize = new Size(ClientSize.Width + pictureBox1.Bounds.Width, ClientSize.Height);
            }
            else if (showPicturesToolStripMenuItem.CheckState == CheckState.Unchecked)
            {
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                ClientSize = new Size(ClientSize.Width - pictureBox1.Bounds.Width, ClientSize.Height);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void testModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (testModeToolStripMenuItem.CheckState == CheckState.Checked)
                testMode = true;
            else if(testModeToolStripMenuItem.CheckState == CheckState.Unchecked)
                testMode = false;

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
using System;
using System.Drawing;
using System.Windows.Forms;
using MyVegasBot.Slots.Excalibur;
using System.Threading;
using MyVegasBot.Properties;

namespace MyVegasBot
{
    public partial class Form1 : Form
    {
        public string browser { get; set; }
        private string Game { get; set; }
        public int autoSpin { get; set; }
        public bool hide { get; set; }
        public Thread t { get; set; }
        public static Form1 _Form1;
        public Form1()
        {
            InitializeComponent();
            //Defualt browser is chrome.
            this.browser = chromeToolStripMenuItem.Text;
            //Defualt Game is Excalibur.
            this.Game = excaliburToolStripMenuItem.Text;
            //Default hide on start value
            this.hide = false;
            //Defualt stop button state
            this.Stop.Enabled = false;
            //Instance of form
            _Form1 = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void Start_Button(object sender, EventArgs e)
        {
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
                    this.AutoSpin.Enabled = false;
                    this.Start.Enabled = false;
                    this.Stop.Enabled = true;
                    t.Start();
                    while (!t.IsAlive) ;
                    Thread.Sleep(1);
                    if (hide) Hide();
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
                this.AutoSpin.Enabled = true;
                this.Start.Enabled = true;
                this.Stop.Enabled = false;
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
            this.browser = chromeToolStripMenuItem.Text;
            this.chromeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.firefoxToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.internetExplorerToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
        }
        /// <summary>
        /// Sets browser to firefox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void firefoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.browser = firefoxToolStripMenuItem.Text;
            this.firefoxToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chromeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.internetExplorerToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
        }
        /// <summary>
        /// Sets browser to Internet Explorer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void internetExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.browser = "IEXPLORE";
            this.internetExplorerToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.firefoxToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.chromeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Unchecked;
        }
        #endregion

        #region Menu Stuff
        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t.Abort();
            this.Close();
        }
        
        private void excaliburToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Game = excaliburToolStripMenuItem.Text;
            this.excaliburToolStripMenuItem.CheckState = CheckState.Checked;
            this.slotsToolStripMenuItem.CheckState = CheckState.Checked;
        }
        
        private void slotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyVegas.Icon = Resources.VslotsLogo;
            this.Icon = Resources.VslotsLogo;
        }

        private void blackJackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyVegas.Icon = Resources.VblackjackLogo;
            this.Icon = Resources.VblackjackLogo;
        }

        private void hideOnStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(hideOnStartToolStripMenuItem.Checked == true)
            {
                hide = true;
                hideOnStartToolStripMenuItem.CheckState = CheckState.Unchecked;
            }
            else
            {
                hide = false;
                hideOnStartToolStripMenuItem.CheckState = CheckState.Checked;
            }     
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
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
                this.Hide();
            }
        }
        public void MoveCursorAndClick(int x, int y)
        {
            // Set the Current cursor, move the cursor's Position
            Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(x, y);
            Thread.Sleep(500);
            DllStuff.LeftClick();
        }
        private void MyVegas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
        public void Log(string s)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(Log), new object[] { s });
                return;
            }
            textBox1.AppendText(s + Environment.NewLine);
        }
    }
}
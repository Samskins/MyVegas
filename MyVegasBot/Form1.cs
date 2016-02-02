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
        public bool testMode { get; set; }
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
            //testmode
            testMode = false;
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
            Environment.Exit(0);
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

            if (s.Substring(0,1) != "/")
            {
                s += Environment.NewLine;
            }
            else
            {
                s = s.Substring(1);
            }
            textBox1.AppendText(s);
        }

        private void showPicturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(showPicturesToolStripMenuItem.CheckState == CheckState.Checked)
            {
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                this.ClientSize = new System.Drawing.Size(ClientSize.Width + pictureBox1.Bounds.Width, 300);
            }
            else if(showPicturesToolStripMenuItem.CheckState == CheckState.Unchecked)
            {
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                this.ClientSize = new System.Drawing.Size(ClientSize.Width - pictureBox1.Bounds.Width, 300);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            using (Form1 newForm = new Form1())
            {
                newForm.ShowDialog();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (Form1 newForm = new Form1())
            {
                newForm.ShowDialog();
            }
        }

        private void testModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (testModeToolStripMenuItem.CheckState == CheckState.Checked)
                testMode = true;
            else if(testModeToolStripMenuItem.CheckState == CheckState.Unchecked)
                testMode = false;

        }
    }
}
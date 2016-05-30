using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoHotkey.Interop;
using System.Windows.Forms;

namespace MyVegasBot
{
    class InitializeGame
    {
        AutoHotkeyEngine ahk = new AutoHotkeyEngine();

        public InitializeGame()
        {
            if (Properties.Settings.Default.firstTime)
            {
                Process.Start("https://apps.facebook.com/playmyvegas/");
                MessageBox.Show(string.Format("Please sign in and start {0}. \nONLY CHOOSE THE BET!", Form1._Form1.browser), "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                SnippingTool.Snip();
                Properties.Settings.Default.firstTime = false;
            }
        }
    }
}

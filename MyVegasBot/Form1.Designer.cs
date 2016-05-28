namespace MyVegasBot
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AutoSpin = new System.Windows.Forms.ComboBox();
            this.Start = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.switchGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slotsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excaliburToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.blackJackToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideOnStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPicturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chromeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firefoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internetExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excaliburToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackJackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Stop = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MyVegas = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AutoSpin
            // 
            this.AutoSpin.AllowDrop = true;
            this.AutoSpin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AutoSpin.FormattingEnabled = true;
            this.AutoSpin.Items.AddRange(new object[] {
            "Auto Spin - 10",
            "Auto Spin - 25",
            "Auto Spin - 50",
            "Auto Spin - 100",
            "Auto Spin - 200",
            "Auto Spin - 500"});
            this.AutoSpin.Location = new System.Drawing.Point(32, 83);
            this.AutoSpin.Margin = new System.Windows.Forms.Padding(2);
            this.AutoSpin.Name = "AutoSpin";
            this.AutoSpin.Size = new System.Drawing.Size(144, 21);
            this.AutoSpin.TabIndex = 3;
            this.AutoSpin.SelectedIndexChanged += new System.EventHandler(this.AutoSpin_SelectedIndexChanged);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(32, 41);
            this.Start.Margin = new System.Windows.Forms.Padding(2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(56, 19);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Button);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(210, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // switchGamesToolStripMenuItem
            // 
            this.switchGamesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slotsToolStripMenuItem1,
            this.blackJackToolStripMenuItem1});
            this.switchGamesToolStripMenuItem.Name = "switchGamesToolStripMenuItem";
            this.switchGamesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.switchGamesToolStripMenuItem.Text = "Switch Games";
            // 
            // slotsToolStripMenuItem1
            // 
            this.slotsToolStripMenuItem1.CheckOnClick = true;
            this.slotsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excaliburToolStripMenuItem1});
            this.slotsToolStripMenuItem1.Name = "slotsToolStripMenuItem1";
            this.slotsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.slotsToolStripMenuItem1.Text = "Slots";
            this.slotsToolStripMenuItem1.Click += new System.EventHandler(this.slotsToolStripMenuItem_Click);
            // 
            // excaliburToolStripMenuItem1
            // 
            this.excaliburToolStripMenuItem1.Name = "excaliburToolStripMenuItem1";
            this.excaliburToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.excaliburToolStripMenuItem1.Text = "Excalibur";
            this.excaliburToolStripMenuItem1.Click += new System.EventHandler(this.excaliburToolStripMenuItem_Click);
            // 
            // blackJackToolStripMenuItem1
            // 
            this.blackJackToolStripMenuItem1.CheckOnClick = true;
            this.blackJackToolStripMenuItem1.Name = "blackJackToolStripMenuItem1";
            this.blackJackToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.blackJackToolStripMenuItem1.Text = "BlackJack";
            this.blackJackToolStripMenuItem1.Click += new System.EventHandler(this.blackJackToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.switchGamesToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menu";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(12, 20);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // testModeToolStripMenuItem
            // 
            this.testModeToolStripMenuItem.CheckOnClick = true;
            this.testModeToolStripMenuItem.Name = "testModeToolStripMenuItem";
            this.testModeToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.testModeToolStripMenuItem.Text = "Test Mode";
            this.testModeToolStripMenuItem.Click += new System.EventHandler(this.testModeToolStripMenuItem_Click);
            // 
            // hideOnStartToolStripMenuItem
            // 
            this.hideOnStartToolStripMenuItem.CheckOnClick = true;
            this.hideOnStartToolStripMenuItem.Name = "hideOnStartToolStripMenuItem";
            this.hideOnStartToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.hideOnStartToolStripMenuItem.Text = "Hide on start";
            this.hideOnStartToolStripMenuItem.Click += new System.EventHandler(this.hideOnStartToolStripMenuItem_Click);
            // 
            // showPicturesToolStripMenuItem
            // 
            this.showPicturesToolStripMenuItem.CheckOnClick = true;
            this.showPicturesToolStripMenuItem.Name = "showPicturesToolStripMenuItem";
            this.showPicturesToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.showPicturesToolStripMenuItem.Text = "Show pictures";
            this.showPicturesToolStripMenuItem.Click += new System.EventHandler(this.showPicturesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // browserToolStripMenuItem
            // 
            this.browserToolStripMenuItem.Name = "browserToolStripMenuItem";
            this.browserToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.browserToolStripMenuItem.Text = "Browser";
            // 
            // chromeToolStripMenuItem
            // 
            this.chromeToolStripMenuItem.Checked = true;
            this.chromeToolStripMenuItem.CheckOnClick = true;
            this.chromeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chromeToolStripMenuItem.Name = "chromeToolStripMenuItem";
            this.chromeToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.chromeToolStripMenuItem.Text = "Chrome";
            this.chromeToolStripMenuItem.ToolTipText = "Set Chrome as your browser.";
            this.chromeToolStripMenuItem.Click += new System.EventHandler(this.chromeToolStripMenuItem_Click);
            // 
            // firefoxToolStripMenuItem
            // 
            this.firefoxToolStripMenuItem.CheckOnClick = true;
            this.firefoxToolStripMenuItem.Name = "firefoxToolStripMenuItem";
            this.firefoxToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.firefoxToolStripMenuItem.Text = "Firefox";
            this.firefoxToolStripMenuItem.ToolTipText = "Set Firefox as your browser.";
            this.firefoxToolStripMenuItem.Click += new System.EventHandler(this.firefoxToolStripMenuItem_Click);
            // 
            // internetExplorerToolStripMenuItem
            // 
            this.internetExplorerToolStripMenuItem.CheckOnClick = true;
            this.internetExplorerToolStripMenuItem.Name = "internetExplorerToolStripMenuItem";
            this.internetExplorerToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.internetExplorerToolStripMenuItem.Text = "Internet Explorer";
            this.internetExplorerToolStripMenuItem.ToolTipText = "Set Internet Explorer as your browser.";
            this.internetExplorerToolStripMenuItem.Click += new System.EventHandler(this.internetExplorerToolStripMenuItem_Click);
            // 
            // gameTypeToolStripMenuItem
            // 
            this.gameTypeToolStripMenuItem.Name = "gameTypeToolStripMenuItem";
            this.gameTypeToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.gameTypeToolStripMenuItem.Text = "Game Type";
            // 
            // slotsToolStripMenuItem
            // 
            this.slotsToolStripMenuItem.Checked = true;
            this.slotsToolStripMenuItem.CheckOnClick = true;
            this.slotsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.slotsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excaliburToolStripMenuItem});
            this.slotsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("slotsToolStripMenuItem.Image")));
            this.slotsToolStripMenuItem.Name = "slotsToolStripMenuItem";
            this.slotsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.slotsToolStripMenuItem.Text = "Slots";
            this.slotsToolStripMenuItem.Click += new System.EventHandler(this.slotsToolStripMenuItem_Click);
            // 
            // excaliburToolStripMenuItem
            // 
            this.excaliburToolStripMenuItem.Checked = true;
            this.excaliburToolStripMenuItem.CheckOnClick = true;
            this.excaliburToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.excaliburToolStripMenuItem.Image = global::MyVegasBot.Properties.Resources.excalibur;
            this.excaliburToolStripMenuItem.Name = "excaliburToolStripMenuItem";
            this.excaliburToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.excaliburToolStripMenuItem.Text = "Excalibur";
            this.excaliburToolStripMenuItem.Click += new System.EventHandler(this.excaliburToolStripMenuItem_Click);
            // 
            // blackJackToolStripMenuItem
            // 
            this.blackJackToolStripMenuItem.CheckOnClick = true;
            this.blackJackToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("blackJackToolStripMenuItem.Image")));
            this.blackJackToolStripMenuItem.Name = "blackJackToolStripMenuItem";
            this.blackJackToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.blackJackToolStripMenuItem.Text = "BlackJack";
            this.blackJackToolStripMenuItem.Click += new System.EventHandler(this.blackJackToolStripMenuItem_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(118, 41);
            this.Stop.Margin = new System.Windows.Forms.Padding(2);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(56, 19);
            this.Stop.TabIndex = 1;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Button);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox1.Location = new System.Drawing.Point(9, 124);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(194, 122);
            this.textBox1.TabIndex = 4;
            // 
            // MyVegas
            // 
            this.MyVegas.Icon = ((System.Drawing.Icon)(resources.GetObject("MyVegas.Icon")));
            this.MyVegas.Text = "MyVegas Bot";
            this.MyVegas.Visible = true;
            this.MyVegas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MyVegas_MouseDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(234, 136);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 110);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Location = new System.Drawing.Point(234, 25);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(0, 94);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 255);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AutoSpin);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "MyVegas Bot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excaliburToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackJackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chromeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firefoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internetExplorerToolStripMenuItem;
        private System.Windows.Forms.Button Stop;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox AutoSpin;
        private System.Windows.Forms.NotifyIcon MyVegas;
        private System.Windows.Forms.ToolStripMenuItem switchGamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slotsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem excaliburToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem blackJackToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hideOnStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showPicturesToolStripMenuItem;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem testModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    }
}


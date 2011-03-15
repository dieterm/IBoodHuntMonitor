namespace IBoodHuntMonitor
{
    partial class Main
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
            if (disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tmrCheckIbood = new System.Windows.Forms.Timer(this.components);
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.mnuNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mniDebugWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNotifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrCheckIbood
            // 
            this.tmrCheckIbood.Enabled = true;
            this.tmrCheckIbood.Interval = 10000;
            this.tmrCheckIbood.Tick += new System.EventHandler(this.tmrCheckIbood_Tick);
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtOutput.Location = new System.Drawing.Point(0, 146);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(649, 116);
            this.txtOutput.TabIndex = 0;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 0);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(649, 146);
            this.webBrowser.TabIndex = 1;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.mnuNotifyIcon;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "IboodHunt Monitor";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // mnuNotifyIcon
            // 
            this.mnuNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniDebugWindow,
            this.exitToolStripMenuItem});
            this.mnuNotifyIcon.Name = "mnuNotifyIcon";
            this.mnuNotifyIcon.Size = new System.Drawing.Size(157, 48);
            // 
            // mniDebugWindow
            // 
            this.mniDebugWindow.Name = "mniDebugWindow";
            this.mniDebugWindow.Size = new System.Drawing.Size(156, 22);
            this.mniDebugWindow.Text = "Debug Window";
            this.mniDebugWindow.Click += new System.EventHandler(this.mniDebugWindow_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 262);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.txtOutput);
            this.Name = "Main";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ibood";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.mnuNotifyIcon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrCheckIbood;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip mnuNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniDebugWindow;
    }
}


namespace Webbrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tstpToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbGoBack = new System.Windows.Forms.ToolStripButton();
            this.tsbNext = new System.Windows.Forms.ToolStripButton();
            this.tsbHome = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbStop = new System.Windows.Forms.ToolStripButton();
            this.tsbStart = new System.Windows.Forms.ToolStripButton();
            this.txtLink = new System.Windows.Forms.ToolStripTextBox();
            this.wbWeb = new System.Windows.Forms.WebBrowser();
            this.tstpToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tstpToolStrip
            // 
            this.tstpToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGoBack,
            this.tsbNext,
            this.tsbHome,
            this.tsbRefresh,
            this.tsbStop,
            this.tsbStart,
            this.txtLink});
            this.tstpToolStrip.Location = new System.Drawing.Point(0, 0);
            this.tstpToolStrip.Name = "tstpToolStrip";
            this.tstpToolStrip.Size = new System.Drawing.Size(725, 25);
            this.tstpToolStrip.TabIndex = 0;
            this.tstpToolStrip.Text = "toolStrip1";
            this.tstpToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tstpToolStrip_ItemClicked);
            // 
            // tsbGoBack
            // 
            this.tsbGoBack.AutoSize = false;
            this.tsbGoBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGoBack.Image = ((System.Drawing.Image)(resources.GetObject("tsbGoBack.Image")));
            this.tsbGoBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGoBack.Name = "tsbGoBack";
            this.tsbGoBack.Size = new System.Drawing.Size(23, 22);
            this.tsbGoBack.Text = "GoBack";
            this.tsbGoBack.Click += new System.EventHandler(this.tsbGoBack_Click);
            // 
            // tsbNext
            // 
            this.tsbNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNext.Image = ((System.Drawing.Image)(resources.GetObject("tsbNext.Image")));
            this.tsbNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNext.Name = "tsbNext";
            this.tsbNext.Size = new System.Drawing.Size(23, 22);
            this.tsbNext.Text = "toolStripButton2";
            this.tsbNext.Click += new System.EventHandler(this.tsbNext_Click);
            // 
            // tsbHome
            // 
            this.tsbHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHome.Image = ((System.Drawing.Image)(resources.GetObject("tsbHome.Image")));
            this.tsbHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHome.Name = "tsbHome";
            this.tsbHome.Size = new System.Drawing.Size(23, 22);
            this.tsbHome.Text = "toolStripButton3";
            this.tsbHome.Click += new System.EventHandler(this.tsbHome_Click);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsbRefresh.Text = "toolStripButton4";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // tsbStop
            // 
            this.tsbStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStop.Image = ((System.Drawing.Image)(resources.GetObject("tsbStop.Image")));
            this.tsbStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStop.Name = "tsbStop";
            this.tsbStop.Size = new System.Drawing.Size(23, 22);
            this.tsbStop.Text = "toolStripButton5";
            this.tsbStop.Click += new System.EventHandler(this.tsbStop_Click);
            // 
            // tsbStart
            // 
            this.tsbStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStart.Image = ((System.Drawing.Image)(resources.GetObject("tsbStart.Image")));
            this.tsbStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStart.Margin = new System.Windows.Forms.Padding(0);
            this.tsbStart.Name = "tsbStart";
            this.tsbStart.Size = new System.Drawing.Size(23, 25);
            this.tsbStart.Text = "toolStripButton6";
            this.tsbStart.Click += new System.EventHandler(this.tsbStart_Click);
            // 
            // txtLink
            // 
            this.txtLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(200, 25);
            this.txtLink.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLink_KeyDown);
            this.txtLink.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLink_KeyPress);
            this.txtLink.Click += new System.EventHandler(this.txtLink_Click);
            // 
            // wbWeb
            // 
            this.wbWeb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbWeb.Location = new System.Drawing.Point(0, 25);
            this.wbWeb.Margin = new System.Windows.Forms.Padding(0);
            this.wbWeb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbWeb.Name = "wbWeb";
            this.wbWeb.Size = new System.Drawing.Size(725, 400);
            this.wbWeb.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 425);
            this.Controls.Add(this.wbWeb);
            this.Controls.Add(this.tstpToolStrip);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.tstpToolStrip.ResumeLayout(false);
            this.tstpToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tstpToolStrip;
        private System.Windows.Forms.ToolStripButton tsbGoBack;
        private System.Windows.Forms.ToolStripButton tsbNext;
        private System.Windows.Forms.ToolStripButton tsbHome;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripButton tsbStop;
        private System.Windows.Forms.ToolStripButton tsbStart;
        private System.Windows.Forms.ToolStripTextBox txtLink;
        private System.Windows.Forms.WebBrowser wbWeb;
    }
}


namespace List_View
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.liv = new System.Windows.Forms.ListView();
            this.imglst = new System.Windows.Forms.ImageList(this.components);
            this.btnlarge = new System.Windows.Forms.Button();
            this.btnsmall = new System.Windows.Forms.Button();
            this.btnlist = new System.Windows.Forms.Button();
            this.btndetail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // liv
            // 
            this.liv.AutoArrange = false;
            this.liv.CheckBoxes = true;
            this.liv.FullRowSelect = true;
            this.liv.GridLines = true;
            this.liv.LabelEdit = true;
            this.liv.LargeImageList = this.imglst;
            this.liv.Location = new System.Drawing.Point(13, 27);
            this.liv.Name = "liv";
            this.liv.Size = new System.Drawing.Size(666, 311);
            this.liv.SmallImageList = this.imglst;
            this.liv.TabIndex = 0;
            this.liv.UseCompatibleStateImageBehavior = false;
            this.liv.SelectedIndexChanged += new System.EventHandler(this.liv_SelectedIndexChanged);
            this.liv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.liv_KeyPress);
            this.liv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.liv_MouseClick);
            this.liv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.liv_MouseDoubleClick);
            // 
            // imglst
            // 
            this.imglst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglst.ImageStream")));
            this.imglst.TransparentColor = System.Drawing.Color.Transparent;
            this.imglst.Images.SetKeyName(0, "cloud-computing (1).png");
            this.imglst.Images.SetKeyName(1, "computer-screen.png");
            // 
            // btnlarge
            // 
            this.btnlarge.Location = new System.Drawing.Point(701, 10);
            this.btnlarge.Name = "btnlarge";
            this.btnlarge.Size = new System.Drawing.Size(80, 30);
            this.btnlarge.TabIndex = 1;
            this.btnlarge.Text = "Large";
            this.btnlarge.UseVisualStyleBackColor = true;
            this.btnlarge.Click += new System.EventHandler(this.btnlarge_Click);
            // 
            // btnsmall
            // 
            this.btnsmall.Location = new System.Drawing.Point(701, 58);
            this.btnsmall.Name = "btnsmall";
            this.btnsmall.Size = new System.Drawing.Size(80, 30);
            this.btnsmall.TabIndex = 2;
            this.btnsmall.Text = "Small";
            this.btnsmall.UseVisualStyleBackColor = true;
            this.btnsmall.Click += new System.EventHandler(this.btnsmall_Click);
            // 
            // btnlist
            // 
            this.btnlist.Location = new System.Drawing.Point(701, 106);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(80, 30);
            this.btnlist.TabIndex = 3;
            this.btnlist.Text = "List";
            this.btnlist.UseVisualStyleBackColor = true;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click);
            // 
            // btndetail
            // 
            this.btndetail.Location = new System.Drawing.Point(701, 152);
            this.btndetail.Name = "btndetail";
            this.btndetail.Size = new System.Drawing.Size(80, 30);
            this.btndetail.TabIndex = 4;
            this.btndetail.Text = "Detail";
            this.btndetail.UseVisualStyleBackColor = true;
            this.btndetail.Click += new System.EventHandler(this.btndetail_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 345);
            this.Controls.Add(this.btndetail);
            this.Controls.Add(this.btnlist);
            this.Controls.Add(this.btnsmall);
            this.Controls.Add(this.btnlarge);
            this.Controls.Add(this.liv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView liv;
        private System.Windows.Forms.Button btnlarge;
        private System.Windows.Forms.Button btnsmall;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.Button btndetail;
        private System.Windows.Forms.ImageList imglst;
    }
}


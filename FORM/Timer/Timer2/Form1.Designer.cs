namespace Timer2
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
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.grb2 = new System.Windows.Forms.GroupBox();
            this.btnback = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.grb1.SuspendLayout();
            this.grb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.btnback);
            this.grb1.Location = new System.Drawing.Point(12, 12);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(277, 301);
            this.grb1.TabIndex = 0;
            this.grb1.TabStop = false;
            this.grb1.Text = "G1";
            this.grb1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grb2
            // 
            this.grb2.Controls.Add(this.button1);
            this.grb2.Location = new System.Drawing.Point(295, 12);
            this.grb2.Name = "grb2";
            this.grb2.Size = new System.Drawing.Size(277, 301);
            this.grb2.TabIndex = 1;
            this.grb2.TabStop = false;
            this.grb2.Text = "G2";
            this.grb2.Visible = false;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(21, 103);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(48, 95);
            this.btnback.TabIndex = 0;
            this.btnback.Text = "<<";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.button1_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 95);
            this.button1.TabIndex = 1;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 325);
            this.Controls.Add(this.grb2);
            this.Controls.Add(this.grb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grb1.ResumeLayout(false);
            this.grb2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.GroupBox grb2;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button button1;
    }
}


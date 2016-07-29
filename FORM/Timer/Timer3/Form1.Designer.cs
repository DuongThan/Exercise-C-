namespace Timer3
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
            this.button1 = new System.Windows.Forms.Button();
            this.grb2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.grb1.SuspendLayout();
            this.grb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.button1);
            this.grb1.Location = new System.Drawing.Point(10, 14);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(241, 268);
            this.grb1.TabIndex = 0;
            this.grb1.TabStop = false;
            this.grb1.Text = "G1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 96);
            this.button1.TabIndex = 0;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grb2
            // 
            this.grb2.Controls.Add(this.button2);
            this.grb2.Location = new System.Drawing.Point(270, 14);
            this.grb2.Name = "grb2";
            this.grb2.Size = new System.Drawing.Size(241, 268);
            this.grb2.TabIndex = 1;
            this.grb2.TabStop = false;
            this.grb2.Text = "G2";
            this.grb2.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 96);
            this.button2.TabIndex = 1;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Timer2
            // 
            this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 295);
            this.Controls.Add(this.grb2);
            this.Controls.Add(this.grb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grb1.ResumeLayout(false);
            this.grb2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grb2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Timer Timer2;
    }
}


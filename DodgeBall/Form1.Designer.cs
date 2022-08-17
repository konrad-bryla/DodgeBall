namespace DodgeBall
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.startToolStrip = new System.Windows.Forms.ToolStripLabel();
            this.tsScore = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tsHighScore = new System.Windows.Forms.ToolStripLabel();
            this.tsStart = new System.Windows.Forms.ToolStripButton();
            this.tsPause = new System.Windows.Forms.ToolStripButton();
            this.tsExit = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStrip,
            this.tsScore,
            this.toolStripLabel2,
            this.tsHighScore,
            this.tsStart,
            this.tsPause,
            this.tsExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 425);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // startToolStrip
            // 
            this.startToolStrip.Name = "startToolStrip";
            this.startToolStrip.Size = new System.Drawing.Size(39, 22);
            this.startToolStrip.Text = "Score:";
            // 
            // tsScore
            // 
            this.tsScore.Name = "tsScore";
            this.tsScore.Size = new System.Drawing.Size(13, 22);
            this.tsScore.Text = "0";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(67, 22);
            this.toolStripLabel2.Text = "Highscore: ";
            // 
            // tsHighScore
            // 
            this.tsHighScore.Name = "tsHighScore";
            this.tsHighScore.Size = new System.Drawing.Size(13, 22);
            this.tsHighScore.Text = "0";
            // 
            // tsStart
            // 
            this.tsStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsStart.Image = ((System.Drawing.Image)(resources.GetObject("tsStart.Image")));
            this.tsStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsStart.Name = "tsStart";
            this.tsStart.Size = new System.Drawing.Size(38, 22);
            this.tsStart.Text = "Start!";
            this.tsStart.Click += new System.EventHandler(this.TsStart_Click);
            // 
            // tsPause
            // 
            this.tsPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsPause.Image = ((System.Drawing.Image)(resources.GetObject("tsPause.Image")));
            this.tsPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPause.Name = "tsPause";
            this.tsPause.Size = new System.Drawing.Size(45, 22);
            this.tsPause.Text = "Pause!";
            this.tsPause.Click += new System.EventHandler(this.TsPause_Click);
            // 
            // tsExit
            // 
            this.tsExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsExit.Image = ((System.Drawing.Image)(resources.GetObject("tsExit.Image")));
            this.tsExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsExit.Name = "tsExit";
            this.tsExit.Size = new System.Drawing.Size(33, 22);
            this.tsExit.Text = "Exit!";
            this.tsExit.Click += new System.EventHandler(this.TsExit_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "DodgeBall";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripLabel startToolStrip;
        private System.Windows.Forms.ToolStripLabel tsScore;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel tsHighScore;
        private System.Windows.Forms.ToolStripButton tsStart;
        private System.Windows.Forms.ToolStripButton tsPause;
        private System.Windows.Forms.ToolStripButton tsExit;
    }
}


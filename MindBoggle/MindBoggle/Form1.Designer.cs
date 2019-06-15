namespace MindBoggle
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_05 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_10 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_15 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Info = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSSL_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.tm_Time = new System.Windows.Forms.Timer(this.components);
            this.pnl_Control = new System.Windows.Forms.Panel();
            this.TSMI_Data = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(520, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.TSMI_Data,
            this.TSMI_Exit});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_05,
            this.TSMI_10,
            this.TSMI_15});
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.playToolStripMenuItem.Text = "Play";
            // 
            // TSMI_05
            // 
            this.TSMI_05.Name = "TSMI_05";
            this.TSMI_05.Size = new System.Drawing.Size(109, 22);
            this.TSMI_05.Text = "5 x 5";
            this.TSMI_05.Click += new System.EventHandler(this.TSMI_05_Click);
            // 
            // TSMI_10
            // 
            this.TSMI_10.Name = "TSMI_10";
            this.TSMI_10.Size = new System.Drawing.Size(109, 22);
            this.TSMI_10.Text = "10 x 10";
            this.TSMI_10.Click += new System.EventHandler(this.TSMI_05_Click);
            // 
            // TSMI_15
            // 
            this.TSMI_15.Name = "TSMI_15";
            this.TSMI_15.Size = new System.Drawing.Size(109, 22);
            this.TSMI_15.Text = "15 x 15";
            this.TSMI_15.Click += new System.EventHandler(this.TSMI_05_Click);
            // 
            // TSMI_Exit
            // 
            this.TSMI_Exit.Name = "TSMI_Exit";
            this.TSMI_Exit.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Exit.Text = "Exit";
            this.TSMI_Exit.Click += new System.EventHandler(this.TSMI_Exit_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Info});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // TSMI_Info
            // 
            this.TSMI_Info.Name = "TSMI_Info";
            this.TSMI_Info.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Info.Text = "Info";
            this.TSMI_Info.Click += new System.EventHandler(this.TSMI_Info_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSL_Time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(520, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSSL_Time
            // 
            this.TSSL_Time.Name = "TSSL_Time";
            this.TSSL_Time.Size = new System.Drawing.Size(82, 17);
            this.TSSL_Time.Text = "Time: 00:00:00";
            // 
            // tm_Time
            // 
            this.tm_Time.Interval = 1000;
            this.tm_Time.Tick += new System.EventHandler(this.tm_Time_Tick);
            // 
            // pnl_Control
            // 
            this.pnl_Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Control.Location = new System.Drawing.Point(0, 24);
            this.pnl_Control.Name = "pnl_Control";
            this.pnl_Control.Size = new System.Drawing.Size(520, 520);
            this.pnl_Control.TabIndex = 2;
            // 
            // TSMI_Data
            // 
            this.TSMI_Data.Name = "TSMI_Data";
            this.TSMI_Data.Size = new System.Drawing.Size(152, 22);
            this.TSMI_Data.Text = "Data";
            this.TSMI_Data.Click += new System.EventHandler(this.TSMI_Data_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 566);
            this.Controls.Add(this.pnl_Control);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mind Boggle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_05;
        private System.Windows.Forms.ToolStripMenuItem TSMI_10;
        private System.Windows.Forms.ToolStripMenuItem TSMI_15;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Exit;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Info;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TSSL_Time;
        private System.Windows.Forms.Timer tm_Time;
        private System.Windows.Forms.Panel pnl_Control;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Data;



    }
}


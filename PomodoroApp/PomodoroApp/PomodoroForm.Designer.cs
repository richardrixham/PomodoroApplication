namespace PomodoroApp
{
    using System;
    using System.Windows.Forms;

    partial class PomodoroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PomodoroForm));
            this.StartButton = new System.Windows.Forms.Button();
            this.TimerDisplay = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MyNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.PauseButton = new System.Windows.Forms.Button();
            this.PomodoroStatus = new System.Windows.Forms.Label();
            this.lblSequence = new System.Windows.Forms.Label();
            this.lblToday = new System.Windows.Forms.Label();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 245);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(79, 36);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButtonClick);
            // 
            // TimerDisplay
            // 
            this.TimerDisplay.AutoSize = true;
            this.TimerDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(251)))), ((int)(((byte)(207)))));
            this.TimerDisplay.ContextMenuStrip = this.contextMenuStrip;
            this.TimerDisplay.Font = new System.Drawing.Font("LCD", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerDisplay.Location = new System.Drawing.Point(68, 94);
            this.TimerDisplay.Name = "TimerDisplay";
            this.TimerDisplay.Size = new System.Drawing.Size(93, 32);
            this.TimerDisplay.TabIndex = 1;
            this.TimerDisplay.Text = "00:00";
            this.TimerDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(149, 26);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.ConfigurationToolStripMenuItemClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 197);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MyNotifyIcon
            // 
            this.MyNotifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.MyNotifyIcon.BalloonTipText = "Double click the icon to restore the timer.";
            this.MyNotifyIcon.BalloonTipTitle = "Pomodoro";
            this.MyNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MyNotifyIcon.Icon")));
            this.MyNotifyIcon.Text = "Pomodoro Text";
            this.MyNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MyNotifyIconMouseDoubleClick);
            // 
            // PauseButton
            // 
            this.PauseButton.Enabled = false;
            this.PauseButton.Location = new System.Drawing.Point(98, 247);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(82, 34);
            this.PauseButton.TabIndex = 3;
            this.PauseButton.Text = "Skip";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButtonClick);
            // 
            // PomodoroStatus
            // 
            this.PomodoroStatus.ContextMenuStrip = this.contextMenuStrip;
            this.PomodoroStatus.Location = new System.Drawing.Point(13, 212);
            this.PomodoroStatus.Name = "PomodoroStatus";
            this.PomodoroStatus.Size = new System.Drawing.Size(209, 22);
            this.PomodoroStatus.TabIndex = 4;
            this.PomodoroStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSequence
            // 
            this.lblSequence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSequence.Location = new System.Drawing.Point(190, 258);
            this.lblSequence.Name = "lblSequence";
            this.lblSequence.Size = new System.Drawing.Size(38, 23);
            this.lblSequence.TabIndex = 5;
            this.lblSequence.Text = "0";
            this.lblSequence.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.Location = new System.Drawing.Point(190, 244);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(37, 13);
            this.lblToday.TabIndex = 6;
            this.lblToday.Text = "Today";
            // 
            // PomodoroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(232, 286);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.lblToday);
            this.Controls.Add(this.lblSequence);
            this.Controls.Add(this.PomodoroStatus);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.TimerDisplay);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PomodoroForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomodoro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PomodoroFormFormClosing);
            this.Load += new System.EventHandler(this.PomodoroFormLoad);
            this.Resize += new System.EventHandler(this.PomodoroFormResize);
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label TimerDisplay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon MyNotifyIcon;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Label PomodoroStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.Label lblSequence;
        private System.Windows.Forms.Label lblToday;

        private static void SetControlText(Control obj, string text)
        {
            // If the current thread is not the UI thread, InvokeRequired will be true
            if (obj.InvokeRequired)
            {
                // If so, call Invoke, passing it a lambda expression which calls
                // UpdateText with the same label and text, but on the UI thread instead.
                obj.Invoke((Action)(() => SetControlText(obj, text)));
                return;
            }

            // If we're running on the UI thread, we'll get here, and can safely update 
            // the label's text.
            obj.Text = text;
        }
    }
}


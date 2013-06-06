namespace PomodoroApp
{
    partial class PomodoroAppConfiguration
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.PlayCompletedSound = new System.Windows.Forms.CheckBox();
            this.PomodoroLength = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.ShortBreakLength = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.LongBreakLength = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.LongBreakPomodoro = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPomodoroLength = new System.Windows.Forms.Label();
            this.lblShortBreak = new System.Windows.Forms.Label();
            this.lblLongBreak = new System.Windows.Forms.Label();
            this.lblLongBreakPomodoro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PomodoroLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortBreakLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongBreakLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongBreakPomodoro)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 210);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(335, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            this.statusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip_ItemClicked);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(160, 181);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(80, 26);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(245, 181);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 26);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // PlayCompletedSound
            // 
            this.PlayCompletedSound.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PlayCompletedSound.Checked = global::PomodoroApp.Properties.Settings.Default.PlayCompletedSound;
            this.PlayCompletedSound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PlayCompletedSound.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PomodoroApp.Properties.Settings.Default, "PlayCompletedSound", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PlayCompletedSound.Location = new System.Drawing.Point(2, 153);
            this.PlayCompletedSound.Name = "PlayCompletedSound";
            this.PlayCompletedSound.Size = new System.Drawing.Size(158, 17);
            this.PlayCompletedSound.TabIndex = 4;
            this.PlayCompletedSound.Text = "Play Completed Sound";
            this.PlayCompletedSound.UseVisualStyleBackColor = true;
            // 
            // PomodoroLength
            // 
            this.PomodoroLength.AutoSize = false;
            this.PomodoroLength.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::PomodoroApp.Properties.Settings.Default, "PomodoroLength", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PomodoroLength.Location = new System.Drawing.Point(164, 16);
            this.PomodoroLength.Maximum = 60;
            this.PomodoroLength.Minimum = 1;
            this.PomodoroLength.Name = "PomodoroLength";
            this.PomodoroLength.Size = new System.Drawing.Size(158, 28);
            this.PomodoroLength.TabIndex = 0;
            this.PomodoroLength.TickStyle = System.Windows.Forms.TickStyle.None;
            this.PomodoroLength.Value = global::PomodoroApp.Properties.Settings.Default.PomodoroLength;
            this.PomodoroLength.Scroll += new System.EventHandler(this.PomodoroLength_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Length of each Pomodoro";
            // 
            // ShortBreakLength
            // 
            this.ShortBreakLength.AutoSize = false;
            this.ShortBreakLength.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::PomodoroApp.Properties.Settings.Default, "ShortBreakLength", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ShortBreakLength.Location = new System.Drawing.Point(164, 45);
            this.ShortBreakLength.Maximum = 60;
            this.ShortBreakLength.Minimum = 1;
            this.ShortBreakLength.Name = "ShortBreakLength";
            this.ShortBreakLength.Size = new System.Drawing.Size(158, 28);
            this.ShortBreakLength.TabIndex = 1;
            this.ShortBreakLength.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ShortBreakLength.Value = global::PomodoroApp.Properties.Settings.Default.ShortBreakLength;
            this.ShortBreakLength.Scroll += new System.EventHandler(this.ShortBreakLength_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Length of short break";
            // 
            // LongBreakLength
            // 
            this.LongBreakLength.AutoSize = false;
            this.LongBreakLength.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::PomodoroApp.Properties.Settings.Default, "LongBreakLength", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LongBreakLength.Location = new System.Drawing.Point(164, 75);
            this.LongBreakLength.Maximum = 60;
            this.LongBreakLength.Minimum = 1;
            this.LongBreakLength.Name = "LongBreakLength";
            this.LongBreakLength.Size = new System.Drawing.Size(158, 28);
            this.LongBreakLength.TabIndex = 2;
            this.LongBreakLength.TickStyle = System.Windows.Forms.TickStyle.None;
            this.LongBreakLength.Value = global::PomodoroApp.Properties.Settings.Default.LongBreakLength;
            this.LongBreakLength.Scroll += new System.EventHandler(this.LongBreakLength_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Length of long break";
            // 
            // LongBreakPomodoro
            // 
            this.LongBreakPomodoro.AutoSize = false;
            this.LongBreakPomodoro.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::PomodoroApp.Properties.Settings.Default, "LongBreakPomodoro", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.LongBreakPomodoro.LargeChange = 2;
            this.LongBreakPomodoro.Location = new System.Drawing.Point(164, 105);
            this.LongBreakPomodoro.Minimum = 1;
            this.LongBreakPomodoro.Name = "LongBreakPomodoro";
            this.LongBreakPomodoro.Size = new System.Drawing.Size(158, 28);
            this.LongBreakPomodoro.TabIndex = 3;
            this.LongBreakPomodoro.TickStyle = System.Windows.Forms.TickStyle.None;
            this.LongBreakPomodoro.Value = global::PomodoroApp.Properties.Settings.Default.LongBreakPomodoro;
            this.LongBreakPomodoro.Scroll += new System.EventHandler(this.LongBreakPomodoro_Scroll);
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(2, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 44);
            this.label4.TabIndex = 13;
            this.label4.Text = "Number of Pomodoro before long break";
            // 
            // lblPomodoroLength
            // 
            this.lblPomodoroLength.Location = new System.Drawing.Point(136, 20);
            this.lblPomodoroLength.Name = "lblPomodoroLength";
            this.lblPomodoroLength.Size = new System.Drawing.Size(25, 13);
            this.lblPomodoroLength.TabIndex = 14;
            this.lblPomodoroLength.Text = "(88)";
            this.lblPomodoroLength.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblShortBreak
            // 
            this.lblShortBreak.Location = new System.Drawing.Point(136, 49);
            this.lblShortBreak.Name = "lblShortBreak";
            this.lblShortBreak.Size = new System.Drawing.Size(25, 13);
            this.lblShortBreak.TabIndex = 15;
            this.lblShortBreak.Text = "(88)";
            this.lblShortBreak.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLongBreak
            // 
            this.lblLongBreak.Location = new System.Drawing.Point(136, 79);
            this.lblLongBreak.Name = "lblLongBreak";
            this.lblLongBreak.Size = new System.Drawing.Size(25, 13);
            this.lblLongBreak.TabIndex = 16;
            this.lblLongBreak.Text = "(88)";
            this.lblLongBreak.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblLongBreakPomodoro
            // 
            this.lblLongBreakPomodoro.Location = new System.Drawing.Point(136, 109);
            this.lblLongBreakPomodoro.Name = "lblLongBreakPomodoro";
            this.lblLongBreakPomodoro.Size = new System.Drawing.Size(25, 13);
            this.lblLongBreakPomodoro.TabIndex = 17;
            this.lblLongBreakPomodoro.Text = "(88)";
            this.lblLongBreakPomodoro.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PomodoroAppConfiguration
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(335, 232);
            this.Controls.Add(this.lblLongBreakPomodoro);
            this.Controls.Add(this.lblLongBreak);
            this.Controls.Add(this.lblShortBreak);
            this.Controls.Add(this.lblPomodoroLength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LongBreakPomodoro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LongBreakLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShortBreakLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PomodoroLength);
            this.Controls.Add(this.PlayCompletedSound);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PomodoroAppConfiguration";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.PomodoroAppConfiguration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PomodoroLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortBreakLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongBreakLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongBreakPomodoro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox PlayCompletedSound;
        private System.Windows.Forms.TrackBar PomodoroLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar ShortBreakLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar LongBreakLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar LongBreakPomodoro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPomodoroLength;
        private System.Windows.Forms.Label lblShortBreak;
        private System.Windows.Forms.Label lblLongBreak;
        private System.Windows.Forms.Label lblLongBreakPomodoro;
    }
}
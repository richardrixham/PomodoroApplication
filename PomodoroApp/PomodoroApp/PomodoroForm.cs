namespace PomodoroApp
{
    using System;
    using System.Windows.Forms;

    using ClassCountdownTimer;

    using ClassPomodoro;

    using PomodoroApp.Properties;

    public partial class PomodoroForm : Form
    {
        /// <summary>
        /// Stores configuration details and other information
        /// </summary>
        private readonly Pomodoro pomodoro = new Pomodoro();

        /// <summary>
        /// The _countdown timer.
        /// </summary>
        readonly CountdownTimer countdownTimer = new CountdownTimer();

        public PomodoroForm()
        {
            InitializeComponent();
        }

        private void PomodoroFormLoad(object sender, EventArgs e)
        {
            this.LoadAppSettings();
            this.countdownTimer.Tick += new CountdownTimer.TickHandler(this.MyCountdownTick);
            this.countdownTimer.Complete += new CountdownTimer.CompleteHandler(this.PomodoroComplete);
            this.GetNextTime();
            this.TimerDisplay.Text = this.countdownTimer.GetTime();
            SetControlText(this.PomodoroStatus, "Pomodoro number " + (this.pomodoro.CompletedPomodoro + 1));
        }

        /// <summary>
        /// Load the applications configuration
        /// </summary>
        private void LoadAppSettings()
        {
            this.pomodoro.PomodoroMinutes = Settings.Default.PomodoroLength;
            this.pomodoro.LongBreakMinutes = Settings.Default.LongBreakLength;
            this.pomodoro.ShortBreakMinutes = Settings.Default.ShortBreakLength;
            this.pomodoro.LongBreakPomodoro = Settings.Default.LongBreakPomodoro;
            this.pomodoro.PlaySound = Settings.Default.PlayCompletedSound;
        }

        private void MyCountdownTick(object sender, CountdownTimer.TickEventArgs args)
        {
            SetControlText(TimerDisplay,args.Display);
            MyNotifyIcon.Text = args.Display;
        }

        private void IncreasePomodoroCount(bool increasePomodoroCount = true)
        {
            if (!this.pomodoro.BreakTime)
            {
                if (increasePomodoroCount)
                {
                    this.pomodoro.CompletedPomodoro += 1;
                    SetControlText(lblSequence, this.pomodoro.CompletedPomodoro.ToString());
                }

                this.pomodoro.SequenceCounter += 1;
            }
        }

        private void GetNextTime()
        {
            if (this.pomodoro.BreakTime)
            {
                if (this.pomodoro.SequenceCounter % this.pomodoro.LongBreakPomodoro == 0)
                {
                    this.countdownTimer.Minutes = this.pomodoro.LongBreakMinutes;
                    SetControlText(PomodoroStatus, "Take a Long Break");
                }
                else
                {
                    this.countdownTimer.Minutes = this.pomodoro.ShortBreakMinutes;
                    SetControlText(PomodoroStatus, "Take a Short Break");
                }
            }
            else
            {
                this.countdownTimer.Minutes = this.pomodoro.PomodoroMinutes;
                SetControlText(PomodoroStatus, "Pomodoro number " + (this.pomodoro.CompletedPomodoro + 1));
            }
        }

        private void PomodoroComplete(object sender, EventArgs args)
        {
            this.pomodoro.PlayCompletedSound();
            GetNextIntervalDetails(true);
            SetControlText(TimerDisplay, this.countdownTimer.GetTime());
            this.countdownTimer.ResetTimer();
            SetControlText(StartButton, Resources.PomodoroForm_StartButton_Click_Start);
            SetControlText(PauseButton,Resources.PomodoroForm_PaulButton_Click_Skip);
            MessageBox.Show(Resources.PomodoroForm_pomodoro_Complete_Done_);
        }

        private void StartButtonClick(object sender, EventArgs e)
        {
            if (StartButton.Text == Resources.PomodoroForm_StartButton_Click_Start)
            {
                StartTimer();
            }
            else
            {
                StopTimer();
            }
        }

        private void StartTimer()
        {
            this.countdownTimer.InitialiseTimer();
            this.countdownTimer.StartTimer();
            StartButton.Text = Resources.PomodoroForm_StartTimer_Stop;
            PomodoroStatus.Text = string.Empty;
            PauseButton.Text = Resources.PomodoroForm_PauseButton_Click_Pause;
            SetButtonState(PauseButton, true);
        }

        private void StopTimer()
        {
            this.countdownTimer.StopTimer();
            StartButton.Text = Resources.PomodoroForm_StartButton_Click_Start;
            PauseButton.Text = Resources.PomodoroForm_PaulButton_Click_Skip;
            IncreasePomodoroCount(false);
            this.pomodoro.SwapBreakTime();
            GetNextTime();
            this.countdownTimer.InitialiseTimer();
            SetControlText(TimerDisplay, this.countdownTimer.GetTime());
        }

        private void PomodoroFormResize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                MyNotifyIcon.Visible = true;
                MyNotifyIcon.ShowBalloonTip(200);
                Hide();
            }
            else if (FormWindowState.Normal == WindowState)
            {
                MyNotifyIcon.Visible = false;
            }
        }

        private void PomodoroFormFormClosing(object sender, FormClosingEventArgs e)
        {
            this.countdownTimer.StopTimer();
        }

        private void MyNotifyIconMouseDoubleClick(object sender, MouseEventArgs e)
        {
            MyNotifyIcon.Visible = false;
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void PauseButtonClick(object sender, EventArgs e)
        {
            if (PauseButton.Text == Resources.PomodoroForm_PauseButton_Click_Pause)
            {
                this.PauseTimer();
            }
            else
            {
                if (PauseButton.Text == Resources.PomodoroForm_PauseButton_Click_Resume)
                {
                    this.ResumeTimer();
                }
                else
                {
                    if (PauseButton.Text == Resources.PomodoroForm_PaulButton_Click_Skip)
                    {
                        this.SkipTimer();
                    }
                }
            }
        }

        private void SkipTimer()
        {
            this.GetNextIntervalDetails(false);
            this.TimerDisplay.Text = this.countdownTimer.GetTime(); 
        }

        private void PauseTimer()
        {
            this.countdownTimer.StopTimer();
            PauseButton.Text = Resources.PomodoroForm_PauseButton_Click_Resume;
        }

        private void ResumeTimer()
        {
            this.countdownTimer.StartTimer();
            PauseButton.Text = Resources.PomodoroForm_PauseButton_Click_Pause;                            
        }

        private void SetButtonState(Control button, bool state)
        {
            // If the current thread is not the UI thread, InvokeRequired will be true
            if (button.InvokeRequired)
            {
                // If so, call Invoke, passing it a lambda expression which calls
                // UpdateText with the same label and text, but on the UI thread instead.
                button.Invoke((Action)(() => SetButtonState(button, state)));
                return;
            }

            // If we're running on the UI thread, we'll get here, and can safely update 
            // the label's text.
            PauseButton.Enabled = state;
        }

        private void GetNextIntervalDetails(bool increaseCount)
        {
            IncreasePomodoroCount(increaseCount);
            this.pomodoro.SwapBreakTime();
            GetNextTime();
        }

        private void ConfigurationToolStripMenuItemClick(object sender, EventArgs e)
        {
            var configForm = new PomodoroAppConfiguration();
            configForm.ShowDialog();
            LoadAppSettings();
        }
    }
}

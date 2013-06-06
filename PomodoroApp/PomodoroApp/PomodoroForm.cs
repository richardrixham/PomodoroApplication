using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Windows.Forms;
using ClassCountdownTimer;
using ClassPomodoro;
using PomodoroApp.Properties;

namespace PomodoroApp
{
    public partial class PomodoroForm : Form
    {
        private readonly Pomodoro _pomodoro = new Pomodoro();
        readonly CountdownTimer _countdownTimer = new CountdownTimer();

        public PomodoroForm()
        {
            InitializeComponent();
        }

        private void PomodoroForm_Load(object sender, EventArgs e)
        {
            LoadAppSettings();
            _countdownTimer.Tick += new CountdownTimer.TickHandler(MyCountdown_Tick);
            _countdownTimer.Complete +=new CountdownTimer.CompleteHandler(pomodoro_Complete);
            GetNextTime();
            TimerDisplay.Text = _countdownTimer.GetTime();
            SetControlText(PomodoroStatus, "Pomodoro number " + (_pomodoro.CompletedPomodoro + 1));
        }

        private void LoadAppSettings()
        {
            _pomodoro.PomodoroMinutes = Properties.Settings.Default.PomodoroLength;
            _pomodoro.LongBreakMinutes = Settings.Default.LongBreakLength;
            _pomodoro.ShortBreakMinutes = Settings.Default.ShortBreakLength;
            _pomodoro.LongBreakPomodoro = Settings.Default.LongBreakPomodoro;
            _pomodoro.PlaySound = Settings.Default.PlayCompletedSound;
        }

        private void MyCountdown_Tick(object sender, CountdownTimer.TickEventArgs args)
        {
            SetControlText(TimerDisplay,args.Display);
            MyNotifyIcon.Text = args.Display;
        }

        private void IncreasePomodoroCount(Boolean increasePomodoroCount = true)
        {
            if (!_pomodoro.BreakTime)
            {
                if (increasePomodoroCount)
                {
                    _pomodoro.CompletedPomodoro += 1;
                    SetControlText(lblSequence, _pomodoro.CompletedPomodoro.ToString());
                }
                _pomodoro.SequenceCounter += 1;
            }
        }

        private void GetNextTime()
        {
            if (_pomodoro.BreakTime)
            {
                if (_pomodoro.SequenceCounter % _pomodoro.LongBreakPomodoro == 0)
                {
                    _countdownTimer.Minutes = _pomodoro.LongBreakMinutes;
                    SetControlText(PomodoroStatus, "Take a Long Break");
                }
                else
                {
                    _countdownTimer.Minutes = _pomodoro.ShortBreakMinutes;
                    SetControlText(PomodoroStatus, "Take a Short Break");
                }
            }
            else
            {
                _countdownTimer.Minutes = _pomodoro.PomodoroMinutes;
                SetControlText(PomodoroStatus, "Pomodoro number " + (_pomodoro.CompletedPomodoro+1));
            }
        }

        private void pomodoro_Complete(object sender, EventArgs args)
        {
            _pomodoro.PlayCompletedSound();
            IncreasePomodoroCount();
            _pomodoro.SwapBreakTime();
            GetNextTime();
            SetControlText(TimerDisplay, _countdownTimer.GetTime());

            _countdownTimer.ResetTimer();
            SetButtonState(PauseButton, false);
            SetControlText(StartButton, Resources.PomodoroForm_StartButton_Click_Start);
            MessageBox.Show(Resources.PomodoroForm_pomodoro_Complete_Done_);
        }


        private void StartButton_Click(object sender, EventArgs e)
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
            _countdownTimer.InitialiseTimer();
            _countdownTimer.StartTimer();
            StartButton.Text = Resources.PomodoroForm_StartTimer_Stop;
            PomodoroStatus.Text = "";
            SetButtonState(PauseButton, true);
        }

        private void StopTimer()
        {
            SetButtonState(PauseButton, false); 
            _countdownTimer.StopTimer();
            StartButton.Text = Resources.PomodoroForm_StartButton_Click_Start;
            IncreasePomodoroCount(false);
            _pomodoro.SwapBreakTime();
            GetNextTime();
            _countdownTimer.InitialiseTimer();
            SetControlText(TimerDisplay, _countdownTimer.GetTime());
        }

        private void PomodoroForm_Resize(object sender, EventArgs e)
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

        private void PomodoroForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _countdownTimer.StopTimer();
        }

        private void MyNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MyNotifyIcon.Visible = false;
            Show();
            WindowState = FormWindowState.Normal;
        }


        private void PauseButton_Click(object sender, EventArgs e)
        {
            if (PauseButton.Text == Resources.PomodoroForm_PauseButton_Click_Pause)
            {
                PauseTimer();
            }
            else
            {
                ResumeTimer();
            }
        }

        private void PauseTimer()
        {
            _countdownTimer.StopTimer();
            PauseButton.Text = Resources.PomodoroForm_PauseButton_Click_Resume;
        }

        private void ResumeTimer()
        {
            _countdownTimer.StartTimer();
            PauseButton.Text = Resources.PomodoroForm_PauseButton_Click_Pause;                            
        }

        private void SetButtonState(Control button, Boolean state)
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

        private void SetControlText(Control obj, string text)
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

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var configForm = new PomodoroAppConfiguration();
            configForm.ShowDialog();
            LoadAppSettings();
        }
    }
}

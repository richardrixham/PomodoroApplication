using System;
using System.Media;
using System.IO;

namespace ClassPomodoro
{
    public class Pomodoro
    {
        private Boolean _playSound;
        private Boolean _breakTime;
         

        public Pomodoro()
        {
            SequenceCounter = 0;
            CompletedPomodoro = 0;

            PomodoroMinutes = 25;
            ShortBreakMinutes = 5;
            LongBreakMinutes = 10;
            LongBreakPomodoro = 4;
            
            _playSound = true;
            BreakTime = false;
        }

        public int CompletedPomodoro { get; set; }

        public int ShortBreakMinutes { get; set; }

        public int LongBreakMinutes { get; set; }

        public int LongBreakPomodoro { get; set; }

        public Boolean PlaySound
        {
            get { return _playSound; }
            set { _playSound = value; }
        }

        public int PomodoroMinutes { get; set; }

        public int SequenceCounter { get; set; }

        public bool BreakTime
        {
            get { return _breakTime; }
            set { _breakTime = value; }
        }

        public void PlayCompletedSound()
        {
            if (_playSound)
            {
                try
                {
                    var simpleSound = new SoundPlayer(@"Sounds\Timer.wav");
                    simpleSound.Play();
                }
                catch(FileNotFoundException)
                {
                }
            }
        }

        public void SwapBreakTime()
        {
            _breakTime = !_breakTime;
        }

    }
}

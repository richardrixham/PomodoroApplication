using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PomodoroApp
{

    public partial class PomodoroAppConfiguration : Form
    {
        public PomodoroAppConfiguration()
        {
            InitializeComponent();
        }

        private void PomodoroAppConfiguration_Load(object sender, EventArgs e)
        {
            LoadConfiguration();
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            SaveConfiguration();
            this.Close();
        }

        private void SaveConfiguration()
        {
            Properties.Settings.Default.PomodoroLength = PomodoroLength.Value;
            Properties.Settings.Default.Save();
            
        }

        private void LoadConfiguration()
        {
            lblPomodoroLength.Text = PomodoroLength.Value.ToString();
            lblShortBreak.Text = ShortBreakLength.Value.ToString();
            lblLongBreak.Text = LongBreakLength.Value.ToString();
            lblLongBreakPomodoro.Text = LongBreakPomodoro.Value.ToString();
        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void PomodoroLength_Scroll(object sender, EventArgs e)
        {
            lblPomodoroLength.Text = PomodoroLength.Value.ToString();
        }

        private void ShortBreakLength_Scroll(object sender, EventArgs e)
        {
            lblShortBreak.Text = ShortBreakLength.Value.ToString();
        }

        private void LongBreakLength_Scroll(object sender, EventArgs e)
        {
            lblLongBreak.Text = LongBreakLength.Value.ToString();
        }

        private void LongBreakPomodoro_Scroll(object sender, EventArgs e)
        {
            lblLongBreakPomodoro.Text = LongBreakPomodoro.Value.ToString();
        }

    }
}

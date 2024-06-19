using System;
using System.Windows.Forms;
using System.Net.Http;
using System.Text.Json;

namespace GoogleFormsClone
{
    public partial class FormCreateSubmission : Form
    {
        private DateTime stopwatchStartTime;
        private TimeSpan stopwatchElapsed;
        private bool stopwatchRunning;

        public FormCreateSubmission()
        {
            InitializeComponent();
            this.Name = "FormCreateSubmission";
            stopwatchElapsed = TimeSpan.Zero;
            stopwatchRunning = false;
            timerStopwatch.Interval = 1000; // Adjust timer interval as needed (1 second in this case)
            timerStopwatch.Tick += TimerStopwatch_Tick;
            btnStopwatch.Click += BtnStopwatch_Click;
            btnSubmit.Click += BtnSubmit_Click;

            // Adding keyboard shortcuts
            this.KeyPreview = true;
            this.KeyDown += FormCreateSubmission_KeyDown;
        }

        private void TimerStopwatch_Tick(object sender, EventArgs e)
        {
            if (stopwatchRunning)
            {
                stopwatchElapsed = DateTime.Now - stopwatchStartTime;
                lblStopwatchTime.Text = stopwatchElapsed.ToString(@"hh\:mm\:ss");
            }
        }

        private void BtnStopwatch_Click(object sender, EventArgs e)
        {
            if (stopwatchRunning)
            {
                // Stop the stopwatch
                stopwatchRunning = false;
                timerStopwatch.Stop();
            }
            else
            {
                // Start or resume the stopwatch
                stopwatchStartTime = DateTime.Now - stopwatchElapsed;
                stopwatchRunning = true;
                timerStopwatch.Start();
            }
        }

        private async void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (stopwatchRunning)
            {
                // Stop the stopwatch before submitting
                BtnStopwatch_Click(sender, e);
            }

            var submission = new
            {
                name = txtName.Text,
                email = txtEmail.Text,
                phone = txtPhone.Text,
                github_link = txtGithubLink.Text,
                stopwatch_time = lblStopwatchTime.Text
            };

            var json = JsonSerializer.Serialize(submission);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                var response = await client.PostAsync("http://localhost:3000/submit", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Submission successful!");
                }
                else
                {
                    MessageBox.Show("Failed to submit.");
                }
            }
        }

        private void FormCreateSubmission_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                BtnSubmit_Click(sender, e);
            }

            if (e.Control && e.KeyCode == Keys.T)
            {
                BtnStopwatch_Click(sender,e);
            }
        }
    }
}

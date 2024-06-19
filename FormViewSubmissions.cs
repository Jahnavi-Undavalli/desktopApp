using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;

namespace GoogleFormsClone
{
    public partial class FormViewSubmissions : Form
    {
        private int currentIndex = 0;
        private List<Submission> submissions = new List<Submission>();
        private bool isEditing = false;

        public FormViewSubmissions()
        {
            InitializeComponent();
            this.Name = "FormViewSubmissions";
            btnPrevious.Click += BtnPrevious_Click;
            btnNext.Click += BtnNext_Click;
            editing.Click += btn_edit_Click;
            btnSave.Click += btnSave_Click; // Attach save button click event

            LoadSubmissions();

            // Adding keyboard shortcuts
            this.KeyPreview = true;
            this.KeyDown += FormViewSubmissions_KeyDown;

            // Disable text boxes initially
            DisableTextBoxes();
            btnSave.Visible = false; // Initially hide the Save button
        }

        private void DisableTextBoxes()
        {
            Names.Enabled = false;
            emails.Enabled = false;
            numbers.Enabled = false;
            links.Enabled = false;
            time.Enabled = false;
        }

        private void EnableTextBoxes()
        {
            Names.Enabled = true;
            emails.Enabled = true;
            numbers.Enabled = true;
            links.Enabled = true;
            time.Enabled = true;
        }

        private async void LoadSubmissions()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    int index = 0;
                    while (true)
                    {
                        var response = await client.GetAsync($"http://localhost:3000/read?index={index}");

                        if (!response.IsSuccessStatusCode) break;

                        var json = await response.Content.ReadAsStringAsync();
                        Console.WriteLine($"Received JSON: {json}");

                        var submission = JsonSerializer.Deserialize<Submission>(json);
                        submissions.Add(submission);
                        index++;
                    }
                }

                if (submissions.Count > 0)
                {
                    DisplaySubmission(submissions[currentIndex]);
                }
                else
                {
                    MessageBox.Show("No submissions found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading submissions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                DisplaySubmission(submissions[currentIndex]);
                DisableTextBoxes(); // Ensure text boxes are disabled after navigating
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < submissions.Count - 1)
            {
                currentIndex++;
                DisplaySubmission(submissions[currentIndex]);
                DisableTextBoxes(); // Ensure text boxes are disabled after navigating
            }
        }

        private void DisplaySubmission(Submission submission)
        {
            Names.Text = submission.name;
            emails.Text = submission.email;
            numbers.Text = submission.phone;
            links.Text = submission.github_link;
            time.Text = submission.stopwatch_time;
            DisableTextBoxes(); // Ensure text boxes are disabled after displaying submission
        }

        private void FormViewSubmissions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.P)
            {
                BtnPrevious_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.N)
            {
                BtnNext_Click(sender, e);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 0 && currentIndex < submissions.Count)
            {
                try
                {
                    using (var client = new HttpClient())
                    {
                        var indexToDelete = currentIndex; // Use currentIndex to determine which submission to delete

                        var response = await client.DeleteAsync($"http://localhost:3000/delete?index={indexToDelete}");

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Submission deleted successfully!");
                            submissions.RemoveAt(currentIndex);
                            if (currentIndex >= submissions.Count)
                                currentIndex = submissions.Count - 1;
                            if (currentIndex >= 0)
                                DisplaySubmission(submissions[currentIndex]);
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete submission.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting submission: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No submission to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            isEditing = true;
            EnableTextBoxes();
            btnSave.Visible = true; // Show Save button
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 0 && currentIndex < submissions.Count)
            {
                try
                {
                    using (var client = new HttpClient())
                    {
                        var editedSubmission = submissions[currentIndex];
                        editedSubmission.name = Names.Text;
                        editedSubmission.email = emails.Text;
                        editedSubmission.phone = numbers.Text;
                        editedSubmission.github_link = links.Text;
                        editedSubmission.stopwatch_time = time.Text;

                        var json = JsonSerializer.Serialize(editedSubmission);
                        var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                        var response = await client.PutAsync("http://localhost:3000/update", content);

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Submission updated successfully!");
                            DisableTextBoxes(); // Disable text boxes after successful update
                            btnSave.Visible = false; // Hide Save button after update
                            isEditing = false;
                        }
                        else
                        {
                            MessageBox.Show("Failed to update submission. Status code: " + response.StatusCode);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating submission: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No submission to update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private class Submission
        {
            public string name { get; set; }
            public string email { get; set; }
            public string phone { get; set; }
            public string github_link { get; set; }
            public string stopwatch_time { get; set; }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Windows.Forms;

namespace GoogleFormsClone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AttachEventHandlers();

            // Adding keyboard shortcuts
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void AttachEventHandlers()
        {
            // Ensure we don't attach the event handlers multiple times
            btnViewSubmissions.Click -= BtnViewSubmissions_Click;
            btnCreateSubmission.Click -= BtnCreateSubmission_Click;

            btnViewSubmissions.Click += BtnViewSubmissions_Click;
            btnCreateSubmission.Click += BtnCreateSubmission_Click;
        }

        private void BtnViewSubmissions_Click(object sender, EventArgs e)
        {
            // Ensure only one instance of FormViewSubmissions is shown
            Form formViewSubmissions = Application.OpenForms["FormViewSubmissions"];
            if (formViewSubmissions == null)
            {
                formViewSubmissions = new FormViewSubmissions();
                formViewSubmissions.Show();
            }
            else
            {
                formViewSubmissions.BringToFront();
            }
        }

        private void BtnCreateSubmission_Click(object sender, EventArgs e)
        {
            // Ensure only one instance of FormCreateSubmission is shown
            Form formCreateSubmission = Application.OpenForms["FormCreateSubmission"];
            if (formCreateSubmission == null)
            {
                formCreateSubmission = new FormCreateSubmission();
                formCreateSubmission.Show();
            }
            else
            {
                formCreateSubmission.BringToFront();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                BtnViewSubmissions_Click(sender, e);
            }
            else if (e.Control && e.KeyCode == Keys.N)
            {
                BtnCreateSubmission_Click(sender, e);
            }
        }
    }
}

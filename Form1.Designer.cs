namespace GoogleFormsClone
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewSubmissions = new System.Windows.Forms.Button();
            this.btnCreateSubmission = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jahnavi, Slidely  Task 2 - Slidely Form App";
            // 
            // btnViewSubmissions
            // 
            this.btnViewSubmissions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnViewSubmissions.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewSubmissions.FlatAppearance.BorderSize = 5;
            this.btnViewSubmissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSubmissions.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnViewSubmissions.Location = new System.Drawing.Point(68, 219);
            this.btnViewSubmissions.Name = "btnViewSubmissions";
            this.btnViewSubmissions.Size = new System.Drawing.Size(681, 61);
            this.btnViewSubmissions.TabIndex = 1;
            this.btnViewSubmissions.Text = "VIEW SUBMISSIONS( CTRL + V)";
            this.btnViewSubmissions.UseVisualStyleBackColor = false;
            this.btnViewSubmissions.Click += new System.EventHandler(this.BtnViewSubmissions_Click);
            // 
            // btnCreateSubmission
            // 
            this.btnCreateSubmission.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCreateSubmission.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateSubmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateSubmission.Location = new System.Drawing.Point(68, 310);
            this.btnCreateSubmission.Name = "btnCreateSubmission";
            this.btnCreateSubmission.Size = new System.Drawing.Size(681, 58);
            this.btnCreateSubmission.TabIndex = 0;
            this.btnCreateSubmission.Text = "CREATE SUBMISSIONS( CTRL + N)";
            this.btnCreateSubmission.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateSubmission);
            this.Controls.Add(this.btnViewSubmissions);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewSubmissions;
        private System.Windows.Forms.Button btnCreateSubmission;
    }
}


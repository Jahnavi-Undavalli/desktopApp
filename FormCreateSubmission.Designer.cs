namespace GoogleFormsClone
{
    partial class FormCreateSubmission
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
            this.create = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGithubLink = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtGithubLink = new System.Windows.Forms.TextBox();
            this.btnStopwatch = new System.Windows.Forms.Button();
            this.lblStopwatchTime = new System.Windows.Forms.Label();
            this.timerStopwatch = new System.Windows.Forms.Timer(this.components);
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // create
            // 
            this.create.AutoSize = true;
            this.create.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.Location = new System.Drawing.Point(110, 77);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(588, 36);
            this.create.TabIndex = 0;
            this.create.Text = "Jahnavi, Slidely Task 2- Create Submission";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(123, 150);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(125, 208);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(123, 259);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(96, 20);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Phone Num";
            // 
            // lblGithubLink
            // 
            this.lblGithubLink.AutoSize = true;
            this.lblGithubLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGithubLink.Location = new System.Drawing.Point(125, 306);
            this.lblGithubLink.Name = "lblGithubLink";
            this.lblGithubLink.Size = new System.Drawing.Size(94, 40);
            this.lblGithubLink.TabIndex = 4;
            this.lblGithubLink.Text = "Github Link\r\n For Task 2";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(256, 150);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(491, 22);
            this.txtName.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(256, 206);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(491, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(256, 257);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(491, 22);
            this.txtPhone.TabIndex = 7;
            // 
            // txtGithubLink
            // 
            this.txtGithubLink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGithubLink.Location = new System.Drawing.Point(256, 306);
            this.txtGithubLink.Name = "txtGithubLink";
            this.txtGithubLink.Size = new System.Drawing.Size(491, 22);
            this.txtGithubLink.TabIndex = 8;
            // 
            // btnStopwatch
            // 
            this.btnStopwatch.BackColor = System.Drawing.Color.Khaki;
            this.btnStopwatch.FlatAppearance.BorderSize = 0;
            this.btnStopwatch.Location = new System.Drawing.Point(107, 389);
            this.btnStopwatch.Name = "btnStopwatch";
            this.btnStopwatch.Size = new System.Drawing.Size(251, 37);
            this.btnStopwatch.TabIndex = 9;
            this.btnStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T)";
            this.btnStopwatch.UseVisualStyleBackColor = false;
            // 
            // lblStopwatchTime
            // 
            this.lblStopwatchTime.AutoSize = true;
            this.lblStopwatchTime.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblStopwatchTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStopwatchTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopwatchTime.Location = new System.Drawing.Point(433, 389);
            this.lblStopwatchTime.Name = "lblStopwatchTime";
            this.lblStopwatchTime.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.lblStopwatchTime.Size = new System.Drawing.Size(107, 37);
            this.lblStopwatchTime.TabIndex = 10;
            this.lblStopwatchTime.Text = "00:00:00";
            // 
            // timerStopwatch
            // 
            this.timerStopwatch.Interval = 1000;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(127, 460);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(611, 45);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "SUBMIT( CTRL + S)";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // FormCreateSubmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblStopwatchTime);
            this.Controls.Add(this.btnStopwatch);
            this.Controls.Add(this.txtGithubLink);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblGithubLink);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.create);
            this.Name = "FormCreateSubmission";
            this.Text = "FormCreateSubmission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label create;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGithubLink;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtGithubLink;
        private System.Windows.Forms.Button btnStopwatch;
       
        private System.Windows.Forms.Label lblStopwatchTime;
        private System.Windows.Forms.Timer timerStopwatch;
        private System.Windows.Forms.Button btnSubmit;
    }
}
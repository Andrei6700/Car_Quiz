namespace Car_Quiz.UI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlQuestionContainer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton rdoOption1;
        private System.Windows.Forms.RadioButton rdoOption2;
        private System.Windows.Forms.RadioButton rdoOption3;
        private System.Windows.Forms.RadioButton rdoOption4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbScoreStrategy;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Label lblLastWrong;
        private System.Windows.Forms.ProgressBar progressBar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlQuestionContainer = new System.Windows.Forms.Panel();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rdoOption1 = new System.Windows.Forms.RadioButton();
            this.rdoOption2 = new System.Windows.Forms.RadioButton();
            this.rdoOption3 = new System.Windows.Forms.RadioButton();
            this.rdoOption4 = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmbScoreStrategy = new System.Windows.Forms.ComboBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblRemaining = new System.Windows.Forms.Label();
            this.lblLastWrong = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.pnlQuestionContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlQuestionContainer
            // 
            this.pnlQuestionContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuestionContainer.Controls.Add(this.lblQuestion);
            this.pnlQuestionContainer.Location = new System.Drawing.Point(10, 10);
            this.pnlQuestionContainer.Name = "pnlQuestionContainer";
            this.pnlQuestionContainer.Size = new System.Drawing.Size(223, 52);
            this.pnlQuestionContainer.TabIndex = 0;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblQuestion.Location = new System.Drawing.Point(0, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(221, 50);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Your Question ...";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdoOption1
            // 
            this.rdoOption1.AutoSize = true;
            this.rdoOption1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdoOption1.Location = new System.Drawing.Point(14, 69);
            this.rdoOption1.Name = "rdoOption1";
            this.rdoOption1.Size = new System.Drawing.Size(83, 19);
            this.rdoOption1.TabIndex = 1;
            this.rdoOption1.TabStop = true;
            this.rdoOption1.Text = "Opțiunea 1";
            this.rdoOption1.UseVisualStyleBackColor = true;
            // 
            // rdoOption2
            // 
            this.rdoOption2.AutoSize = true;
            this.rdoOption2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdoOption2.Location = new System.Drawing.Point(14, 93);
            this.rdoOption2.Name = "rdoOption2";
            this.rdoOption2.Size = new System.Drawing.Size(83, 19);
            this.rdoOption2.TabIndex = 2;
            this.rdoOption2.TabStop = true;
            this.rdoOption2.Text = "Opțiunea 2";
            this.rdoOption2.UseVisualStyleBackColor = true;
            // 
            // rdoOption3
            // 
            this.rdoOption3.AutoSize = true;
            this.rdoOption3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdoOption3.Location = new System.Drawing.Point(14, 116);
            this.rdoOption3.Name = "rdoOption3";
            this.rdoOption3.Size = new System.Drawing.Size(83, 19);
            this.rdoOption3.TabIndex = 3;
            this.rdoOption3.TabStop = true;
            this.rdoOption3.Text = "Opțiunea 3";
            this.rdoOption3.UseVisualStyleBackColor = true;
            this.rdoOption3.CheckedChanged += new System.EventHandler(this.rdoOption3_CheckedChanged);
            // 
            // rdoOption4
            // 
            this.rdoOption4.AutoSize = true;
            this.rdoOption4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdoOption4.Location = new System.Drawing.Point(14, 140);
            this.rdoOption4.Name = "rdoOption4";
            this.rdoOption4.Size = new System.Drawing.Size(83, 19);
            this.rdoOption4.TabIndex = 4;
            this.rdoOption4.TabStop = true;
            this.rdoOption4.Text = "Opțiunea 4";
            this.rdoOption4.UseVisualStyleBackColor = true;
            this.rdoOption4.CheckedChanged += new System.EventHandler(this.rdoOption4_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSubmit.Location = new System.Drawing.Point(14, 165);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(69, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Trimite";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cmbScoreStrategy
            // 
            this.cmbScoreStrategy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScoreStrategy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbScoreStrategy.FormattingEnabled = true;
            this.cmbScoreStrategy.Location = new System.Drawing.Point(103, 165);
            this.cmbScoreStrategy.Name = "cmbScoreStrategy";
            this.cmbScoreStrategy.Size = new System.Drawing.Size(103, 23);
            this.cmbScoreStrategy.TabIndex = 6;
            this.cmbScoreStrategy.SelectedIndexChanged += new System.EventHandler(this.cmbScoreStrategy_SelectedIndexChanged);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblScore.Location = new System.Drawing.Point(10, 199);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(33, 15);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Scor:";
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // lblRemaining
            // 
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRemaining.Location = new System.Drawing.Point(69, 199);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(60, 15);
            this.lblRemaining.TabIndex = 8;
            this.lblRemaining.Text = "Rămase: 0";
            // 
            // lblLastWrong
            // 
            this.lblLastWrong.AutoSize = true;
            this.lblLastWrong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLastWrong.Location = new System.Drawing.Point(14, 221);
            this.lblLastWrong.Name = "lblLastWrong";
            this.lblLastWrong.Size = new System.Drawing.Size(12, 15);
            this.lblLastWrong.TabIndex = 9;
            this.lblLastWrong.Text = "-";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 243);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(193, 17);
            this.progressBar.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 277);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblLastWrong);
            this.Controls.Add(this.lblRemaining);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.cmbScoreStrategy);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rdoOption4);
            this.Controls.Add(this.rdoOption3);
            this.Controls.Add(this.rdoOption2);
            this.Controls.Add(this.rdoOption1);
            this.Controls.Add(this.pnlQuestionContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Car Quiz";
            this.pnlQuestionContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

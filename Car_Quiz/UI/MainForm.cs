using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using Car_Quiz.Models;
using Car_Quiz.Repositories;
using Car_Quiz.Strategies;
using Car_Quiz.Factories;

namespace Car_Quiz.UI
{
    public partial class MainForm : Form
    {
        private List<Question> _questions;
        private IScoreStrategy _scoreStrategy;
        private int _currentIndex = 0;
        private int _correctCount = 0;
        private int _wrongCount = 0;
        private string _lastWrongInfo = "-";

        public MainForm()
        {
            InitializeComponent();

            // ComboBox with strategies 
            cmbScoreStrategy.Items.Add("Clasic");
            cmbScoreStrategy.Items.Add("Penalizare");
            cmbScoreStrategy.SelectedIndex = 0;

            LoadQuestionsFromDatabase();
            InitializeScoreStrategy();
            UpdateStatusBar();
            DisplayCurrentQuestion();
        }


        private void InitializeScoreStrategy()
        {
            string key = cmbScoreStrategy.SelectedItem.ToString();
            try
            {
                _scoreStrategy = ScoreStrategyFactory.Create(key);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing strategy: {ex.Message}", "Error");
                _scoreStrategy = new ClassicScoreStrategy();
            }
        }

        // load questions from the database
        private void LoadQuestionsFromDatabase()
        {
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["QuizDB"].ConnectionString;
                var sqlRepo = new SqlQuestionRepository(connStr);
                var loggingRepo = new LoggingQuestionRepositoryDecorator(sqlRepo);
                _questions = loggingRepo.GetAllQuestions();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL Error: {ex.Message}", "DB Error");
                _questions = new List<Question>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
                _questions = new List<Question>();
            }
        }

        private void DisplayCurrentQuestion()
        {
            if (_currentIndex >= _questions.Count)
            {
                ShowFinalResult();
                return;
            }

            var q = _questions[_currentIndex];
            lblQuestion.Text = q.Intrebare;

            rdoOption1.Text = q.Optiuni[0];
            rdoOption2.Text = q.Optiuni[1];
            rdoOption3.Text = q.Optiuni[2];
            rdoOption4.Text = q.Optiuni[3];

            rdoOption1.Checked = false;
            rdoOption2.Checked = false;
            rdoOption3.Checked = false;
            rdoOption4.Checked = false;
        }

        private bool ValidateAnswerSelection()
        {
            if (!rdoOption1.Checked && !rdoOption2.Checked && !rdoOption3.Checked && !rdoOption4.Checked)
            {
                MessageBox.Show("Selecteaza o opțiune!", "WARNING");
                return false;
            }
            return true;
        }


        private string GetSelectedAnswer()
        {
            if (rdoOption1.Checked) return rdoOption1.Text;
            if (rdoOption2.Checked) return rdoOption2.Text;
            if (rdoOption3.Checked) return rdoOption3.Text;
            return rdoOption4.Text;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateAnswerSelection()) return;

            var q = _questions[_currentIndex];
            string chosen = GetSelectedAnswer();

            if (chosen == q.RaspunsCorect)
            {
                _correctCount++;
                _lastWrongInfo = "-";
            }
            else
            {
                _wrongCount++;
                _lastWrongInfo = $"Gresit: {chosen} (Corect: {q.RaspunsCorect})";
            }

            _currentIndex++;
            UpdateStatusBar();
            DisplayCurrentQuestion();
        }

        private void UpdateStatusBar()
        {
            if (_questions == null)
                _questions = new List<Question>();

            int currentScore = _scoreStrategy.CalculateScore(_correctCount, _wrongCount);

            lblScore.Text = $"Scor: {currentScore}";
            lblRemaining.Text = $"Rămase: {_questions.Count - _currentIndex}";
            lblLastWrong.Text = _lastWrongInfo;

            if (_questions.Count > 0)
                progressBar.Value = (int)((_currentIndex / (double)_questions.Count) * 100);
            else
                progressBar.Value = 0;
        }

        private void ShowFinalResult()
        {
            int finalScore = _scoreStrategy.CalculateScore(_correctCount, _wrongCount);
            string message = $"Scor final: {finalScore}\nCorecte: {_correctCount}\nGreșite: {_wrongCount}";
            MessageBox.Show(message, "Quiz Terminat");
            this.Close();
        }

        private void cmbScoreStrategy_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeScoreStrategy();
            UpdateStatusBar();
        }

        #region Event handlers goale pentru Designer (evitarea erorilor la compile)

        private void lblQuestion_Click(object sender, EventArgs e) { }
        private void rdoOption3_CheckedChanged(object sender, EventArgs e) { }
        private void rdoOption4_CheckedChanged(object sender, EventArgs e) { }
        private void lblScore_Click(object sender, EventArgs e) { }

        #endregion
    }
}

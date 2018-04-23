using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyApp.DAL;
using MyApp.Theory;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace MyApp.Tests
{
    public partial class TestsForm : Telerik.WinControls.UI.RadForm
    {
        public TestsForm(int chapterId)
        {
            InitializeComponent();
            FillData(chapterId);
            NextQuestion();
        }

        private List<Question> _questionList;
        private List<List<Answer>> _answersList;
        private int _questionId;
        private int _correctAnswersCount;

        private void FillData(int chapterId)
        {
            using (var context = new LearningToolDBEntities())
            {
                var questions = from ch in context.Chapters
                                where ch.Id == chapterId
                                select ch.Questions;
                foreach (var q in questions)
                    _questionList = new List<Question>(q);

                _answersList = new List<List<Answer>>();
                foreach (var question in _questionList)
                    _answersList.Add(new List<Answer>(question.Answers));
            }
        }

        private void CheckAnswers()
        {
            Answer correctAnswer = null;
            foreach (var answer in _answersList[_questionId])
                if (answer.IsCorrect)
                    correctAnswer = answer;

            foreach (var rb in QuestionGroupBox.Controls.OfType<RadRadioButton>())
                if (rb.IsChecked && rb.Text == correctAnswer?.Text)
                    _correctAnswersCount++;

            foreach (var rb in QuestionGroupBox.Controls.OfType<RadRadioButton>())
                rb.IsChecked = false;
        }

        private void NextQuestion()
        {
            if (_questionId == _questionList.Count - 1)
            {
                NextQuestionButton.Enabled = false;
                QuestionLabel.Text = $@"Правильных ответов - {_correctAnswersCount}";
                return;
            }

            if (_questionId == _questionList.Count - 2)
                NextQuestionButton.Text = @"Завершить";

            QuestionLabel.Text = _questionList[_questionId].Text;
            var counter = 0;
            foreach (var rb in QuestionGroupBox.Controls.OfType<RadRadioButton>())
            {
                rb.Text = _answersList[_questionId][counter].Text;
                counter++;
            }

            CheckAnswers();
            _questionId++;
            QuestionCounterLabel.Text = $@"Вопрос {_questionId} из {_questionList.Count}";
        }

        private bool AnswerIsSelected()
        {
            return QuestionGroupBox.Controls.OfType<RadRadioButton>().Any(rb => rb.IsChecked);
        }

        private void CloseFormPictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NextQuestionButton_Click(object sender, EventArgs e)
        {
            if (!AnswerIsSelected())
            {
                RadMessageBox.Show("Не выбран ни один ответ!", "", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                return;
            }
            NextQuestion();


        }
    }
}

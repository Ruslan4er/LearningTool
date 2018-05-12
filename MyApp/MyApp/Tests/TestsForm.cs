using MyApp.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace MyApp.Tests
{
    public partial class TestsForm : RadForm
    {
        public TestsForm(int chapterId)
        {
            InitializeComponent();
            FillData(chapterId);
            NextQuestion();
        }

        private List<Question> questionList;
        private List<List<Answer>> answersList;
        private int questionId;
        private int correctAnswersCount;

        private void FillData(int chapterId)
        {
            using (var context = new LearningToolDBEntities())
            {
                var questions = from ch in context.Chapters
                                where ch.Id == chapterId
                                select ch.Questions;
                foreach (var q in questions)
                    questionList = new List<Question>(q);

                answersList = new List<List<Answer>>();
                foreach (var question in questionList)
                    answersList.Add(new List<Answer>(question.Answers));

                ChapterNameLabel.Text = context.Chapters.Find(chapterId)?.Name;
            }
        }

        private void SaveResult()
        {
            using (var context = new LearningToolDBEntities())
            {
                try
                {
                    context.TestingResults.Add(new TestingResult
                    {
                        Date = DateTime.Now,
                        Mark = correctAnswersCount,
                        UserId = UserProfile.Id,
                        Chapter = ChapterNameLabel.Text
                    });
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    MessageBox.Show(@"Результат не сохранён. Авторизируйтесь!");
                }
                
            }
        }

        private void CheckAnswers()
        {
            Answer correctAnswer = null;
            foreach (var answer in answersList[questionId])
                if (answer.IsCorrect)
                    correctAnswer = answer;

            foreach (var rb in QuestionGroupBox.Controls.OfType<RadRadioButton>())
                if (rb.IsChecked && rb.Text == correctAnswer?.Text)
                    correctAnswersCount++;

            foreach (var rb in QuestionGroupBox.Controls.OfType<RadRadioButton>())
                rb.IsChecked = false;
        }

        private void NextQuestion()
        {
            if (questionId == questionList.Count)
            {
                NextQuestionButton.Enabled = false;
                QuestionLabel.Text = $@"Правильных ответов - {correctAnswersCount}";
                SaveResult();
                return;
            }

            if (questionId == questionList.Count - 1)
                NextQuestionButton.Text = @"Завершить";

            QuestionLabel.Text = questionList[questionId].Text;
            var counter = 0;
            foreach (var rb in QuestionGroupBox.Controls.OfType<RadRadioButton>())
            {
                rb.Text = answersList[questionId][counter].Text;
                counter++;
            }

            CheckAnswers();
            questionId++;
            QuestionCounterLabel.Text = $@"Вопрос {questionId} из {questionList.Count}";
        }

        private bool AnswerIsSelected()
        {
            return QuestionGroupBox.Controls.OfType<RadRadioButton>().Any(rb => rb.IsChecked);
        }

        private void CloseFormPictureBox_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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

        private void ToTheoryFormPictureBox_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}

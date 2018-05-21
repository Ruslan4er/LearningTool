using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyApp.DAL;
using Telerik.WinControls;

namespace MyApp.UserProfileForms
{
    public partial class UserProfileForm : Telerik.WinControls.UI.RadForm
    {
        private readonly int _userId;
        public UserProfileForm(int userId)
        {
            this._userId = userId;
            InitializeComponent();
            FillGrid();

        }
        
        private void FillGrid()
        {
            using (var context = new LearningToolDBEntities())
            {
                var x = from tr in context.TestingResults
                        where tr.UserId == _userId
                        select new
                        {
                            Chapter = tr.Chapter,
                            Result = tr.Mark,
                            Date = tr.Date
                        };


                TestResultGridView.DataSource = x.ToList();
                TestResultGridView.Columns[0].HeaderText = @"Глава";
                TestResultGridView.Columns[1].HeaderText = @"Оценка";
                TestResultGridView.Columns[2].HeaderText = @"Дата прохождения";

                foreach (var column in TestResultGridView.Columns)
                {
                    column.TextAlignment = ContentAlignment.MiddleCenter;
                }
            }
        }

        private void CloseFormPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void OpenTestsFormPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void CloseFormPictureBox_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}

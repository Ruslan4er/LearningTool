using MyApp.Labs;
using MyApp.Theory;
using System;
using MyApp.UserProfileForms;
using Telerik.WinControls.UI;

namespace MyApp
{
    public partial class MainMenuForm : RadForm
    {
        public MainMenuForm()
        {
            InitializeComponent();
            UserNameLabel.Text = UserProfile.Name;
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TheoryPanel_Click(object sender, EventArgs e)
        {
            var frm = new TheoryForm();
            frm.Closed += (s, args) => this.Show();
            frm.Show();
            Hide();
        }

        private void LabsPanel_Click(object sender, EventArgs e)
        {
            var frm = new LabsForm();
            frm.Closed += (s, args) => this.Show();
            frm.Show();
            Hide();
        }

        private void TestingPanel_Click(object sender, EventArgs e)
        {

        }

        private void OpenUserProfileFormButton_Click(object sender, EventArgs e)
        {
            var frm = new UserProfileForm(UserProfile.Id);
            frm.Closed += (s, args) => this.Show();
            frm.Show();
            this.Hide();
            
        }
    }
}

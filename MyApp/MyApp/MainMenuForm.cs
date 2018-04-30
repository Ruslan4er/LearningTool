using MyApp.Labs;
using MyApp.Theory;
using System;
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
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void LabsPanel_Click(object sender, EventArgs e)
        {
            var frm = new LabsForm();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void TestingPanel_Click(object sender, EventArgs e)
        {
            //var frm = new TestsForm(2);
            //this.Visible = false;
            //frm.ShowDialog();
            //this.Visible = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MyApp.Labs;
using MyApp.Tests;
using MyApp.Theory;
using Telerik.WinControls;

namespace MyApp
{
    public partial class MainMenuForm : Telerik.WinControls.UI.RadForm
    {
        public MainMenuForm(string userName)
        {
            InitializeComponent();
            UserNameLabel.Text = userName;
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            
        }

        private void TheoryPanel_Click(object sender, EventArgs e)
        {
            var frm = new TheoryForm();
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
        }

        private void LabsPanel_Click(object sender, EventArgs e)
        {
            var frm = new LabsForm();
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
        }

        private void TestingPanel_Click(object sender, EventArgs e)
        {
            var frm = new TestsForm();
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace MyApp.Theory
{
    public partial class TheoryForm : Telerik.WinControls.UI.RadForm
    {
        public TheoryForm()
        {
            InitializeComponent();
        }

        private void Chapter2Label_Click(object sender, EventArgs e)
        {
            TheoryPdfViewer.LoadDocument((Application.StartupPath + "\\Content\\Theory\\2.pdf"));
        }

        private void Chapter1Label_Click(object sender, EventArgs e)
        {
            TheoryPdfViewer.LoadDocument((Application.StartupPath + "\\Content\\Theory\\1.pdf"));
        }

        private void Chapter3Label_Click(object sender, EventArgs e)
        {
            TheoryPdfViewer.LoadDocument((Application.StartupPath + "\\Content\\Theory\\3.pdf"));
        }

        private void Chapter4Label_Click(object sender, EventArgs e)
        {
            TheoryPdfViewer.LoadDocument((Application.StartupPath + "\\Content\\Theory\\4.pdf"));
        }

        private void Chapter5Label_Click(object sender, EventArgs e)
        {
            TheoryPdfViewer.LoadDocument((Application.StartupPath + "\\Content\\Theory\\5.pdf"));
        }

        private void Chapter6Label_Click(object sender, EventArgs e)
        {
            TheoryPdfViewer.LoadDocument((Application.StartupPath + "\\Content\\Theory\\6.pdf"));
        }

        private void Chapter7Label_Click(object sender, EventArgs e)
        {
            TheoryPdfViewer.LoadDocument((Application.StartupPath + "\\Content\\Theory\\7.pdf"));
        }

        private void Chapter8Label_Click(object sender, EventArgs e)
        {
            TheoryPdfViewer.LoadDocument((Application.StartupPath + "\\Content\\Theory\\8.pdf"));
        }

        private void Chapter9Label_Click(object sender, EventArgs e)
        {
            TheoryPdfViewer.LoadDocument((Application.StartupPath + "\\Content\\Theory\\9.pdf"));
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

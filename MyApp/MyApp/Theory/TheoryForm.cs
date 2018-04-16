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
            FillPdfViewers();
        }

        private void FillPdfViewers()
        {
            TheoryPdfViewer1.LoadDocument((Application.StartupPath + "\\Content\\Theory\\1.pdf"));
            TheoryPdfViewer2.LoadDocument((Application.StartupPath + "\\Content\\Theory\\2.pdf"));
            TheoryPdfViewer3.LoadDocument((Application.StartupPath + "\\Content\\Theory\\3.pdf"));
            TheoryPdfViewer4.LoadDocument((Application.StartupPath + "\\Content\\Theory\\4.pdf"));
            TheoryPdfViewer5.LoadDocument((Application.StartupPath + "\\Content\\Theory\\5.pdf"));
            TheoryPdfViewer6.LoadDocument((Application.StartupPath + "\\Content\\Theory\\6.pdf"));
            TheoryPdfViewer7.LoadDocument((Application.StartupPath + "\\Content\\Theory\\7.pdf"));
            TheoryPdfViewer8.LoadDocument((Application.StartupPath + "\\Content\\Theory\\8.pdf"));
            TheoryPdfViewer9.LoadDocument((Application.StartupPath + "\\Content\\Theory\\9.pdf"));

        }

        private void CloseFormPictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

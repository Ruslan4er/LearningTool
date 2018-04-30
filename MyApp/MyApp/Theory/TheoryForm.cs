using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MyApp.Tests;
using Telerik.WinControls.UI;

namespace MyApp.Theory
{
    public partial class TheoryForm : RadForm
    {
        public TheoryForm()
        {
            InitializeComponent();
            SubscribeElements();
            foreach (var viewer in Controls.OfType<RadPageView>().OfType<RadPdfViewer>())
                viewer.EnableThumbnails = false;
        }

        private int _chapterId;

        private void SubscribeElements()
        {
            this.radPageViewPage1.Item.Click += new System.EventHandler(this.radPageViewPage1_Click);
            this.radPageViewPage2.Item.Click += new System.EventHandler(this.radPageViewPage2_Click);
            this.radPageViewPage3.Item.Click += new System.EventHandler(this.radPageViewPage3_Click);
            this.radPageViewPage4.Item.Click += new System.EventHandler(this.radPageViewPage4_Click);
            this.radPageViewPage5.Item.Click += new System.EventHandler(this.radPageViewPage5_Click);
            this.radPageViewPage6.Item.Click += new System.EventHandler(this.radPageViewPage6_Click);
            this.radPageViewPage7.Item.Click += new System.EventHandler(this.radPageViewPage7_Click);
            this.radPageViewPage8.Item.Click += new System.EventHandler(this.radPageViewPage8_Click);
            this.radPageViewPage9.Item.Click += new System.EventHandler(this.radPageViewPage9_Click);
        }

        private void CloseFormPictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TheoryForm_Load(object sender, EventArgs e)
        {
            var newfont = new Font(this.TheoryPageView.Font.FontFamily, 11);
            var stripElement = (RadPageViewStripElement)this.TheoryPageView.ViewElement;
            foreach (RadPageViewStripItem item in stripElement.ItemContainer.ItemLayout.Children)
                item.Font = newfont;
        }

        private void radPageViewPage1_Click(object sender, EventArgs e)
        {
            TheoryPdfViewer1.LoadDocument((Application.StartupPath + "\\Content\\Theory\\1.pdf"));
            _chapterId = 1;
        }

        private void radPageViewPage3_Click(object sender, EventArgs e)
        {
            TheoryPdfViewer3.LoadDocument((Application.StartupPath + "\\Content\\Theory\\3.pdf"));
            _chapterId = 3;
        }

        private void radPageViewPage4_Click(object sender, EventArgs e)
        {
            TheoryPdfViewer4.LoadDocument((Application.StartupPath + "\\Content\\Theory\\4.pdf"));
            _chapterId = 4;
        }

        private void radPageViewPage5_Click(object sender, EventArgs e)
        {
            TheoryPdfViewer5.LoadDocument((Application.StartupPath + "\\Content\\Theory\\5.pdf"));
            _chapterId = 5;
        }

        private void radPageViewPage6_Click(object sender, EventArgs e)
        {
            TheoryPdfViewer6.LoadDocument((Application.StartupPath + "\\Content\\Theory\\6.pdf"));
            _chapterId = 6;
        }

        private void radPageViewPage7_Click(object sender, EventArgs e)
        {
            TheoryPdfViewer7.LoadDocument((Application.StartupPath + "\\Content\\Theory\\7.pdf"));
            _chapterId = 7;
        }

        private void radPageViewPage8_Click(object sender, EventArgs e)
        {
            TheoryPdfViewer8.LoadDocument((Application.StartupPath + "\\Content\\Theory\\8.pdf"));
            _chapterId = 8;
        }

        private void radPageViewPage9_Click(object sender, EventArgs e)
        {
            TheoryPdfViewer9.LoadDocument((Application.StartupPath + "\\Content\\Theory\\9.pdf"));
            _chapterId = 9;
        }

        private void radPageViewPage2_Click(object sender, EventArgs e)
        {
            TheoryPdfViewer2.LoadDocument((Application.StartupPath + "\\Content\\Theory\\2.pdf"));
            _chapterId = 2;
        }

        private void OpenTestsFormPictureBox_Click(object sender, EventArgs e)
        {
            var frm = new TestsForm(_chapterId);
            this.Hide();
            frm.ShowDialog();
            if (frm.DialogResult != DialogResult.OK)
                Close();
            this.Show();
        }


    }
}

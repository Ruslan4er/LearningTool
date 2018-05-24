using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MyApp.Tests;
using Telerik.WinControls;
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
            radPageViewPage1.Item.Click += radPageViewPage1_Click;
            radPageViewPage2.Item.Click += radPageViewPage2_Click;
            radPageViewPage3.Item.Click += radPageViewPage3_Click;
            radPageViewPage4.Item.Click += radPageViewPage4_Click;
            radPageViewPage5.Item.Click += radPageViewPage5_Click;
            radPageViewPage6.Item.Click += radPageViewPage6_Click;
            radPageViewPage7.Item.Click += radPageViewPage7_Click;
            radPageViewPage8.Item.Click += radPageViewPage8_Click;
            radPageViewPage9.Item.Click += radPageViewPage9_Click;
        }

        private void CloseFormPictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TheoryForm_Load(object sender, EventArgs e)
        {
            var itemFont = new Font(TheoryPageView.Font.FontFamily, 11);
            var titleFont = new Font(TheoryPageView.Font.FontFamily, 15, FontStyle.Bold);
            var stripElement = (RadPageViewStripElement)TheoryPageView.ViewElement;
            foreach (RadPageViewStripItem item in stripElement.ItemContainer.ItemLayout.Children)
                item.Font = itemFont;
            radPageViewItemPage1.Item.Font = titleFont;
        }

        private void radPageViewPage1_Click(object sender, EventArgs e)
        {
            TheoryPdfViewer1.LoadDocument(Application.StartupPath + "\\Content\\Theory\\1.pdf");
            _chapterId = 1;
        }

        private void radPageViewPage3_Click(object sender, EventArgs e)
        {
            TheoryPdfViewer3.LoadDocument(Application.StartupPath + "\\Content\\Theory\\3.pdf");
            _chapterId = 3;
        }

        private void radPageViewPage4_Click(object sender, EventArgs e)
        {
            TheoryPdfViewer4.LoadDocument(Application.StartupPath + "\\Content\\Theory\\4.pdf");
            _chapterId = 4;
        }

        private void radPageViewPage5_Click(object sender, EventArgs e)
        {
            TheoryPdfViewer5.LoadDocument(Application.StartupPath + "\\Content\\Theory\\5.pdf");
            _chapterId = 5;
        }

        private void radPageViewPage6_Click(object sender, EventArgs e)
        {
            TheoryPdfViewer6.LoadDocument(Application.StartupPath + "\\Content\\Theory\\6.pdf");
            _chapterId = 6;
        }

        private void radPageViewPage7_Click(object sender, EventArgs e)
        {
            TheoryPdfViewer7.LoadDocument(Application.StartupPath + "\\Content\\Theory\\7.pdf");
            _chapterId = 7;
        }

        private void radPageViewPage8_Click(object sender, EventArgs e)
        {
            TheoryPdfViewer8.LoadDocument(Application.StartupPath + "\\Content\\Theory\\8.pdf");
            _chapterId = 8;
        }

        private void radPageViewPage9_Click(object sender, EventArgs e)
        {
            TheoryPdfViewer9.LoadDocument(Application.StartupPath + "\\Content\\Theory\\9.pdf");
            _chapterId = 9;
        }

        private void radPageViewPage2_Click(object sender, EventArgs e)
        {
            TheoryPdfViewer2.LoadDocument(Application.StartupPath + "\\Content\\Theory\\2.pdf");
            _chapterId = 2;
        }

        private void OpenTestsFormPictureBox_Click(object sender, EventArgs e)
        {
            if (_chapterId == 0)
            {
                RadMessageBox.Show("Выберите главу");
                return;
            }
            var frm = new TestsForm(_chapterId);
            frm.Closed += (s, args) => Show(); 
            frm.Load += (s, args) => Hide();
            frm.ShowDialog();
            //Hide();
            if (frm.DialogResult != DialogResult.OK)
                Close();
            //this.Show();
        }


    }
}

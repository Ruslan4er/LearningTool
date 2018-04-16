using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace MyApp.Labs
{
    public partial class LabsForm : Telerik.WinControls.UI.RadForm
    {
        public LabsForm()
        {
            InitializeComponent();
            LoadDocs();
        }

        private void LoadDocs()
        {
            radPdfViewer1.LoadDocument(Application.StartupPath + "\\Content\\Labs\\lab1.pdf");
            radPdfViewer2.LoadDocument(Application.StartupPath + "\\Content\\Labs\\lab2.pdf");
            radPdfViewer3.LoadDocument(Application.StartupPath + "\\Content\\Labs\\lab3.pdf");
            radPdfViewer4.LoadDocument(Application.StartupPath + "\\Content\\Labs\\lab4.pdf");
            radPdfViewer5.LoadDocument(Application.StartupPath + "\\Content\\Labs\\lab5.pdf");
            radPdfViewer6.LoadDocument(Application.StartupPath + "\\Content\\Labs\\lab6.pdf");
            radPdfViewer7.LoadDocument(Application.StartupPath + "\\Content\\Labs\\lab7.pdf");
            radPdfViewer8.LoadDocument(Application.StartupPath + "\\Content\\Labs\\lab8.pdf");
            radPdfViewer9.LoadDocument(Application.StartupPath + "\\Content\\Labs\\lab9.pdf");
            radPdfViewer10.LoadDocument(Application.StartupPath + "\\Content\\Labs\\lab10.pdf");
            radPdfViewer11.LoadDocument(Application.StartupPath + "\\Content\\Labs\\lab11.pdf");
            radPdfViewer12.LoadDocument(Application.StartupPath + "\\Content\\Labs\\lab12.pdf");
            radPdfViewer13.LoadDocument(Application.StartupPath + "\\Content\\Labs\\lab13.pdf");
        }

        private void CloseFormPictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

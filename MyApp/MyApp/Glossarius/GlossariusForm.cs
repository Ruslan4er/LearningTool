using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace MyApp.Glossarius
{
    public partial class GlossariusForm : Telerik.WinControls.UI.RadForm
    {
        public GlossariusForm()
        {
            InitializeComponent();
        }

        private void CloseFormPictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

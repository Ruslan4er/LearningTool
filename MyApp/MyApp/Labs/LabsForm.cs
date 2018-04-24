using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        }

        private void CloseFormPictureBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LabsForm_Load(object sender, EventArgs e)
        {
            var newfont = new Font(this.TheoryPageView.Font.FontFamily, 11);
            var stripElement = (RadPageViewStripElement)this.TheoryPageView.ViewElement;
            foreach (RadPageViewStripItem item in stripElement.ItemContainer.ItemLayout.Children)
                item.Font = newfont;
        }

        private void CalculateFirstT(int U, int I, int I1, int I2, int I3)
        {
            P1Table1TextBox.Text = (I1 * U).ToString();
            P2Table1TextBox.Text = (I2 * U).ToString();
            P3Table1TextBox.Text = (I3 * U).ToString();
            PTable1TextBox.Text = (I * U).ToString();
            DisableFields(FirstTableLayoutPanel);
        }

        private void DisableFields(TableLayoutPanel table)
        {
            var counter = 0;
            foreach (var tb in table.Controls.OfType<TextBox>())
            {
                if (counter > 3)
                    break;

                tb.Enabled = true;
                tb.ReadOnly = true;
                counter++;
            }
        }

        private void CalculateSecondT(int U, int I, int I1, int I2, int I3)
        {
            P1Table2TextBox.Text = (I1 * U).ToString();
            P2Table2TextBox.Text = (I2 * U).ToString();
            P3Table2TextBox.Text = (I3 * U).ToString();
            PTable2TextBox.Text = (I * U).ToString();
            DisableFields(SecondTableLayoutPanel);
        }



        private static bool IsFieldFill(TableLayoutPanel table)
        {
            var counter = 0;
            foreach (var tb in table.Controls.OfType<TextBox>().Reverse())
            {
                if (counter > 4)
                    break;
                if (string.IsNullOrEmpty(tb.Text) || !int.TryParse(tb.Text, out var a))
                    return false;
                counter++;
            }
            return true;
        }

        private void CalculateFirstTableDataButton_Click(object sender, EventArgs e)
        {
            if (!IsFieldFill(FirstTableLayoutPanel))
            {
                RadMessageBox.Show(@"Поля не заполнены или введены неверные значения!");
                return;
            }

            CalculateFirstTable();
        }

        private void CalculateFirstTable()
        {
            var U = int.Parse(UTable1TextBox.Text);
            var I = int.Parse(ITable1TextBox.Text);
            var I1 = int.Parse(I1Table1TextBox.Text);
            var I2 = int.Parse(I2Table1TextBox.Text);
            var I3 = int.Parse(I3Table1TextBox.Text);

            CalculateFirstT(U, I, I1, I2, I3);
        }

        private void CalculateSecondTable()
        {
            var U = int.Parse(UTable2TextBox.Text);
            var I = int.Parse(ITable2TextBox.Text);
            var I1 = int.Parse(I1Table2TextBox.Text);
            var I2 = int.Parse(I2Table2TextBox.Text);
            var I3 = int.Parse(I3Table2TextBox.Text);

            CalculateSecondT(U, I, I1, I2, I3);
        }

        private void CalculateSecondTableButton_Click(object sender, EventArgs e)
        {
            if (!IsFieldFill(SecondTableLayoutPanel))
            {
                RadMessageBox.Show(@"Поля не заполнены или введены неверные значения!");
                return;
            }

            CalculateSecondTable();
        }
    }
}

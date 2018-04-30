using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace MyApp.Labs
{
    public partial class LabsForm : RadForm
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

        private void CalculateFirstT(int u, int i, int i1, int i2, int i3)
        {
            P1Table1TextBox.Text = (i1 * u).ToString();
            P2Table1TextBox.Text = (i2 * u).ToString();
            P3Table1TextBox.Text = (i3 * u).ToString();
            PTable1TextBox.Text = (i * u).ToString();
            DisableFields(FirstTableLayoutPanel);
        }

        private static void DisableFields(TableLayoutPanel table)
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

        private void CalculateSecondT(int u, int i, int i1, int i2, int i3)
        {
            P1Table2TextBox.Text = (i1 * u).ToString();
            P2Table2TextBox.Text = (i2 * u).ToString();
            P3Table2TextBox.Text = (i3 * u).ToString();
            PTable2TextBox.Text = (i * u).ToString();
            DisableFields(SecondTableLayoutPanel);
        }
        
        private static bool IsFieldFill(TableLayoutPanel table)
        {
            var counter = 0;
            foreach (var tb in table.Controls.OfType<TextBox>().Reverse())
            {
                if (counter > 4)
                    break;
                if (string.IsNullOrEmpty(tb.Text) || !int.TryParse(tb.Text, out var _))
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
            var u = int.Parse(UTable1TextBox.Text);
            var i = int.Parse(ITable1TextBox.Text);
            var i1 = int.Parse(I1Table1TextBox.Text);
            var i2 = int.Parse(I2Table1TextBox.Text);
            var i3 = int.Parse(I3Table1TextBox.Text);

            CalculateFirstT(u, i, i1, i2, i3);
        }

        private void CalculateSecondTable()
        {
            var u = int.Parse(UTable2TextBox.Text);
            var i = int.Parse(ITable2TextBox.Text);
            var i1 = int.Parse(I1Table2TextBox.Text);
            var i2 = int.Parse(I2Table2TextBox.Text);
            var i3 = int.Parse(I3Table2TextBox.Text);

            CalculateSecondT(u, i, i1, i2, i3);
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

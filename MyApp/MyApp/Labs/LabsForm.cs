using System;
using System.Collections.Generic;
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
            var textFont = new Font(this.TheoryPageView.Font.FontFamily, 12);
            var stripElement = (RadPageViewStripElement)this.TheoryPageView.ViewElement;
            foreach (RadPageViewStripItem item in stripElement.ItemContainer.ItemLayout.Children)
                item.Font = textFont;
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

        private void radScrollablePanel1_Click(object sender, EventArgs e)
        {

        }

        private void radScrollablePanel1_PanelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CalculateThirdTableButton_Click(object sender, EventArgs e)
        {
            var textBoxesList = new List<TextBox>
            {
                R1Table3_1TextBox,
                R1Table3_2TextBox,
                R2Table3_1TextBox,
                R2Table3_2TextBox,
                R3Table3_1TextBox,
                R3Table3_2TextBox,
            };

            if (!IsFieldsFill(textBoxesList))
            {
                RadMessageBox.Show(@"Поля не заполнены или введены неверные значения!");
                return;
            }
            CalculateThirdTable();
        }


        private void CalculateThirdTable()
        {
            var r1_1 = int.Parse(R1Table3_1TextBox.Text);
            var r1_2 = int.Parse(R1Table3_1TextBox.Text);
            var r2_1 = int.Parse(R2Table3_1TextBox.Text);
            var r2_2 = int.Parse(R2Table3_1TextBox.Text);
            var r3_1 = int.Parse(R3Table3_1TextBox.Text);
            var r3_2 = int.Parse(R3Table3_1TextBox.Text);

            CalculateThirdT(r1_1, r1_2, r2_1, r2_2, r3_1, r3_2);
        }

        private void CalculateThirdT(int r11, int r12, int r21, int r22, int r31, int r32)
        {
            RTable3_1TextBox.ReadOnly = false;
            RTable3_2TextBox.ReadOnly = false;

            RTable3_1TextBox.Text = (r11 + r21 + r31).ToString();
            RTable3_2TextBox.Text = ((r12 + r22 + r32) / 2.5).ToString();
            RTable3_1TextBox.Enabled = true;
            RTable3_1TextBox.ReadOnly = true;
            RTable3_2TextBox.Enabled = true;
            RTable3_2TextBox.ReadOnly = true;
        }

        private void CalculateFourthTableButton_Click(object sender, EventArgs e)
        {
            var textBoxesList = new List<TextBox>
            {
                UTable4_1TextBox,
                UTable4_2TextBox,
                U1Table4_1TextBox,
                U1Table4_2TextBox,
                U23Table4_1TextBox,
                U23Table4_2TextBox,
                I1Table4_1TextBox,
                I1Table4_2TextBox,
                I2Table4_1TextBox,
                I2Table4_2TextBox,
                I3Table4_1TextBox,
                I3Table4_2TextBox,
            };

            if (!IsFieldsFill(textBoxesList))
            {
                RadMessageBox.Show(@"Поля не заполнены или введены неверные значения!");
                return;
            }
            CalculateFourthTable();
        }

        private void CalculateFourthTable()
        {
            var U_1 = int.Parse(UTable4_1TextBox.Text);
            var U_2 = int.Parse(UTable4_2TextBox.Text);
            var U1_1 = int.Parse(U1Table4_1TextBox.Text);
            var U1_2 = int.Parse(U1Table4_2TextBox.Text);
            var U23_1 = int.Parse(U23Table4_1TextBox.Text);
            var U23_2 = int.Parse(U23Table4_2TextBox.Text);
            var I1_1 = int.Parse(I1Table4_1TextBox.Text);
            var I1_2 = int.Parse(I1Table4_2TextBox.Text);
            var I2_1 = int.Parse(I2Table4_1TextBox.Text);
            var I2_2 = int.Parse(I2Table4_2TextBox.Text);
            var I3_1 = int.Parse(I3Table4_1TextBox.Text);
            var I3_2 = int.Parse(I3Table4_2TextBox.Text);
            
            RTable4_1TextBox.Text = (17).ToString();
            RTable4_2TextBox.Text = (23).ToString();
            R1Table4_1TextBox.Text = (U1_1/I1_1).ToString();
            R1Table4_2TextBox.Text = (U1_2 / I1_2).ToString();
            R2Table4_1TextBox.Text = (U23_1 / I2_1).ToString();
            R2Table4_2TextBox.Text = (U23_2 / I2_2).ToString();
            R3Table4_1TextBox.Text = (U23_1 / I3_1).ToString();
            R3Table4_2TextBox.Text = (U23_2 / I3_2).ToString();

            DisableElem();
        }

        private void DisableElem()
        {
            RTable4_1TextBox.Enabled = true;
            RTable4_1TextBox.ReadOnly = true;
            RTable4_2TextBox.Enabled = true;
            RTable4_2TextBox.ReadOnly = true;
            R1Table4_1TextBox.Enabled = true;
            R1Table4_1TextBox.ReadOnly = true;
            R1Table4_2TextBox.Enabled = true;
            R1Table4_2TextBox.ReadOnly = true;
            R2Table4_1TextBox.Enabled = true;
            R2Table4_1TextBox.ReadOnly = true;
            R2Table4_2TextBox.Enabled = true;
            R2Table4_2TextBox.ReadOnly = true;
            R3Table4_1TextBox.Enabled = true;
            R3Table4_1TextBox.ReadOnly = true;
            R3Table4_2TextBox.Enabled = true;
            R3Table4_2TextBox.ReadOnly = true;
        }

        private static bool IsFieldsFill(IEnumerable<TextBox> textBoxesList)
        {
            return textBoxesList.All(textBox => !string.IsNullOrEmpty(textBox.Text));
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            var printDialog1 = new PrintDialog();
            printDialog1.ShowDialog();
        }
    }
}

namespace MyApp.UserProfileForms
{
    partial class UserProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfileForm));
            this.TestResultGridView = new Telerik.WinControls.UI.RadGridView();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseFormPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TestResultGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestResultGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseFormPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // TestResultGridView
            // 
            this.TestResultGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.TestResultGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.TestResultGridView.EnableHotTracking = false;
            this.TestResultGridView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.TestResultGridView.ForeColor = System.Drawing.Color.Black;
            this.TestResultGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TestResultGridView.Location = new System.Drawing.Point(175, 94);
            // 
            // 
            // 
            this.TestResultGridView.MasterTemplate.AllowAddNewRow = false;
            this.TestResultGridView.MasterTemplate.AllowColumnReorder = false;
            this.TestResultGridView.MasterTemplate.AllowColumnResize = false;
            this.TestResultGridView.MasterTemplate.AllowDeleteRow = false;
            this.TestResultGridView.MasterTemplate.AllowEditRow = false;
            this.TestResultGridView.MasterTemplate.AllowRowResize = false;
            this.TestResultGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.TestResultGridView.MasterTemplate.EnableGrouping = false;
            this.TestResultGridView.MasterTemplate.EnableSorting = false;
            this.TestResultGridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.TestResultGridView.Name = "TestResultGridView";
            this.TestResultGridView.ReadOnly = true;
            this.TestResultGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TestResultGridView.Size = new System.Drawing.Size(703, 522);
            this.TestResultGridView.TabIndex = 0;
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.splitPanel1);
            this.radSplitContainer1.Controls.Add(this.splitPanel2);
            this.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.radSplitContainer1.Name = "radSplitContainer1";
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer1.Size = new System.Drawing.Size(1358, 690);
            this.radSplitContainer1.TabIndex = 1;
            this.radSplitContainer1.TabStop = false;
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.label1);
            this.splitPanel1.Controls.Add(this.CloseFormPictureBox);
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel1.Size = new System.Drawing.Size(135, 690);
            this.splitPanel1.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(-0.4002954F, 0F);
            this.splitPanel1.SizeInfo.SplitterCorrection = new System.Drawing.Size(-85, 0);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.label2);
            this.splitPanel2.Controls.Add(this.TestResultGridView);
            this.splitPanel2.Location = new System.Drawing.Point(139, 0);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel2.Size = new System.Drawing.Size(1219, 690);
            this.splitPanel2.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0.4002954F, 0F);
            this.splitPanel2.SizeInfo.SplitterCorrection = new System.Drawing.Size(85, 0);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Домой";
            // 
            // CloseFormPictureBox
            // 
            this.CloseFormPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CloseFormPictureBox.Image")));
            this.CloseFormPictureBox.Location = new System.Drawing.Point(22, 12);
            this.CloseFormPictureBox.Name = "CloseFormPictureBox";
            this.CloseFormPictureBox.Size = new System.Drawing.Size(89, 89);
            this.CloseFormPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseFormPictureBox.TabIndex = 7;
            this.CloseFormPictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(266, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Результаты прохождения тестов";
            // 
            // UserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 690);
            this.Controls.Add(this.radSplitContainer1);
            this.Name = "UserProfileForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "UserProfileForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.TestResultGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestResultGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            this.splitPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            this.splitPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseFormPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView TestResultGridView;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox CloseFormPictureBox;
        private System.Windows.Forms.Label label2;
    }
}

namespace MyApp
{
    partial class MainMenuForm
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
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.TheoryPanel = new System.Windows.Forms.PictureBox();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.LabsPanel = new System.Windows.Forms.PictureBox();
            this.splitPanel3 = new Telerik.WinControls.UI.SplitPanel();
            this.TestingPanel = new System.Windows.Forms.PictureBox();
            this.splitPanel4 = new Telerik.WinControls.UI.SplitPanel();
            this.OpenUserProfileFormButton = new Telerik.WinControls.UI.RadButton();
            this.CloseFormButton = new Telerik.WinControls.UI.RadButton();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TheoryPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LabsPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel3)).BeginInit();
            this.splitPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestingPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel4)).BeginInit();
            this.splitPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpenUserProfileFormButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseFormButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.splitPanel1);
            this.radSplitContainer1.Controls.Add(this.splitPanel2);
            this.radSplitContainer1.Controls.Add(this.splitPanel3);
            this.radSplitContainer1.Controls.Add(this.splitPanel4);
            this.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.radSplitContainer1.Name = "radSplitContainer1";
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer1.Size = new System.Drawing.Size(1358, 690);
            this.radSplitContainer1.TabIndex = 0;
            this.radSplitContainer1.TabStop = false;
            // 
            // splitPanel1
            // 
            this.splitPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitPanel1.Controls.Add(this.label1);
            this.splitPanel1.Controls.Add(this.TheoryPanel);
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel1.Size = new System.Drawing.Size(336, 690);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(112, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Теория";
            // 
            // TheoryPanel
            // 
            this.TheoryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TheoryPanel.Location = new System.Drawing.Point(0, 0);
            this.TheoryPanel.Name = "TheoryPanel";
            this.TheoryPanel.Size = new System.Drawing.Size(332, 686);
            this.TheoryPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TheoryPanel.TabIndex = 0;
            this.TheoryPanel.TabStop = false;
            this.TheoryPanel.Click += new System.EventHandler(this.TheoryPanel_Click);
            // 
            // splitPanel2
            // 
            this.splitPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitPanel2.Controls.Add(this.label2);
            this.splitPanel2.Controls.Add(this.LabsPanel);
            this.splitPanel2.Location = new System.Drawing.Point(340, 0);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel2.Size = new System.Drawing.Size(336, 690);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(98, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "Помощник по \r\nлабораторным";
            // 
            // LabsPanel
            // 
            this.LabsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabsPanel.Location = new System.Drawing.Point(0, 0);
            this.LabsPanel.Name = "LabsPanel";
            this.LabsPanel.Size = new System.Drawing.Size(332, 686);
            this.LabsPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LabsPanel.TabIndex = 1;
            this.LabsPanel.TabStop = false;
            this.LabsPanel.Click += new System.EventHandler(this.LabsPanel_Click);
            // 
            // splitPanel3
            // 
            this.splitPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitPanel3.Controls.Add(this.TestingPanel);
            this.splitPanel3.Location = new System.Drawing.Point(680, 0);
            this.splitPanel3.Name = "splitPanel3";
            // 
            // 
            // 
            this.splitPanel3.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel3.Size = new System.Drawing.Size(336, 690);
            this.splitPanel3.TabIndex = 2;
            this.splitPanel3.TabStop = false;
            this.splitPanel3.Text = "splitPanel3";
            // 
            // TestingPanel
            // 
            this.TestingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestingPanel.Location = new System.Drawing.Point(0, 0);
            this.TestingPanel.Name = "TestingPanel";
            this.TestingPanel.Size = new System.Drawing.Size(332, 686);
            this.TestingPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TestingPanel.TabIndex = 1;
            this.TestingPanel.TabStop = false;
            this.TestingPanel.Click += new System.EventHandler(this.TestingPanel_Click);
            // 
            // splitPanel4
            // 
            this.splitPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitPanel4.Controls.Add(this.OpenUserProfileFormButton);
            this.splitPanel4.Controls.Add(this.CloseFormButton);
            this.splitPanel4.Controls.Add(this.UserNameLabel);
            this.splitPanel4.Controls.Add(this.Label3);
            this.splitPanel4.Location = new System.Drawing.Point(1020, 0);
            this.splitPanel4.Name = "splitPanel4";
            // 
            // 
            // 
            this.splitPanel4.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel4.Size = new System.Drawing.Size(338, 690);
            this.splitPanel4.TabIndex = 3;
            this.splitPanel4.TabStop = false;
            this.splitPanel4.Text = "splitPanel4";
            // 
            // OpenUserProfileFormButton
            // 
            this.OpenUserProfileFormButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OpenUserProfileFormButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenUserProfileFormButton.Location = new System.Drawing.Point(96, 482);
            this.OpenUserProfileFormButton.Name = "OpenUserProfileFormButton";
            this.OpenUserProfileFormButton.Size = new System.Drawing.Size(169, 64);
            this.OpenUserProfileFormButton.TabIndex = 7;
            this.OpenUserProfileFormButton.Text = "Личный кабинет";
            this.OpenUserProfileFormButton.Click += new System.EventHandler(this.OpenUserProfileFormButton_Click);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CloseFormButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseFormButton.Location = new System.Drawing.Point(96, 628);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.Size = new System.Drawing.Size(169, 49);
            this.CloseFormButton.TabIndex = 6;
            this.CloseFormButton.Text = "Выход";
            this.CloseFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameLabel.Location = new System.Drawing.Point(140, 80);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(0, 20);
            this.UserNameLabel.TabIndex = 5;
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label3.Location = new System.Drawing.Point(108, 50);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(123, 20);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Приветствуем,";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 690);
            this.Controls.Add(this.radSplitContainer1);
            this.Name = "MainMenuForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "MainMenuForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            this.splitPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TheoryPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            this.splitPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LabsPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel3)).EndInit();
            this.splitPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TestingPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel4)).EndInit();
            this.splitPanel4.ResumeLayout(false);
            this.splitPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OpenUserProfileFormButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseFormButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private System.Windows.Forms.PictureBox TheoryPanel;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private System.Windows.Forms.PictureBox LabsPanel;
        private Telerik.WinControls.UI.SplitPanel splitPanel3;
        private System.Windows.Forms.PictureBox TestingPanel;
        private Telerik.WinControls.UI.SplitPanel splitPanel4;
        private Telerik.WinControls.UI.RadButton CloseFormButton;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label Label3;
        private Telerik.WinControls.UI.RadButton OpenUserProfileFormButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

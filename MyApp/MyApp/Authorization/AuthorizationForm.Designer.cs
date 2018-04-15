namespace MyApp
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RegistrationLinkLabel = new System.Windows.Forms.LinkLabel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginTextBox
            // 
            resources.ApplyResources(this.LoginTextBox, "LoginTextBox");
            this.LoginTextBox.Name = "LoginTextBox";
            // 
            // PasswordTextBox
            // 
            resources.ApplyResources(this.PasswordTextBox, "PasswordTextBox");
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // RegistrationLinkLabel
            // 
            resources.ApplyResources(this.RegistrationLinkLabel, "RegistrationLinkLabel");
            this.RegistrationLinkLabel.Name = "RegistrationLinkLabel";
            this.RegistrationLinkLabel.TabStop = true;
            this.RegistrationLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegistrationLinkLabel_LinkClicked);
            // 
            // LoginButton
            // 
            resources.ApplyResources(this.LoginButton, "LoginButton");
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.TabStop = false;
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // AuthorizationForm
            // 
            this.AcceptButton = this.LoginButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.RegistrationLinkLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Name = "AuthorizationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel RegistrationLinkLabel;
        private System.Windows.Forms.Button LoginButton;
    }
}


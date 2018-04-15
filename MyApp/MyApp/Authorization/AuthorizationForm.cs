using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyApp.DAL;

namespace MyApp
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private string _userName;

        private void RegistrationLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new RegistrationNewUserForm();
            frm.ShowDialog();
            MessageBox.Show(frm.DialogResult == DialogResult.OK
                ? @"Вы успешно зарегестрированы"
                : @"Регистрация отменена");
        }

        private bool Аuthorization(string login, string password)
        {
            using (var context = new LearningToolDBEntities())
            {
                var user = context.Users.FirstOrDefault(u => u.Login == login);
                if (user == null || user.Password != password) return false;
                _userName = user.UserInformation.Name;
                return true;
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var login = LoginTextBox.Text;
            var password = PasswordTextBox.Text;
            var task = new Task<bool>(() => Аuthorization(login, password));
            task.Start();
            //if (!Аuthorization(login, password))
            if (!task.Result)
                MessageBox.Show(@"Такой пользователь не найден");
            else
            {
                var frm = new MainMenuForm(_userName);
                this.Visible= false;
                frm.ShowDialog();
                this.Visible = true;

            }
        }
    }
}

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
            Аuthorization("222", "222");
        }

        private void RegistrationLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new RegistrationNewUserForm();
            frm.ShowDialog();
            MessageBox.Show(frm.DialogResult == DialogResult.OK
                ? @"Вы успешно зарегестрированы"
                : @"Регистрация отменена");
        }

        private static bool Аuthorization(string login, string password)
        {
            using (var context = new LearningToolDBEntities())
            {
                var user = context.Users.FirstOrDefault(u => u.Login == login);
                if (user == null || user.Password != password) return false;

                RememberUser(user);
                return true;
            }
        }

        private static void RememberUser(User user)
        {
            UserProfile.Login = user.Login;
            UserProfile.Password = user.Login;
            UserProfile.Name = user.UserInformation.Name;
            UserProfile.SecondName = user.UserInformation.SecondName;
            //UserProfile.Groupe = user.UserInformation.Groupe;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var login = LoginTextBox.Text;
            var password = PasswordTextBox.Text;
            var task = new Task<bool>(() => Аuthorization(login, password));
            task.Start();
            if (!task.Result)
                MessageBox.Show(@"Пользователь с таким логином не найден");
            else
            {
                var frm = new MainMenuForm();
                this.Visible = false;
                frm.ShowDialog();
                this.Visible = true;
            }
        }
    }
}

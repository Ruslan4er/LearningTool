using MyApp.DAL;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;

namespace MyApp.Authorization
{
    public partial class AuthorizationForm : Telerik.WinControls.UI.RadForm
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            Аuthorization("222", "222");
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
            UserProfile.Id = user.Id;
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
                RadMessageBox.Show(@"Пользователь с таким логином не найден");
            else
            {
                var frm = new MainMenuForm();
                frm.Closed += (s, args) => this.Show();
                frm.Show();
                this.Hide();
            }
        }

        private void RegistrationLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new RegistrationNewUserForm();
            frm.ShowDialog();
            RadMessageBox.Show(frm.DialogResult == DialogResult.OK
                ? @"Вы успешно зарегестрированы"
                : @"Регистрация отменена");
        }
    }
}

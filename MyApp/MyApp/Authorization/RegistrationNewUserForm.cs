using MyApp.DAL;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace MyApp.Authorization
{
    public partial class RegistrationNewUserForm : RadForm
    {
        public RegistrationNewUserForm()
        {
            InitializeComponent();
        }

        private bool IsDataCorrect()
        {
            if (Controls.OfType<RadTextBox>().Any(pb => string.IsNullOrWhiteSpace(pb.Text)))
            {
                RadMessageBox.Show(@"Заполните все поля");
                return false;
            }

            if (PasswordTextBox.Text != CheckPasswordTextBox.Text)
            {
                RadMessageBox.Show(@"Пароли не совпадают");
                return false;
            }
            return true;
        }

        private bool IsUnique()
        {
            using (var context = new LearningToolDBEntities())
            {
                var users = from user in context.Users
                            where user.Login == LoginTextBox.Text
                            select user;
                return !users.Any();
            }

        }

        private void AddUser()
        {
            using (var context = new LearningToolDBEntities())
            {
                var user = new User
                {
                    Login = LoginTextBox.Text,
                    Password = PasswordTextBox.Text,
                };
                context.Users.Add(user);
                context.SaveChanges();

                var userInfo = new UserInformation
                {
                    Name = NameTextBox.Text,
                    SecondName = SecondNameTextBox.Text,
                    //Groupe = groupe,
                    Id = user.Id
                };

                context.UserInformations.Add(userInfo);
                context.SaveChanges();
            }
        }


        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            if (!IsDataCorrect())
                return;
            if (!IsUnique())
            {
                RadMessageBox.Show(@"Пользователь с таким логином уже существует");
                return;
            }

            AddUser();
            DialogResult = DialogResult.OK;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

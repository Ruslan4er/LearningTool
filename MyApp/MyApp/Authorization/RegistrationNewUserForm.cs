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
    public partial class RegistrationNewUserForm : Form
    {
        public RegistrationNewUserForm()
        {
            InitializeComponent();
        }


        private bool IsDataCorrect()
        {
            return this.Controls.OfType<TextBox>().All(pb => !string.IsNullOrEmpty(pb.Text));
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
                    Name = FirstNameTextBox.Text,
                    SecondName = LastNameTextBox.Text,
                    //Groupe = groupe,
                    Id = user.Id
                };
                context.UserInformations.Add(userInfo);
                context.SaveChanges();
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (!IsDataCorrect())
                MessageBox.Show(@"Заполните все поля");
            else if (!IsUnique())
                MessageBox.Show(@"Пользователь с таким логином уже существует");
            else
            {
                AddUser();
                DialogResult = DialogResult.OK;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

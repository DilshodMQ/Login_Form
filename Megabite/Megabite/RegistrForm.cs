using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Megabite
{
    public partial class RegistrForm : Form
    {
        DB db= new DB();
        public RegistrForm()
        {
            InitializeComponent();
            loginField.Text = "Введите логин";
            loginField.ForeColor = Color.Gray;
            passField.Text = "Введите парол";
            passField.ForeColor = Color.Gray;
            povtorPassField.Text = "Подтвердите парол";
            povtorPassField.ForeColor = Color.Gray;
        }

      

        private void registrBtn_Click(object sender, EventArgs e)
        {
            string login=loginField.Text;
            string pass=passField.Text.ToString();
            string povtorPass = povtorPassField.Text;

            if(!IsUserExist(login)&&IsLoginValid(login)&&IsPasswordValid(pass)&&IsPovtorPassValid(pass,povtorPass))
            { 
            User user= new User();
            user.Login=login;
            user.Password = MD5Service.GetHash(pass);
            db.Users.Add(user);
            db.SaveChanges();
               
            LoginForm loginForm = new LoginForm();
            loginForm.passText = pass;
            loginForm.loginText = login;
            this.Hide();
            loginForm.Show();
            }            
        }

        public Boolean IsUserExist(string login)
        {
            var user = db.Users.Where(u => u.Login == login).FirstOrDefault();
            if (user == null)
            {
                return false;
            }
            else
            {
                MessageBox.Show("Этот логин есть в базе, выберите другой логин.");
                return true;

            }
        }

        public Boolean IsLoginValid(string login)
        {
            if (login.Length < 8)
            {
                MessageBox.Show("Логин не должен быть короче 8 символов.");
                return false;
            }
            else
                return true;
           
        }

        public Boolean IsPasswordValid(string pass)
        {
            if (!(pass.Length == 8))
            {
                MessageBox.Show("Пароль должен состоять из 8 символов.");
                return false;
            }

            if (IsPasswordMatches(pass))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Пароль должен содержать хотя бы одну цифру и хотя бы одну заглавную букву.");
                return false;
            }
        }

        public Boolean IsPasswordMatches(string pass)
        {
            int countNumber = 0;
            int countUpperCase = 0;
            foreach(var i in pass)
            {
                
                if (i >= 49 && i<=58)
                 countNumber++;

                if ((i >= 'A' && i<='Z')|| (i >= 'А' && i<= 'Я'))
                    countUpperCase++;

            }

            if(countNumber>0&&countUpperCase>0) 
            return true;

            else
                return false;

        }
        public Boolean IsSimvolValid(Char ch)
        {
            if((ch>=49&&ch<=58)|| (ch >= 'A' && ch <= 'Z') || (ch >= 'А' && ch <= 'Я')|| (ch >= 'a' && ch <= 'z') || (ch >= 'а' && ch <= 'я'))
            {
                return true;
            }
            else
                return false;
        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {
            if(loginField.Text.Length>0)
            {
                string login = loginField.Text;
                char ch = login[login.Length - 1];
                if (!IsSimvolValid(ch))
                {
                    int index = login.IndexOf(ch);
                    login = login.Remove(index);
                    loginField.Text = login;
                    MessageBox.Show("Введен недопустимый символ.");
                }
            }
            
        }

        private void passField_TextChanged(object sender, EventArgs e)
        {
            if (passField.Text.Length > 0)
            {
                string pass = passField.Text;
                char ch = pass[pass.Length - 1];
                if (!IsSimvolValid(ch))
                {
                    int index = pass.IndexOf(ch);
                    pass = pass.Remove(index);
                    passField.Text = pass;
                    MessageBox.Show("Введен недопустимый символ.");
                }
            }

        }

        private void povtorPassField_TextChanged(object sender, EventArgs e)
        {
            if (povtorPassField.Text.Length > 0)
            {
                string povtorPass = povtorPassField.Text;
                char ch = povtorPass[povtorPass.Length - 1];
                if (!IsSimvolValid(ch))
                {
                    int index = povtorPass.IndexOf(ch);
                    povtorPass = povtorPass.Remove(index);
                    povtorPassField.Text = povtorPass;
                    MessageBox.Show("Введен недопустимый символ.");
                }
            }
        }

        private Boolean IsPovtorPassValid(string pass, string povtorPass)
        {
            if(pass==povtorPass)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Пароль не подтвержден.");
                return false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            passField.UseSystemPasswordChar = false;
            pictureBox5.Visible = false;
            pictureBox4.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            passField.UseSystemPasswordChar = true;
            pictureBox5.Visible = true;
            pictureBox4.Visible = false;
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "Введите парол")
            {
                passField.Text = "";
                passField.UseSystemPasswordChar = true;
                passField.ForeColor = Color.Black;
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.Text = "Введите парол";
                passField.UseSystemPasswordChar = false;
                passField.ForeColor = Color.Gray;
            }
        }

        private void povtorPassField_Leave(object sender, EventArgs e)
        {
            if (povtorPassField.Text == "")
            {
                povtorPassField.Text = "Подтвердите парол";
                povtorPassField.UseSystemPasswordChar = false;
                povtorPassField.ForeColor = Color.Gray;
            }
        }

        private void povtorPassField_Enter(object sender, EventArgs e)
        {
            if (povtorPassField.Text == "Подтвердите парол")
            {
                povtorPassField.Text = "";
                povtorPassField.UseSystemPasswordChar = true;
                povtorPassField.ForeColor = Color.Black;
            }
        }

        private void loginField_Enter(object sender, EventArgs e)
        {

            if (loginField.Text == "Введите логин")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Введите логин";
                loginField.ForeColor = Color.Gray;
            }
        }
    }
}

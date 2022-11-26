using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Megabite
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.pictureBox4.Visible = false;
            loginField.Text = "Введите логин";
            loginField.ForeColor = Color.Gray;
            passField.Text = "Введите парол";
            passField.ForeColor = Color.Gray;
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            string login = loginField.Text;
            string pass = MD5Service.GetHash(passField.Text);
            DB dB = new DB();
            var user =dB.Users.FirstOrDefault(u=>u.Login==login);
            if (user!=null)
            {
                if(user.Password==pass)
                {
                    if (rememberCheckBox.Checked == true)
                    {
                        SaveCrediantials();
                    }
                    else
                    {
                        if (File.Exists("UserCrediantials.txt"))
                            File.Delete("UserCrediantials.txt");
                    }
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Введен неверный пароль.");
                }

            }
            else
            {
                MessageBox.Show("Этот пользователь не зарегистрирован.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrForm registrForm=new RegistrForm();  
            registrForm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            passField.UseSystemPasswordChar = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            passField.UseSystemPasswordChar = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;

        }

        private async Task SaveCrediantials()
        {
            using (StreamWriter wr=new StreamWriter("UserCrediantials.txt"))
            {
                User user = new User();
                user.Login = loginField.Text;
                user.Password=passField.Text;
                var data=JsonSerializer.Serialize(user); 
                await wr.WriteLineAsync(data);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if(File.Exists("UserCrediantials.txt"))
            {
                using(StreamReader reader=new StreamReader("UserCrediantials.txt"))
                {
                    var data= reader.ReadToEnd();
                    User user=JsonSerializer.Deserialize<User>(data);
                    loginField.Text = user.Login;
                    passField.Text = user.Password;
                }
            }

        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите логин")
            {
                loginField.Text = "";
                loginField.ForeColor=Color.Black; 
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

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "Введите парол")
            {
                passField.Text = "";
                passField.UseSystemPasswordChar= true;
                passField.ForeColor = Color.Black;
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.Text = "Введите парол";
                passField.UseSystemPasswordChar= false;
                passField.ForeColor = Color.Gray;
            }
        }
    }
}

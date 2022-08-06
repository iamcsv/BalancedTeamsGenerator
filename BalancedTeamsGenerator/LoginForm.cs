using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalancedTeamsGenerator
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.LoginNameTextBox.AutoSize = false;
            this.LoginPasswordTextBox.AutoSize = false;
            this.LoginPasswordTextBox.Size = new Size(this.LoginPasswordTextBox.Size.Width, 50);
            this.LoginNameTextBox.Size = new Size(this.LoginNameTextBox.Size.Width, 50);
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeLabel_MouseEnter(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.Red;
        }

        private void closeLabel_MouseLeave_1(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.White;
        }

        private void loginEnterButton_MouseEnter(object sender, EventArgs e)
        {
            loginEnterButton.ForeColor = Color.White;
        }
        private void loginEnterButton_MouseLeave(object sender, EventArgs e)
        {
            loginEnterButton.ForeColor = Color.PaleGreen;
        }

        private void loginRegButton_MouseEnter_1(object sender, EventArgs e)
        {
            loginRegButton.ForeColor = Color.White;
        }

        private void loginRegButton_MouseLeave_1(object sender, EventArgs e)
        {
            loginRegButton.ForeColor = Color.PaleGreen;
        }

        Point lastPoint; 
        private void loginMainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void loginMainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void loginEnterButton_Click(object sender, EventArgs e)
        {
            String LoginUser = LoginNameTextBox.Text;
            String PassUser = LoginPasswordTextBox.Text;

            DataBase db = new DataBase();

            DataTable mytable = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", db.GetConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = PassUser;

            adapter.SelectCommand = command;
            adapter.Fill(mytable);

            if (mytable.Rows.Count > 0)
            {
                MessageBox.Show("Login successful");
                this.Hide();
                MainForm mainForm = new MainForm(); 
                mainForm.Show();
            }
            else
                MessageBox.Show("Login unsuccessful");
        }

        private void LoginNameTextBox_Enter(object sender, EventArgs e)
        {
            if (LoginNameTextBox.Text == "Login Name")
            {
                LoginNameTextBox.Text = "";
                LoginNameTextBox.ForeColor = Color.Black;
            }
        }

        private void LoginNameTextBox_Leave(object sender, EventArgs e)
        {
            if (LoginNameTextBox.Text == "")
            {
                LoginNameTextBox.Text = "Login Name";
                LoginNameTextBox.ForeColor = Color.Gray;
            }
        }

        private void LoginPasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (LoginPasswordTextBox.Text == "Password")
            {
                LoginPasswordTextBox.Text = "";
                LoginPasswordTextBox.ForeColor = Color.Black;
            }
        }

        private void LoginPasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (LoginPasswordTextBox.Text == "")
            {
                LoginPasswordTextBox.Text = "Password";
                LoginPasswordTextBox.ForeColor = Color.Gray;
            }
        }

        private void loginRegButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm RegisterForm = new RegisterForm();
            RegisterForm.Show();
        }
    }
}

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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            RegNameTextBox.Text = "Enter Name";
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void RegRegButton_MouseEnter_1(object sender, EventArgs e)
        {
            RegRegButton.ForeColor = Color.White;
        }

        private void RegRegButton_MouseLeave_1(object sender, EventArgs e)
        {
            RegRegButton.ForeColor = Color.PaleGreen;
        }

        private void closeLabel_MouseEnter_1(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.Red;
        }

        private void closeLabel_MouseLeave(object sender, EventArgs e)
        {
            closeLabel.ForeColor = Color.White;
        }

        private void RegNameTextBox_Enter(object sender, EventArgs e)
        {
            if (RegNameTextBox.Text == "Enter Name")
            { 
                RegNameTextBox.Text = "";
                RegNameTextBox.ForeColor = Color.Black;
            }
        }

        private void RegNameTextBox_Leave(object sender, EventArgs e)
        {
            if (RegNameTextBox.Text == "")
            {
                RegNameTextBox.Text = "Enter Name";
                RegNameTextBox.ForeColor = Color.Gray;
            }
        }

        private void RegPasswordTextBox1_Enter(object sender, EventArgs e)
        {
            if (RegPasswordTextBox1.Text == "Password")
            {
                RegPasswordTextBox1.Text = "";
                RegPasswordTextBox1.ForeColor = Color.Black;
            }
        }

        private void RegPasswordTextBox1_Leave(object sender, EventArgs e)
        {
            if (RegPasswordTextBox1.Text == "")
            {
                RegPasswordTextBox1.Text = "Password";
                RegPasswordTextBox1.ForeColor = Color.Gray;
            }
        }

        private void RegPasswordTextBox2_Enter(object sender, EventArgs e)
        {
            if (RegPasswordTextBox2.Text == "Password")
            {
                RegPasswordTextBox2.Text = "";
                RegPasswordTextBox2.ForeColor = Color.Black;
            }
        }

        private void RegPasswordTextBox2_Leave(object sender, EventArgs e)
        {
            if (RegPasswordTextBox2.Text == "")
            {
                RegPasswordTextBox2.Text = "Password";
                RegPasswordTextBox2.ForeColor = Color.Gray;
            }
        }

        private void RegRegButton_Click(object sender, EventArgs e)
        {

            if (RegNameTextBox.Text == "Enter Name")
            {
                MessageBox.Show("Enter Name");
                return;
            }

            if (RegPasswordTextBox1.Text == "Password")
            {
                MessageBox.Show("Enter Password");
                return;
            }

            if (RegPasswordTextBox2.Text == "Password")
            {
                MessageBox.Show("Enter Password in each field");
                return;
            }

            if (RegPasswordTextBox2.Text != RegPasswordTextBox1.Text)
            {
                MessageBox.Show("Passwords don't match");
                return;
            }
            if (isUserExists())
                return;


            String RegUser = RegNameTextBox.Text;
            String PassUser = RegPasswordTextBox1.Text;
            String PassUser2 = RegPasswordTextBox2.Text;

            DataBase db = new DataBase();

            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`) VALUES (@login, @pass)", db.GetConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = RegUser;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PassUser;


            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Registration successful");
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();

            }
            else
            {
                MessageBox.Show("Registration unsuccessful");
            }

            db.closeConnection();
        }

        public Boolean isUserExists()
        {
            DataBase db = new DataBase();

            DataTable mytable = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.GetConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = RegNameTextBox.Text;

            adapter.SelectCommand = command;
            adapter.Fill(mytable);

            if (mytable.Rows.Count > 0)
            {
                MessageBox.Show("This Name is used, try another");
                return true;
            }
            else
                return false;
        }

        private void backLoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();
        }

        private void backLoginButton_MouseEnter(object sender, EventArgs e)
        {
            backLoginButton.ForeColor = Color.White;
        }

        private void backLoginButton_MouseLeave(object sender, EventArgs e)
        {
            backLoginButton.ForeColor = Color.PaleGreen;
        }
    }
}

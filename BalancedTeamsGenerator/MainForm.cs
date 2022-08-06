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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BalanceButton_Click(object sender, EventArgs e)
        {
            List<Player> allPalyers = GetPlayersFromForm()
                .OrderByDescending(x => x.Rating)
                .ToList();

            List<Player> team1 = new List<Player>();
            List<Player> team2 = new List<Player>();
            int team1Rating = 0;
            int team2Rating = 0;

            while (allPalyers.Count > 0)
            {
                if (team1.Count > team2.Count)
                {
                    team2.Add(allPalyers[0]);
                    team2Rating += allPalyers[0].Rating;
                }
                else if (team2.Count > team1.Count)
                {
                    team1.Add(allPalyers[0]);
                    team1Rating += allPalyers[0].Rating;
                }
                else
                {
                    if (team1Rating > team2Rating)
                    {
                        team2.Add(allPalyers[0]);
                        team2Rating += allPalyers[0].Rating;
                    }
                    else
                    {
                        team1.Add(allPalyers[0]);
                        team1Rating += allPalyers[0].Rating;
                    }
                }
                allPalyers.RemoveAt(0);
            }

            OutputPlayersToForm(team1, team2);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            List<Player> allPalyers = GetPlayersFromFormForShuffle()
                .OrderByDescending(x => x.Rating)
                .ToList();

            List<Player> team1 = new List<Player>();
            List<Player> team2 = new List<Player>();

            Random random = new Random();
            List<Player> shuffledPlayerList = new List<Player>();
            while (allPalyers.Any())
            {
                int idx = random.Next(allPalyers.Count);
                shuffledPlayerList.Add(allPalyers[idx]);
                allPalyers.RemoveAt(idx);
            }
            int i = 0;
            for (; i < shuffledPlayerList.Count / 2; i++)
            {
                team1.Add(shuffledPlayerList[i]);
            }
            for (; i < shuffledPlayerList.Count; i++)
            {
                team2.Add(shuffledPlayerList[i]);
            }

            OutputPlayersToForm2(team1, team2);
        }

        private void OutputPlayersToForm(List<Player> team1, List<Player> team2)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Team 1: ");
            sb.Append(team1.Sum(x => x.Rating));
            sb.AppendLine();
            foreach (Player player in team1)
            {
                sb.Append(player.Name).Append(" (").Append(player.Rating).AppendLine(")");
            }
            sb.AppendLine();

            sb.Append("Team 2: ");
            sb.Append(team2.Sum(x => x.Rating));
            sb.AppendLine();
            foreach (Player player in team2)
            {
                sb.Append(player.Name).Append(" (").Append(player.Rating).AppendLine(")");
            }

            ResultBox.Text = sb.ToString();
        }

        private void OutputPlayersToForm2(List<Player> team1, List<Player> team2)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Team 1: ");
            foreach (Player player in team1)
            {
                sb.AppendLine(player.Name);
                
            }
            sb.AppendLine();

            sb.AppendLine("Team 2: ");
            foreach (Player player in team2)
            {
                sb.AppendLine(player.Name);
                
            }

            ResultBox.Text = sb.ToString();
        }

        private List<Player> GetPlayersFromForm()
        {
            List<Player> allPalyers = new List<Player>();
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(RBox1.Text))
            {
                allPalyers.Add(new Player { Name = textBox1.Text, Rating = Convert.ToInt32(RBox1.Text) });
            }
            if (!string.IsNullOrWhiteSpace(textBox2.Text) && !string.IsNullOrWhiteSpace(RBox2.Text))
            {
                allPalyers.Add(new Player { Name = textBox2.Text, Rating = Convert.ToInt32(RBox2.Text) });
            }
            if (!string.IsNullOrWhiteSpace(textBox3.Text) && !string.IsNullOrWhiteSpace(RBox3.Text))
            {
                allPalyers.Add(new Player { Name = textBox3.Text, Rating = Convert.ToInt32(RBox3.Text) });
            }
            if (!string.IsNullOrWhiteSpace(textBox4.Text) && !string.IsNullOrWhiteSpace(RBox4.Text))
            {
                allPalyers.Add(new Player { Name = textBox4.Text, Rating = Convert.ToInt32(RBox4.Text) });
            }
            if (!string.IsNullOrWhiteSpace(textBox5.Text) && !string.IsNullOrWhiteSpace(RBox5.Text))
            {
                allPalyers.Add(new Player { Name = textBox5.Text, Rating = Convert.ToInt32(RBox5.Text) });
            }
            if (!string.IsNullOrWhiteSpace(textBox6.Text) && !string.IsNullOrWhiteSpace(RBox6.Text))
            {
                allPalyers.Add(new Player { Name = textBox6.Text, Rating = Convert.ToInt32(RBox6.Text) });
            }
            if (!string.IsNullOrWhiteSpace(textBox7.Text) && !string.IsNullOrWhiteSpace(RBox7.Text))
            {
                allPalyers.Add(new Player { Name = textBox7.Text, Rating = Convert.ToInt32(RBox7.Text) });
            }
            if (!string.IsNullOrWhiteSpace(textBox8.Text) && !string.IsNullOrWhiteSpace(RBox8.Text))
            {
                allPalyers.Add(new Player { Name = textBox8.Text, Rating = Convert.ToInt32(RBox8.Text) });
            }
            if (!string.IsNullOrWhiteSpace(textBox9.Text) && !string.IsNullOrWhiteSpace(RBox9.Text))
            {
                allPalyers.Add(new Player { Name = textBox9.Text, Rating = Convert.ToInt32(RBox9.Text) });
            }
            if (!string.IsNullOrWhiteSpace(textBox10.Text) && !string.IsNullOrWhiteSpace(RBox10.Text))
            {
                allPalyers.Add(new Player { Name = textBox10.Text, Rating = Convert.ToInt32(RBox10.Text) });
            }
            if (!string.IsNullOrWhiteSpace(textBox11.Text) && !string.IsNullOrWhiteSpace(RBox11.Text))
            {
                allPalyers.Add(new Player { Name = textBox11.Text, Rating = Convert.ToInt32(RBox11.Text) });
            }
            if (!string.IsNullOrWhiteSpace(textBox12.Text) && !string.IsNullOrWhiteSpace(RBox12.Text))
            {
                allPalyers.Add(new Player { Name = textBox12.Text, Rating = Convert.ToInt32(RBox12.Text) });
            }
            if (!string.IsNullOrWhiteSpace(textBox13.Text) && !string.IsNullOrWhiteSpace(RBox13.Text))
            {
                allPalyers.Add(new Player { Name = textBox13.Text, Rating = Convert.ToInt32(RBox13.Text) });
            }
            if (!string.IsNullOrWhiteSpace(textBox14.Text) && !string.IsNullOrWhiteSpace(RBox14.Text))
            {
                allPalyers.Add(new Player { Name = textBox14.Text, Rating = Convert.ToInt32(RBox14.Text) });
            }
            return allPalyers;
        }
        private List<Player> GetPlayersFromFormForShuffle()
        {
            List<Player> allPalyers = new List<Player>();
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                allPalyers.Add(new Player { Name = textBox1.Text });
            }
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                allPalyers.Add(new Player { Name = textBox2.Text });
            }
            if (!string.IsNullOrWhiteSpace(textBox3.Text))
            {
                allPalyers.Add(new Player { Name = textBox3.Text });
            }
            if (!string.IsNullOrWhiteSpace(textBox4.Text))
            {
                allPalyers.Add(new Player { Name = textBox4.Text });
            }
            if (!string.IsNullOrWhiteSpace(textBox5.Text))
            {
                allPalyers.Add(new Player { Name = textBox5.Text });
            }
            if (!string.IsNullOrWhiteSpace(textBox6.Text))
            {
                allPalyers.Add(new Player { Name = textBox6.Text });
            }
            if (!string.IsNullOrWhiteSpace(textBox7.Text))
            {
                allPalyers.Add(new Player { Name = textBox7.Text });
            }
            if (!string.IsNullOrWhiteSpace(textBox8.Text))
            {
                allPalyers.Add(new Player { Name = textBox8.Text });
            }
            if (!string.IsNullOrWhiteSpace(textBox8.Text))
            {
                allPalyers.Add(new Player { Name = textBox8.Text });
            }
            if (!string.IsNullOrWhiteSpace(textBox9.Text))
            {
                allPalyers.Add(new Player { Name = textBox9.Text });
            }
            if (!string.IsNullOrWhiteSpace(textBox10.Text))
            {
                allPalyers.Add(new Player { Name = textBox10.Text });
            }
            if (!string.IsNullOrWhiteSpace(textBox11.Text))
            {
                allPalyers.Add(new Player { Name = textBox11.Text });
            }
            if (!string.IsNullOrWhiteSpace(textBox12.Text))
            {
                allPalyers.Add(new Player { Name = textBox12.Text });
            }
            if (!string.IsNullOrWhiteSpace(textBox13.Text))
            {
                allPalyers.Add(new Player { Name = textBox13.Text });
            }
            if (!string.IsNullOrWhiteSpace(textBox14.Text))
            {
                allPalyers.Add(new Player { Name = textBox14.Text });
            }
            return allPalyers;
        }


        /*

        // For FUTURE taking data from somewhere and puting into the fields


        // Further change with SQL data source:

        private void button2_Click(object sender, EventArgs e)
        {
            List<Player> players = new List<Player>
            {
                new Player {Name = "asd", Rating = 1},
                new Player {Name = "zxcv", Rating = 3},
                new Player {Name = "qwe", Rating = 4},
                new Player {Name = "uyrt", Rating = 7},
                new Player {Name = "bnm", Rating = 8},
            };

            while (this.groupBox1.Controls.Count > 0)
            {
                this.groupBox1.Controls.RemoveAt(0);
            }

            for (int i = 0; i < players.Count; i++)
            {
                Player player = players[i];

                this.panel2.Controls["textBox" + (i+1)].Text = player.Name;
                this.panel2.Controls["RBox" + (i+1)].Text = player.Rating.ToString();

                TextBox textBox = new System.Windows.Forms.TextBox();
                textBox.Location = new System.Drawing.Point(10, 60 + i*40);
                textBox.Name = "textBox_" + i;
                textBox.Size = new System.Drawing.Size(120, 31);
                textBox.Text = player.Name;
                this.groupBox1.Controls.Add(textBox);

                TextBox rTextBox = new System.Windows.Forms.TextBox();
                rTextBox.Location = new System.Drawing.Point(140, 60 + i * 40);
                rTextBox.Name = "rTextBox_" + i;
                rTextBox.Size = new System.Drawing.Size(30, 31);
                rTextBox.Text = "" + player.Rating;
                this.groupBox1.Controls.Add(rTextBox);
            }
        }

        */

        private void BalanceButton_MouseEnter(object sender, EventArgs e)
        {
            BalanceButton.ForeColor = Color.White;
        }

        private void BalanceButton_MouseLeave(object sender, EventArgs e)
        {
            BalanceButton.ForeColor = Color.PaleGreen;
        }

        private void ShuffleButton_MouseEnter(object sender, EventArgs e)
        {
            ShuffleButton.ForeColor = Color.White;
        }

        private void ShuffleButton_MouseLeave(object sender, EventArgs e)
        {
            ShuffleButton.ForeColor = Color.PaleGreen;
        }

        private void CloseLabel1_MouseEnter(object sender, EventArgs e)
        {
            CloseLabel1.ForeColor = Color.Red;
        }

        private void CloseLabel1_MouseLeave(object sender, EventArgs e)
        {
            CloseLabel1.ForeColor = Color.White;
        }

        private void CloseLabel1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }

    public class Player
    {
        public string Name { get; set; }
        public int Rating { get; set; }
    }
}

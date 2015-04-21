using Practice1.Componet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1
{
    public partial class Form1 : Form
    {
        private ConcreateAllControlCenter 隊友 = new ConcreateAllControlCenter();

        private List<Players> players;

        public Form1()
        {
            InitializeComponent();
            MyInit();
        }

        public void MyInit()
        {
            players = new List<Players>()
                {
                  new Players("熊大", 1000, 9,false),
                  new Players("詹姆士", 500, 7,false),
                  new Players("兔兔", 300, 6,false),
                  new Players("沙莉", 0, 2,false),
                };
            UpdateUI();
        }

        public void UpdateUI()
        {
            PlayerTextBox1.Text = players[0].ToString();
            PlayerTextBox2.Text = players[1].ToString();
            PlayerTextBox3.Text = players[2].ToString();
            PlayerTextBox4.Text = players[3].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            players[random.Next(0, 4)].BeAttecked(隊友);

            MessageRichTextBox.Text = "";

            for (int i = 0; i < 隊友.players.Count; i++)
            {
                if (隊友.players[i].生命值 <= 0)
                {
                    MessageRichTextBox.Text += 隊友.RemoveDescription(隊友.players[i]);
                    隊友.RemoveObserver(隊友.players[i]);
                }
                if (隊友.players.Count > 0)
                {
                    if (隊友.players[i].生命值 > 0)
                        MessageRichTextBox.Text += 隊友.players[i].helpDescription;
                }
            }

            UpdateUI();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ButtonBehavior(players[0]);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ButtonBehavior(players[1]);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ButtonBehavior(players[2]);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ButtonBehavior(players[3]);
        }

        public void ButtonBehavior(IObserver player)
        {
            if (player.生命值 > 0)
            {
                if (player.IsAdded)
                {
                    MessageRichTextBox.Text = 隊友.RemoveDescription(player);
                    隊友.RemoveObserver(player);
                    MessageRichTextBox.Text += 隊友.ToString();
                }
                else
                {
                    隊友.RegisterObserver(player);
                    MessageRichTextBox.Text = 隊友.ToString();
                }
            }
            else
            {
                MessageRichTextBox.Text = player.PlayerDied();
            }
        }
    }
}
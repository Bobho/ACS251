using Particle2.Actor;

using Particle2.Componet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Particle2
{
    public partial class PlayGameForm1 : Form
    {
        public PlayGameModel model;
        public Controller controller;
        public bool IsClicked;
        private TextBox[] playerTextBox;

        public PlayGameForm1()
        {
            InitializeComponent();
        }

        public PlayGameForm1(PlayGameModel model, Controller controller)
        {
            InitializeComponent();
            this.model = model;
            this.controller = controller;
            playerTextBox = new TextBox[] { PlayerTextBox0, PlayerTextBox1, PlayerTextBox2, PlayerTextBox3 };
            ActorInfomationUpdate();
        }

        public void ActorInfomationUpdate()
        {
            for (int i = 0; i < model.allActorList.Count; i++)
                playerTextBox[i].Text = model.allActorList[i].ToString();
        }

        public void OnOneAttackCompleteUpdate(object sender, EventArgs e)
        {
            ActorInfomationUpdate();
            MessageRichTextBox.Text += model.MessageText;
            model.MessageText = "";
        }

        public void IsAttackedActor(object sender, EventArgs e)
        {
            for (int i = 0; i < controller.ActorList.Count; i++)
                if (model.allActorList[model.ActorNumber].ID == controller.ActorList[i].ID)
                    foreach (var o in controller.ActorList)
                    {
                        MessageRichTextBox.Text += o.MessageHelp;
                        o.MessageHelp = "";
                    }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controller.Play();
        }

        private void pictureBox0_Click(object sender, EventArgs e)
        {
            controller.AddMyTeamBehavior(model.allActorList[0]);
            MessageRichTextBox.Text += controller.MessageText;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            controller.AddMyTeamBehavior(model.allActorList[1]);
            MessageRichTextBox.Text += controller.MessageText;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            controller.AddMyTeamBehavior(model.allActorList[2]);
            MessageRichTextBox.Text += controller.MessageText;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            controller.AddMyTeamBehavior(model.allActorList[3]);
            MessageRichTextBox.Text += controller.MessageText;
        }
    }
}
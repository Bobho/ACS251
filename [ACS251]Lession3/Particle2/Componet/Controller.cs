using Particle2.Actor;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Particle2.Componet
{
    public class Controller
    {
        public string MessageText { get; private set; }

        public List<Actors> ActorList { get; private set; }

        public PlayGameModel model { get; set; }

        public Form MainForm { get; set; }

        public Controller(PlayGameModel model)
        {
            ActorList = new List<Actors>();
            this.model = model;
            MainForm = new PlayGameForm1(model, this);
            model.OneAttackCompleted += (MainForm as PlayGameForm1).IsAttackedActor;
            model.OneAttackCompleted += (MainForm as PlayGameForm1).OnOneAttackCompleteUpdate;
            // model.attacker.AttacterInPlay += (MainForm as PlayGameForm1).IsAttackedActor0;
        }

        public void RegisterAttacker(Actors actor)
        {
            actor.RegisterAttacker(model.attacker);
            ActorList.Add(actor);
            //model.attacker.AttacterInPlay += (MainForm as PlayGameForm1).IsAttackedActor0;
        }

        public void RemoveAttacker(Actors actor)
        {
            actor.RemoveAttacker(model.attacker);
            ActorList.Remove(actor);
            //model.attacker.AttacterInPlay -= (MainForm as PlayGameForm1).IsAttackedActor0;
        }

        public void Play()
        {
            model.Play();
        }

        public void AddMyTeamBehavior(Actors actorID)
        {
            foreach (Actors o in model.allActorList)
                if (o.Equals(actorID))
                {
                    if (o.LifeValue > 0)
                    {
                        if (!o.IsClick)
                        {
                            this.RegisterAttacker(o);
                            MessageText = string.Format("{0}加入隊伍\n", o.Name);
                            //o.IsClick = true;
                        }
                        else
                        {
                            this.RemoveAttacker(o);
                            MessageText = string.Format("{0}退出隊伍\n", o.Name);
                            //o.IsClick = false;
                        }
                    }
                    else
                    {
                        MessageText = string.Format("{0}死了\n", o.Name);
                        MessageText += string.Format("-----------------------------\n");
                    }
                }
        }
    }
}
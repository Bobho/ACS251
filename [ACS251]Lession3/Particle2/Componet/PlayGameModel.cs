using Particle2.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle2.Componet
{
    public class PlayGameModel
    {
        public Attacker attacker;

        public List<Actors> allActorList;

        // public List<Actors> RegistActorList;

        public ActorsTeam actorTeam;

        public event EventHandler OneAttackCompleted;

        public int ActorNumber { get; set; }

        public Random randomActor;

        public Random randomHurtValue;

        public int TotleChecks { get; private set; }

        public string MessageText { get; set; }

        public PlayGameModel()
        {
            attacker = new Attacker();
            actorTeam = new ActorsTeam();
            allActorList = new List<Actors>();
            randomActor = new Random();
            randomHurtValue = new Random();
            InitActors();
        }

        public void InitActors()
        {
            allActorList.Add(actorTeam.AttackActors("Actor0"));
            allActorList.Add(actorTeam.AttackActors("Actor1"));
            allActorList.Add(actorTeam.AttackActors("Actor2"));
            allActorList.Add(actorTeam.AttackActors("Actor3"));
        }

        public void OnOneAttackCompleted(EventArgs e)
        {
            this.OneAttackCompleted(this, e);
        }

        public void Play()
        {
            TotleChecks++;

            int hurtValue = randomHurtValue.Next(100, 400);
            IsAttackedActor();
            AttackEventArgs attackEventArgs = new AttackEventArgs(hurtValue, allActorList[ActorNumber].Name);
            allActorList[ActorNumber].BeAttacked(attackEventArgs);
            attacker.OnAttackerInPlay(attackEventArgs);
            MessageText += string.Format("第{0}回合結束\n", TotleChecks);
            OnOneAttackCompleted(attackEventArgs);
        }

        public void IsAttackedActor()
        {
            ActorNumber = randomActor.Next(0, 4);
            MessageText += this.allActorList[ActorNumber].ToString();
        }
    }
}
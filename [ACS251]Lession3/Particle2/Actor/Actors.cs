using Particle2.Componet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle2.Actor
{
    public abstract class Actors
    {
        public string MessageText { get; set; }

        public string MessageHelp { get; set; }

        public int LifeValue { get; protected set; }

        public int Level { get; protected set; }

        public string Name { get; protected set; }

        public int HurtValue { protected get; set; }

        public string ID { get; protected set; }

        public bool IsClick { get; set; }

        public Actors()
        {
        }

        public void RegisterAttacker(Attacker attacker)
        {
            attacker.AttacterInPlay += HelpHandleFunction;
            this.IsClick = true;
        }

        public void RemoveAttacker(Attacker attacker)
        {
            attacker.AttacterInPlay -= HelpHandleFunction;
            this.IsClick = false;
        }

        private void HelpHandleFunction(object sender, EventArgs e)
        {
            AttackEventArgs attackEventArgs = e as AttackEventArgs;
            if (this.Name != attackEventArgs.BeAttactedName)
                MessageHelp = string.Format("{0}!{1}被攻擊了，快來救他!!\n", this.Name, attackEventArgs.BeAttactedName);
            else
                MessageHelp = string.Format("{0}被攻擊了!!\n", this.Name);
        }

        public void BeAttacked(EventArgs e)
        {
            AttackEventArgs attackEventArgs = e as AttackEventArgs;
            LifeValue -= attackEventArgs.HurtValue;
            if (LifeValue > 0)
            {
                MessageText = string.Format("{0}遭到攻擊，生命值剩{1}\n", Name, LifeValue);
            }
            else
            {
                LifeValue = 0;
                MessageText = string.Format("{0}已經掛了，生命值剩{1}\n", Name, LifeValue);
            }
        }

        public override string ToString()
        {
            string description = string.Empty;
            description += string.Format("姓名:{0}\r\n", Name);
            description += string.Format("生命值:{0}\r\n", LifeValue);
            description += string.Format("等級:{0}\r\n", Level);

            return description;
        }
    }
}
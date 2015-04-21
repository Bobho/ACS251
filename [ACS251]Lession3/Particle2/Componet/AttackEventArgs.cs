using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle2.Componet
{
    public class AttackEventArgs : EventArgs
    {
        public int HurtValue { get; private set; }

        public string BeAttactedName { get; private set; }

        public AttackEventArgs(int hurtValue, string beAttactedName)
        {
            this.HurtValue = hurtValue;
            this.BeAttactedName = beAttactedName;
        }
    }
}
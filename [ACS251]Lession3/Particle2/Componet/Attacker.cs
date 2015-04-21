using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle2.Componet
{
    public class Attacker
    {
        public event EventHandler<AttackEventArgs> AttacterInPlay;

        public void OnAttackerInPlay(AttackEventArgs e)
        {
            EventHandler<AttackEventArgs> attacterInPlay = this.AttacterInPlay;

            if (attacterInPlay != null)
                attacterInPlay(this, e);
        }
    }
}
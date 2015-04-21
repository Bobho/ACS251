using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle2.Actor
{
    public abstract class ActorsFactory
    {
        public Actors AttackActors(string type)
        {
            Actors actor = this.CreatrActor(type);

            return actor;
        }

        public abstract Actors CreatrActor(string type);
    }
}
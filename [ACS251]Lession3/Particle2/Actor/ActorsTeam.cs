using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle2.Actor
{
    public class ActorsTeam : ActorsFactory
    {
        public override Actors CreatrActor(string type)
        {
            if (type.Equals("Actor0"))
                return new 熊大();
            else if (type.Equals("Actor1"))
                return new 詹姆士();
            else if (type.Equals("Actor2"))
                return new 兔兔();
            else if (type.Equals("Actor3"))
                return new 莎莉();
            else
                return new 熊大();
        }
    }
}
using Particle2.Componet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particle2.Actor
{
    public class 熊大 : Actors
    {
        public 熊大()
        {
            this.Name = "熊大";
            this.Level = 10;
            this.LifeValue = 1000;
            this.ID = "Actor0";
            this.IsClick = false;
        }
    }
}
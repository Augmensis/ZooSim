using System;
using System.Collections.Generic;
using System.Text;

namespace ZooSim.Library.Standard.Models
{
    public class Monkey : Animal
    {

        public Monkey(string name) : base(name) { }


        public override bool IsAlive()
        {
            return Health > 30F;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ZooSim.Library.Standard.Models
{
    public class Giraffe : Animal
    {
        public Giraffe(string name) : base(name) { }


        public override bool IsAlive()
        {
            return Health > 50F;
        }
    }
}

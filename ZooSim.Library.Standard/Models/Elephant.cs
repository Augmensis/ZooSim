using System;
using System.Collections.Generic;
using System.Text;

namespace ZooSim.Library.Standard.Models
{
    public class Elephant : Animal
    {
        public Elephant(string name) : base(name) { }


        private bool _cantWalk { get; set; } = false;


        public override bool IsAlive()
        {
            // Default assumption is the Elephant is alive
            bool isAlive = true;

            // Check if it's health has improved
            if(Health >= 70F && _cantWalk)
            {
                // health has improved, so the elephant can walk again (It's a miracle!)
                _cantWalk = false;
            }
            
            // If the elephant has low health
            if(Health < 70F)
            {                
                if (_cantWalk)
                    isAlive = false;    // Can't walk and low health. Elephant is not alive.
                else
                    _cantWalk = true;   // First round of not being able to walk. Elephant is still alive.
            }

            return isAlive;
        }


        public override string MortalityDescription()
        {
            if (IsAlive() && _cantWalk) return "Can't Walk";

            else return base.MortalityDescription();
        }
        
            
        
    }
}

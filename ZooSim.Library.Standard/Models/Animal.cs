using System;
using System.Collections.Generic;
using System.Text;
using ZooSim.Library.Standard.Interfaces;

namespace ZooSim.Library.Standard.Models
{
    public class Animal : IAnimal
    {

        public Animal(string name)
        {
            Name = name;
        }


        public string Name { get; set; }


        public float Health { get; set; } = 100F;
        

        public void AddHealth(float percent)
        {
            // If an animal isn't alive, there isn't much point in feeding it.
            if (IsAlive())
            {
                // calculate the new health value as a percentage of the existing health value
                var newHealth = Health + (Health * (percent/100));

                // Limit any new health gains to 100F max, otherwise, use the new calculated health value
                Health = newHealth > 100F ? 100F : newHealth;
            }
        }


        public virtual bool IsAlive()
        {
            throw new NotImplementedException();
        }


        public virtual string MortalityDescription()
        {
            return IsAlive() ? "Alive" : "Dead";
        }
    }
}

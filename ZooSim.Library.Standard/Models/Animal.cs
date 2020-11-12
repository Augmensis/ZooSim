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
        

        /// <summary>
        /// Adds/subtracts health for the animal as a percentage of its existing health value.
        /// </summary>
        /// <param name="percent"></param>
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


        /// <summary>
        /// Calculates whether or not an animal is still alive depending on it's nature.
        /// </summary>
        /// <returns></returns>
        public virtual bool IsAlive()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Calculates whether or not an animal is still alive depending on it's nature.
        /// </summary>
        /// <returns></returns>
        public virtual string MortalityDescription()
        {
            return IsAlive() ? "Alive" : "Dead";
        }
    }
}

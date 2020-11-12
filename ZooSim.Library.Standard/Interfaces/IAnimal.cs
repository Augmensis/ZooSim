using System;
using System.Collections.Generic;
using System.Text;

namespace ZooSim.Library.Standard.Interfaces
{
    public interface IAnimal
    {
        /// <summary>
        /// Adds/subtracts health for the animal as a percentage of its existing health value.
        /// </summary>
        /// <param name="percent"></param>
        void AddHealth(float percent);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using ZooSim.Library.Standard.Models;

namespace ZooSim.Library.Standard.Interfaces
{
    public interface IZoo
    {

        /// <summary>
        /// Name of the Zoo.
        /// </summary>
        string Name { get; set; }


        /// <summary>
        /// A dictionary of all anumals grouped by type.
        /// </summary>
        Dictionary<string, List<Animal>> Animals { get; set; }


        /// <summary>
        /// Allow the visting user to feed the animals at random.
        /// </summary>
        void FeedAnimals();


        /// <summary>
        /// Reduce the health of all animals randomly due to the passing of time.
        /// </summary>
        void Perish();
    }
}

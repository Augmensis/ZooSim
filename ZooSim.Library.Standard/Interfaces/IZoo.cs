using System;
using System.Collections.Generic;
using System.Text;
using ZooSim.Library.Standard.Models;

namespace ZooSim.Library.Standard.Interfaces
{
    public interface IZoo
    {
        string Name { get; set; }

        Dictionary<string, List<Animal>> Animals { get; set; }

        void FeedAnimals();

        void Perish();
    }
}

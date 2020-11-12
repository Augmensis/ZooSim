using System;
using System.Collections.Generic;
using System.Text;
using ZooSim.Library.Standard.Interfaces;

namespace ZooSim.Library.Standard.Services
{
    /// <summary>
    /// Random Number Generator Service inheriting from an interface to allow us to Mock for Unit Testing or replace with other RNG services.
    /// </summary>
    public class RandomNumGenService : IRandomNumGenService
    {
        private Random _random { get; set; }


        public RandomNumGenService()
        {
            _random = new Random();
        }


        public int GenerateRandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
    }
}

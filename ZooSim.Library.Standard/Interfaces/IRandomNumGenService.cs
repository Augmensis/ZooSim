using System;
using System.Collections.Generic;
using System.Text;

namespace ZooSim.Library.Standard.Interfaces
{
    public interface IRandomNumGenService
    {
        /// <summary>
        /// Generates a random number between a min and max integer value
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        int GenerateRandomNumber(int min, int max);
    }
}

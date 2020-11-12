using System;
using System.Collections.Generic;
using System.Text;

namespace ZooSim.Library.Standard.Interfaces
{
    public interface IRandomNumGenService
    {
        int GenerateRandomNumber(int min, int max);
    }
}

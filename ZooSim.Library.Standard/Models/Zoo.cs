using System;
using System.Collections.Generic;
using System.Text;
using ZooSim.Library.Standard.Interfaces;

namespace ZooSim.Library.Standard.Models
{
    public class Zoo : IZoo
    {

        private readonly IRandomNumGenService _numGenService;


        /// <summary>
        /// Create a new, empty Zoo
        /// </summary>
        /// <param name="zooName"></param>
        /// <param name="numGenService"></param>
        public Zoo(string zooName, IRandomNumGenService numGenService)
        {
            Name = zooName;

            _numGenService = numGenService;
        }


        /// <summary>
        /// Override for creating a zoo with a specific list of animals
        /// </summary>
        /// <param name="zooName"></param>
        /// <param name="numGenService"></param>
        /// <param name="animals"></param>
        public Zoo(string zooName, IRandomNumGenService numGenService, Dictionary<string, List<Animal>> animals)
        {
            Name = zooName;

            _numGenService = numGenService;

            Animals = animals;
        }


        public string Name { get; set; }


        public Dictionary<string, List<Animal>> Animals { get; set; } = new Dictionary<string, List<Animal>>();

        
        public void FeedAnimals()
        {
            // Loop through all animal types
            foreach (var animalType in Animals)
            {
                // Generate a random number between 0 and 25 to feed this type of animal
                var feedGroup = _numGenService.GenerateRandomNumber(10, 25);

                // Loop through all of the animals within those types
                foreach (var animal in animalType.Value)
                {                  
                    animal.AddHealth((float)feedGroup);
                }
            }
        }


        public void Perish()
        {
            // Loop through all animal types
            foreach (var animalType in Animals)
            {
                // Loop through all of the animals within those types
                foreach (var animal in animalType.Value)
                {
                    // Generate a random number between 0 and 20 to reduce the animal's health. Invert it for a reduction.
                    var reduceHealth = _numGenService.GenerateRandomNumber(0, 20) * -1;

                    animal.AddHealth((float)reduceHealth);
                }
            }
        }
    }
}

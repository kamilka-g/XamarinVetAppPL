using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinWeterynarz
{
    public class AnimalService
    {
        private readonly Dictionary<string, int> maxAgePerAnimal = new Dictionary<string, int>
    {
        { "Pies", 18 },
        { "Kot", 20 },
        { "Świnka Morska", 9 }
    };

        public int GetMaxAge(string species)
        {
            return maxAgePerAnimal.TryGetValue(species, out var maxAge) ? maxAge : 10;
        }
    }
}

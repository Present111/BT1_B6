using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1_B6
{
    internal class Farm
    {
        public Cow Cows { get; set; }
        public Sheep Sheep { get; set; }
        public Goat Goats { get; set; }

        public Farm(int cows, int sheep, int goats)
        {
            Cows = new Cow(cows);
            Sheep = new Sheep(sheep);
            Goats = new Goat(goats);
        }

        public string GetSounds()
        {
            return $"{Cows.MakeSound()} {Sheep.MakeSound()} {Goats.MakeSound()}";
        }

        public int TotalMilk()
        {
            return Cows.Milk() + Sheep.Milk() + Goats.Milk();
        }

        public int TotalOffspring()
        {
            return Cows.GiveBirth() + Sheep.GiveBirth() + Goats.GiveBirth();
        }
    }
}

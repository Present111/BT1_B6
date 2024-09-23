using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1_B6
{
    internal class Sheep: Animal
    {
        private static Random random = new Random();

        public Sheep(int quantity) : base(quantity, "Sheep") { }

        public override string MakeSound()
        {
            return "Baa!";
        }

        public override int Milk()
        {
            int milk = 0;
            for (int i = 0; i < Quantity; i++)
            {
                milk += random.Next(0, 6);
            }
            return milk;
        }

        public override int GiveBirth()
        {
            int after = 0;
            for (int i = 0; i < Quantity; i++)
            {
                after += random.Next(1, 3); 
            }
            return after;
        }
    }
}

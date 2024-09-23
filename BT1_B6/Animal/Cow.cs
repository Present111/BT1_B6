using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1_B6
{
    internal class Cow: Animal
    {
        private static Random random = new Random();

        public Cow(int quantity) : base(quantity, "Cow") { }

        public override string MakeSound()
        {
            return "Moo!";
        }

        public override int Milk()
        {
            int milk = 0;
            for (int i = 0; i < Quantity; i++)
            {
                milk += random.Next(0, 21);
            }
            return milk;
        }

        public override int GiveBirth()
        {
            int after = 0;
            for (int i = 0; i < Quantity; i++)
            {
                after += random.Next(1, 4); 
            }
            return after;
        }
    }
}

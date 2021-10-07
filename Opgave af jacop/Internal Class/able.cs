using System;
using System.Collections.Generic;

namespace Opgave_af_jacop.Internal_Class
{
    public class Able : IEable, IItem
    {

        public void Eat(Player player)
        {
            player.Heath += 12;
            player.Inv.Remove(this);
            Console.WriteLine($"you ate {this}");
        }

        public void PickUp(Player player)
        {
            player.Inv.Add(this);
            Console.WriteLine($"you picked this {this} up");
        }

        public void Drop(Player player)
        {
            player.Inv.Remove(this);
            Console.WriteLine($"you dropped {this}");
        }
    }
}
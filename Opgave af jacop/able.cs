using System;

namespace Opgave_af_jacop
{
    public class Able : IEable, IItem
    {
        public string name = "æble";
        public void Eat(Player player)
        {
            player.Heath += 12;
            player.Inv.Remove(this);
            Console.WriteLine($"you ate {this.name}");
        }

        public void PickUp(Player player)
        {
            player.Inv.Add(this);
            Console.WriteLine($"you picked this {this.name} up");
        }

        public void Drop(Player player)
        {
            player.Inv.Remove(this);
            Console.WriteLine($"you dropped {this.name}");
        }
    }
}
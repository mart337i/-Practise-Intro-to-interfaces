using System;
using System.Collections.Generic;
using Opgave_af_jacop.Weapons;

namespace Opgave_af_jacop.Internal_Class
{
    public class Weapon : IWeapon, IItem
    {
        public void Attack(Player player, Player player2)
        {
            Console.WriteLine(player + "hit" + player2 );
        }

        public void PickUp(Player player)
        {
            player.Inv.Add(this);
            Console.WriteLine($"you picked {this} up");
        }

        public void Drop(Player player)
        {
            player.Inv.Remove(this);
            Console.WriteLine($"you dropped {this}");
        }
    }
}
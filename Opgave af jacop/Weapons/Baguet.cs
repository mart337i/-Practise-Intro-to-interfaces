using System;
using Opgave_af_jacop.Internal_Class;

namespace Opgave_af_jacop.Weapons
{
    public class Baguet : IItem , IWeapon , IEable
    {
        public int Damege = 100;

        
        public void PickUp(Player player)
        {
            player.Inv.Add(this);
        }

        public void Drop(Player player)
        {
            player.Inv.Remove(this);
        }

        public void Attack(Player player, Player player2)
        {
            Console.WriteLine(player + "hit" + player2 );
            player2.Heath -= Damege;
        }

        public void Eat(Player player)
        {
            player.Heath += 50;
            player.Inv.Remove(this);
            Console.WriteLine($"you ate {this}");
        }
    }
}
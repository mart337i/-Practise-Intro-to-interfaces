using System;

namespace Opgave_af_jacop
{
    public class Sword : IItem , IWeapon
    {
        public int Damege = 5;

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
    }
}
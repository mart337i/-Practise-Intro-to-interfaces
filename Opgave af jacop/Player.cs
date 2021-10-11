using System.Collections.Generic;

namespace Opgave_af_jacop
{
    public class Player 
    {
        public List<IItem> Inv = new List<IItem>();

        public int MaxHeath = 100;
        public int MinHeath = 0;
        public int Heath;

        public Player()
        {
            Heath = 100;
        }
    }
}
using Opgave_af_jacop.Internal_Class;

namespace Opgave_af_jacop
{
    public class Gamerule
    {
        public Players CurrentPlayer { get; set; }

        public Gamerule()
        {
            CurrentPlayer = Players.Player1;
        }
        
    }
}
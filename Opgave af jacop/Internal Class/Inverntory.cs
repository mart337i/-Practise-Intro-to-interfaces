using System.Collections.Generic;

namespace Opgave_af_jacop.Internal_Class
{
    public class Inverntory : IItem
    {
        public List<Food> FoodList = new List<Food>();
        

        public void PickUp(Player player)
        {
            throw new System.NotImplementedException();
        }

        public void Drop(Player player)
        {
            throw new System.NotImplementedException();
        }
        
        
    };
}
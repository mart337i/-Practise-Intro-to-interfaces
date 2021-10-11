using System;
using System.Collections.Generic;

namespace Opgave_af_jacop
{

    interface IEable
    {
        void Eat(Player player);
    }

    interface IWeapon 
    {
        void Attack(Player player , Player player2);

    }

    public interface IItem
    {
        void PickUp(Player player);
        void Drop(Player player);

    }
    

    class Program
    {
        
        
        static void Main(string[] args)
        {
            Gamerule match = new Gamerule();
            Axe axe = new Axe();
            Sword sword = new Sword();
            Baguet baguet = new Baguet();
            Player player1 = new Player();
            Player player2 = new Player();
            Able able = new Able();
           
            



            while (true)
            {
                switch (match.CurrentPlayer)
                {
                    case Players.Player1:
                        string choise = Console.ReadLine()?.Trim().ToLower();
                        switch (choise)
                        {
                            case "search":
                                able.PickUp(player1);
                                baguet.PickUp(player1);
                                break;
                            case "attack":
                                axe.Attack(player1,player2);
                                break;
                            case "eat":
                                if (player1.Inv.Contains(able) == true)
                                {
                                    able.Eat(player1);
                                }
                                break;
                        }
                        
                        match.CurrentPlayer = Players.Player2;
                        break;
                    case Players.Player2:
                        string choise2 = Console.ReadLine()?.Trim().ToLower();
                        switch (choise2)
                        {
                            case "search":
                                able.PickUp(player1);
                                baguet.PickUp(player1);
                                break;
                            case "attack":
                                axe.Attack(player1,player2);
                                break;
                            case "eat":
                                if (player1.Inv.Contains(able) == true)
                                {
                                    able.Eat(player1);
                                }
                                break;
                        }
                        match.CurrentPlayer = Players.Player1;
                        
                        break;
                    default:
                        throw new ArgumentException("this broke i guess");
                }
            }
        }
    }
}
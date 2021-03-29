using System;

using static System.Console;

namespace State.Class.FoodState
{
    public class Fullfilled : IPlayerFoodState
    {
        public Fullfilled()
        {
            WriteLine("You now are fullfiled");
        }

        public void Feed(Player player)
        {
            throw new Exception("You cannot feed your character, because he's already fullfilled");
        }

        public void GetStarved(Player player)
        {
            player.StarvationStat -= 90;
            player.FoodActualState = new Starving();
        }

        public void GetStatus(Player player)
        {
            WriteLine($"Actual food stat: {player.StarvationStat}");
        }
    }
}

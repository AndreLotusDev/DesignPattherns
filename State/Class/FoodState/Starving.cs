using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace State.Class.FoodState
{
    public class Starving : IPlayerFoodState
    {
        public Starving()
        {
            WriteLine("You are starving");
        }

        public void Feed(Player player)
        {
            player.StarvationStat += 90;

            player.FoodActualState = new Fullfilled();
        }

        public void GetStarved(Player player)
        {
            throw new Exception("You probally gonna die :/");
        }

        public void GetStatus(Player player)
        {
            WriteLine($"Actual food stat: {player.StarvationStat}");
        }
    }
}

using State.Class.FoodState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace State.Class
{
    public class Player
    {
        public string Name { get; set; }
        public int StarvationStat { get; set; }
        public IPlayerFoodState FoodActualState { get; set; } = new Starving();
        public Player(string name, int starvationStat)
        {
            Name = name;
            StarvationStat = starvationStat;
        }

        public Player(string name, int starvationStat, IPlayerFoodState state)
        {
            Name = name;
            StarvationStat = starvationStat;
            FoodActualState = state;
        }

        public void Feed()
        {
            try
            {
                FoodActualState.Feed(this);
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
        }

        public void GetStarved()
        {
            try
            {
                FoodActualState.GetStarved(this);
            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
        }

        public void GetStatus()
        {
            FoodActualState.GetStatus(this);
        }
    }
}

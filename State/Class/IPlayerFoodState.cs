using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Class
{
    public interface IPlayerFoodState
    {
        void Feed(Player player);

        void GetStarved(Player player);

        void GetStatus(Player player);
    }
}
